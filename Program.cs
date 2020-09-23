using System;

namespace student
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Student student = new Student(name);

            Console.WriteLine("Enter Year");
            student.Year = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone");
            student.Phone = Console.ReadLine();

            Console.WriteLine("Enter Gender");
            student.Gender = Console.ReadLine();

            Console.WriteLine("Student successfully added");

            Console.WriteLine(student.Output());
        }
    }
}
