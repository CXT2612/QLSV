using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sinh_Vien.STUDENT
{
    class Student
    {
        MY_DB mydb = new MY_DB();
        public bool InsertStudents(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, int idclass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Student (id, fname, lname, bdate, gender, phone, address, group_id)" +
                "VALUES (@id,@fn,@ln,@bdt,@gdr,@phn,@adrs,@cls)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NChar).Value = address;
            command.Parameters.Add("@cls", SqlDbType.Int).Value = idclass;

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
        public bool checkIdstudent(int Id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE id =@STid ", mydb.getConnection);
            command.Parameters.Add("@STid", SqlDbType.Int).Value = Id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Student WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, int idclass)
        {
            SqlCommand command = new SqlCommand("UPDATE Student SET fname=@fn,lname=@ln,bdate=@bdt,gender=@gdr,phone=@phn," +
                "address=@adrs,group_id=@cls WHERE id=@ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@cls", SqlDbType.Int).Value = idclass;

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
        public string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        //get th total students
        public string totalStudent()
        {
            return execCount("SELECT COUNT (*) FROM  Student");
        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT (*) FROM  Student WHERE gender = '1'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT (*) FROM  Student WHERE gender = '0'");
        }
    }

}

