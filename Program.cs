using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = @"Server=remotemysql.com;Database=wx2j0z2kNU;Uid=wx2j0z2kNU;Pwd=tZrl2EMoOV";
        StudentService studentService = new StudentService(connectionString);

        // Example usage:
        // 1. Add student
        Student newStudent = new Student
        {
            StudentNo = 1,
            StudentName = "",
            StudentDOB = new DateTime(2000, 1, 1),
            StudentDOJ = DateTime.Now
        };
        studentService.AddStudent(newStudent);

        // 2. Update student
        // Implement update logic

        // 3. Delete student
        // Implement delete logic

        // 4. Get list of students
        DataTable students = studentService.GetStudents();
        foreach (DataRow row in students.Rows)
        {
            Console.WriteLine($"{row["STUDENT_NO"]}, {row["STUDENT_NAME"]}, {row["STUDENT_DOB"]}, {row["STUDENT_DOJ"]}");
        }
    }
}
