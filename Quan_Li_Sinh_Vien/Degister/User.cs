using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Sinh_Vien.Degister
{
    class User
    {
        MY_DB mydb = new MY_DB();
        public bool InsertLoGin_SV(int id, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (username,password)" +
                "VALUES (@user,@pass)", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.NChar).Value = id;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
    }
}
