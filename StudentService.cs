using System;
using System.Data;
using System.Data.SqlClient;



public class StudentService
{
    private readonly string connectionString;

    public StudentService(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void AddStudent(Student student)

    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO STUDENT (STUDENT_NO, STUDENT_NAME, STUDENT_DOB, STUDENT_DOJ) " +
                           "VALUES (@StudentNo, @StudentName, @StudentDOB, @StudentDOJ)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentNo", student.StudentNo);
            command.Parameters.AddWithValue("@StudentName", student.StudentName);
            command.Parameters.AddWithValue("@StudentDOB", student.StudentDOB);
            command.Parameters.AddWithValue("@StudentDOJ", student.StudentDOJ);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public void UpdateStudent(Student student)
    {
        // Implement update logic
    }

    public void DeleteStudent(int studentNo)
    {
        // Implement delete logic
    }

    public DataTable GetStudents()
    {
        DataTable dataTable = new DataTable();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM STUDENT";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataTable);
        }
        return dataTable;
    }
}
