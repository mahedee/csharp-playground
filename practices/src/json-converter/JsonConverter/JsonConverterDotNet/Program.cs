using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace JsonConverterDotNet
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Grades { get; set; }
    }




    internal class Program
    {
        // Convert json object to Student Object
        public static Student ConvertToStudent(string stu)
        {
            var serializer = new JavaScriptSerializer();

            return serializer.Deserialize<Student>(stu);
        }

        static void Main(string[] args)
        {
            // Create a json object
            string json = @"{
                ""FirstName"": ""Jon"",
                ""LastName"": ""Doe"",
                ""Grades"": [7, 8, 9]
            }";

            Student student = ConvertToStudent(json);

            Console.WriteLine($"First Name: {student.FirstName}");
            Console.WriteLine($"Last Name: {student.LastName}");
            Console.WriteLine("Grades: ");
            foreach (int grade in student.Grades)
            {
                Console.WriteLine(grade);
            }

            Console.ReadKey();
        }
    }
}
