using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnemliTemel
{
    internal class Student
    {
        private string ttry = "try";
        public string studentNo, name, surname, universityName;
        private double ex1, ex2, finalEx;

        public string Ttry
        {
            get
            {
                return this.ttry;
            }
            set
            {
                this.ttry = value;
            }
        }
        public Student()
        {
            Console.WriteLine("Student created!");
        }
        public Student(string studentNo, string name, string surname, string universityName) : this()
        {
            this.studentNo = studentNo;
            this.name = name;
            this.surname = surname;
            this.universityName = universityName;
        }

        public void showStudentInformation()
        {
            Console.WriteLine("Student Number: " + studentNo + "\nStudent Name: " + name + "\nStudent Surname: " + surname);

        }
        public double CalculateTermAverage(double ex1, double ex2, double finalEx)
        {
            return (ex1 + ex2 + finalEx) / 3;
        }
        public void bringUniversity()
        {
            Console.WriteLine("Students University: " + universityName);
        }
    }
}
