using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Sinh_Vien
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=desktop-vo7fa4m;Initial Catalog=QLSV;Integrated Security=True");

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }
        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }
    }
}
