using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Sinh_Vien.COURSE
{
    class Course
    {
        MY_DB mydb = new MY_DB();
        public bool InsertCourse(int Id, string lable, int stc, int hk)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (id,label,period,semester )" + "Values (@Id,@lbe,@stc,@hk)", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@lbe", SqlDbType.NVarChar).Value = lable;
            command.Parameters.Add("@stc", SqlDbType.Int).Value = stc;
            command.Parameters.Add("@hk", SqlDbType.Int).Value = hk ;
            
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
        public bool checkcoursename(string courseName, int courseId = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label =@cName And id <> @cId", mydb.getConnection);
            command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@cId", SqlDbType.Int).Value = courseId;
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
        public bool checkcourseid(int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE id =@cid ", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
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
        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseById(int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE id= @cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteCourse(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id = @Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
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
        public bool updateCourse(int Id, string lable, int stc, int hk)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET id=@Id,label=@lbe,period=@stc,semester=@hk WHERE id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("lbe", SqlDbType.VarChar).Value = lable;
            command.Parameters.Add("@stc", SqlDbType.Int).Value = stc;
            command.Parameters.Add("@hk", SqlDbType.Int).Value = hk;
            
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
        //get th total course
        public string totalCourse()
        {
            return execCount("SELECT COUNT (*) FROM  Course");
        }
    }
}
