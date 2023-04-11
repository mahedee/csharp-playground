using Newtonsoft.Json;
using System;
using System.Web.Script.Serialization;

namespace SerializerDemo
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Grades { get; set; }
    }

    public class Program
    {
        public static Student ConvertToStudent(string stu)
        {
            // Deserialize a json object using using System.Web.Script.Serialization;
            // support .net core doesn't support

            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<Student>(stu);
        }
        static void Main(string[] args)
        {
            // Define a json object
            string jsonObject = "{\"FirstName\": \"Jon\", \"LastName\": \"Doe\", \"Grades\": [7,8,9]}";

            // Define json in the following way

            //string jsonObject = JsonConvert.SerializeObject(new Student 
            //{ 
            //    FirstName = "Jon",
            //    LastName = "Doe",
            //    Grades = new int[] { 7,8,9}
            //});

            var student = ConvertToStudent(jsonObject);

            Console.WriteLine(student.FirstName +" "+ student.LastName);
            foreach (var grade in student.Grades)
            {
                Console.WriteLine(grade.ToString());
            }

            Console.ReadKey();
        }
    }
}


// Output:
/*

Jon Doe
7
8
9

*/
