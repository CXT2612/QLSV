using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Sinh_Vien.SCORE
{
    class Score
    {
        MY_DB mydb = new MY_DB();
        public bool InsertScore(int Student_ID, int Course_ID, double DiemGK, double DiemCK, string GhiChu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score(SV_ID, C_ID, gk, ck, des)" + "Values (@sid,@cid,@dgk,@dck,@gc)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = Student_ID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = Course_ID;
            command.Parameters.Add("@dgk", SqlDbType.Float).Value = DiemGK;
            command.Parameters.Add("@dck", SqlDbType.Float).Value = DiemCK;
            command.Parameters.Add("@gc", SqlDbType.NChar).Value = GhiChu;
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
        public bool studentScoreExist(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE SV_ID = @sid AND C_ID =@cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            if ((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE  FROM score WHERE SV_ID = @sid AND C_ID =@cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT Course.label, AVG(gk) as 'DiemTB GiuaKi', AVG(ck) as 'DiemTB CuoiKi' FROM Course c,score s WHERE c.id = s.c_id GROUP BY c.label");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudentsScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT score.SV_ID,Student.fname,Student.lname,score.C_ID,course.label,score.gk as'Diem Giua Ki',score.ck as'Diem Cuoi Ki' FROM Student INNER JOIN score ON Student.ID = score.SV_ID INNER JOIN course ON score.c_ID = course.ID");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseScore(int course_ID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT score.sv_id, Student.fname, Student.lname, score.c_id, course.label,score.gk as'Diem Giua Ki',score.ck as'Diem Cuoi Ki' FROM Student INNER JOIN KetQua ON Student.ID = score.SV_ID INNER JOIN course ON score.c_ID = course.ID WHERE score.c_ID =@ID");
            command.Parameters.Add("@ID", SqlDbType.Int).Value = course_ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudentScores(int student_ID)
        { 
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT score.sv_id, Student.fname, Student.lname, score.c_id, course.label,score.gk as 'Diem Giua Ki',score.ck as 'Diem Cuoi Ki' FROM Student INNER JOIN score ON Student.id = score.sv_id INNER JOIN course ON score.c_id = course.id WHERE score.sv_id =@ID");
            command.Parameters.Add("@ID", SqlDbType.Int).Value = student_ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
