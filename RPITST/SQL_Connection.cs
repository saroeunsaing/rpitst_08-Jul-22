using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RPITST
{
    public abstract class SQL_Connection
    {
        //Server Configuration
        private  string datasource  = "RPITST";
        private  string database = "rpitst";
        private  string user_ID  = "sa";
        private  string pwd  = "123";

        private  string cs;

       
        public SQL_Connection()
        {
            cs = "Data Source=" + datasource + ";Initial Catalog=" + database + "; User ID=" + user_ID + ";Password=" + pwd; 
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(cs);
        }
    }
}
