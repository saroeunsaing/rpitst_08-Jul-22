using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace RPITST
{
    class SQL_Control: SQL_Connection
    {
        public SqlConnection cn;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public DataTable dt;
        public DataSet ds;

        
        #region EXECUTEQUERY   


        // QUERY PARAMETERSdfdsf
        public List<SqlParameter> Params = new List<SqlParameter>();
        public int RecordCount;
        public string Exception;
        public string ReturnQuery;

        public void ExecQuery(String Query , Boolean ReturnIdentity = false)
        {
            //RESET QUERY STATS
            RecordCount = 0;
            Exception = "";

            using (cn = GetConnection()) 
            {
                try
                {
                    cn.Open();
                    // CREATE DB COMMAND
                    cmd = new SqlCommand(Query, cn);
                    // LOAD PARAMS INTO DB COMMAND
                    Params.ForEach(p => cmd.Parameters.Add(p));
                    // CLEAR PARAM LIST
                    Params.Clear();
                    // EXECUTE COMMAND & FILL DATASET
                    dt = new DataTable();
               

                    da = new SqlDataAdapter(cmd);
                    RecordCount = da.Fill(dt);

                if(ReturnIdentity == true) 
                  {
                        ReturnQuery = "SELECT @@IDENTITY As LastID;";
                        // @@IDENTITY - SESSION
                        // SCOPE_IDENTITY() - SESSION & SCOPE
                        // IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                        cmd = new SqlCommand(ReturnQuery, cn);
                        dt = new DataTable();
                        da = new SqlDataAdapter(cmd);
                        RecordCount = da.Fill(dt);
                  }

                }
                catch (Exception ex)
                {
                    // CAPTURE ERROR
                    Exception = "ExecQuery Error: \n" + ex.Message;
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
            }
        }
        
        // ADD PARAMS
        public void AddParam(String Name, Object Value)
        {
            SqlParameter NewParam = new SqlParameter(Name, Value);
            Params.Add(NewParam);
        }
        public Boolean HasException(Boolean Report  = false)
        {
            if(String.IsNullOrEmpty(Exception))
            {
                return false;
            }
            if(Report == true)
            {
                MessageBox.Show(Exception, "Exception:");
            }

            return true;
        }

        #endregion

        public void Retrive(string qty, DataGridView dgv)
        {
            using (var cn = GetConnection())
            {
                cmd = new SqlCommand(qty, cn);
                da = new SqlDataAdapter(cmd);

                dt = new DataTable();

                da.Fill(dt);

                dgv.DataSource = dt;

            }
        }
        public string GetMaxID(string table, string field, int num, string pre, string defualt)

        {
            string id;
            using (var cn = GetConnection())
            {
                cn.Open();
                cmd = new SqlCommand("Select top 1 " + field + " From " + table + " order by " + field + " DESC", cn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    string s = dr.GetString(0);
                    s = s.Substring(num, s.Length - 2);

                    int str = Convert.ToInt32(s) + 1;
                    id = pre + Convert.ToString(str).PadLeft(s.Length, '0');
                }
                else
                {
                    id = defualt;
                }

                dr.Close();

                return id;

                cn.Close();
            }
        }
        DataTable Pivot(DataTable dt, DataColumn pivotColumn, DataColumn pivotValue)
        {
            // find primary key columns 
            //(i.e. everything but pivot column and pivot value)
            DataTable temp = dt.Copy();
            temp.Columns.Remove(pivotColumn.ColumnName);
            temp.Columns.Remove(pivotValue.ColumnName);
            string[] pkColumnNames = temp.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName)
                .ToArray();

            // prep results table
            DataTable result = temp.DefaultView.ToTable(true, pkColumnNames).Copy();
            result.PrimaryKey = result.Columns.Cast<DataColumn>().ToArray();
            dt.AsEnumerable()
                .Select(r => r[pivotColumn.ColumnName].ToString())
                .Distinct().ToList()
                .ForEach(c => result.Columns.Add(c, pivotColumn.DataType));

            // load it
            foreach (DataRow row in dt.Rows)
            {
                // find row to update
                DataRow aggRow = result.Rows.Find(
                    pkColumnNames
                        .Select(c => row[c])
                        .ToArray());
                // the aggregate used here is LATEST 
                // adjust the next line if you want (SUM, MAX, etc...)
                aggRow[row[pivotColumn.ColumnName].ToString()] = row[pivotValue.ColumnName];
            }

            return result;
        }

        public void BindGrid(DataGridView gvDetails, ComboBox cboX,ComboBox cboY,ComboBox cboZ)
        {
           
            ////string query = @"DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
            //            DECLARE @ColumnName AS NVARCHAR(MAX)
            //            SELECT @ColumnName = ISNULL(@ColumnName + ',','')+ QUOTENAME(subject) FROM (SELECT DISTINCT subject FROM score) AS student
            //            SET @DynamicPivotQuery = ';WITH CTE AS(SELECT subject,student,score FROM score)
            //            SELECT student,'+@ColumnName+' FROM CTE
            //            PIVOT (MAX(score) FOR [subject] IN('+@ColumnName+')) p
            //            ORDER BY student DESC'
            //                EXEC(@DynamicPivotQuery)";

            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select * from score";
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        //using (DataTable dt = new DataTable())
                        //{
                        //gvDetails.AutoGenerateColumns = true;
                        //sda.Fill(dt);
                        //gvDetails.DataSource = dt;
                        //// gvDetails.DataBindings();


                        //SqlCommand cmd = new SqlCommand("select * from tbl_data", con);
                        //con.Open();
                        //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        con.Close();
                        
                        gvDetails.DataSource = dt;

                        //}
                    }
                }
            }
        }
    public void REPORT()
        {
            
            using (cn = GetConnection())
            {
            
            }
        }

       public void cmbx(string qty,ComboBox cbx,string index,string value)
        {
            using(var cn = GetConnection())
            {
               //  cn.Open();
                da =new SqlDataAdapter(qty, cn);
                dt = new DataTable();

                da.Fill(dt);

                cbx.DataSource = dt;
                cbx.DisplayMember = value;
                cbx.ValueMember = index;
            }
        }
    }

    
}