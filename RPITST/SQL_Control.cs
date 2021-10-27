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


        // QUERY PARAMETERS
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
    }
}
