using System;

namespace SerializeDemo
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
            var serializer = new JavaScriptSerializer();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}