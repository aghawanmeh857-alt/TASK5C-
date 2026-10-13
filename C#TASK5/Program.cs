using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_TASK5
{
    // Part 1: Person Class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected string SchoolName { get; set; } = "Orange School";

        private string _internalCode = "SCH123";

        // _internalCode cannot be accessed outside Person because it is private.

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }


    // Part 2: Student Class
    class Student : Person
    {
        public int StudentId { get; set; }
        public int Grade { get; set; }

        public Student(string name, int age) : base(name, age)
        {
        }

        public void DisplayStudentInfo()
        {
            DisplayInfo();
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("School: " + SchoolName);
        }
    }


    // Part 3: Teacher Class
    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public void DisplayTeacherInfo()
        {
            DisplayInfo();
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("School: " + SchoolName);
        }
    }


    // Part 5: Sealed Class
    sealed class SchoolReport
    {
        public string ReportTitle { get; set; }

        public SchoolReport(string title)
        {
            ReportTitle = title;
        }

        public void DisplayReportTitle()
        {
            Console.WriteLine("Report Title: " + ReportTitle);
        }
    }

    // SchoolReport cannot be inherited because it is sealed.


    // Part 6: Main Method
    internal class Program
    {
        static void Main(string[] args)
        {
            // First Student
            Student student1 = new Student("Ahmed", 20);
            student1.StudentId = 123;
            student1.Grade = 85;
            student1.DisplayInfo();
            Console.WriteLine("Student ID: " + student1.StudentId);
            Console.WriteLine("Grade: " + student1.Grade);

            Console.WriteLine("--------------------");

            // Second Student
            Student student2 = new Student("Ali", 21);
            student2.StudentId = 124;
            student2.Grade = 90;
            student2.DisplayStudentInfo();

            Console.WriteLine("--------------------");

            // Teacher
            Teacher teacher = new Teacher("Omar", 35, "Math");
            teacher.DisplayTeacherInfo();

            Console.WriteLine("--------------------");

            // Part 4

            Console.WriteLine(student1.Name);

            
            // Console.WriteLine(student1.SchoolName); error

            
            // Console.WriteLine(student1._internalCode); error

            Console.WriteLine("--------------------");

            // School Report
            SchoolReport report = new SchoolReport("Student Report"); // بس انشانا اوبجكت تفعل الكونستركتر
            report.DisplayReportTitle();
        }
    }
}
