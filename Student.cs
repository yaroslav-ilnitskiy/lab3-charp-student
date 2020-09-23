using System;
namespace student
{
    public class Student
    {
        private string name;
        private int year;
        private string phone;
        private string gender;

        public Student(string name)
        {
            this.Name = name;
        }

        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Year { get => year; set => year = value; }
        public string Name { get => name; set => name = value; }

        public string Output()
        {
            return String.Format(
                "Name - {0}, Year - {1}, Phone - {2}, Gender - {3}",
                this.Name,
                this.Year,
                this.Phone,
                this.Gender
            );
        }
    }
}
