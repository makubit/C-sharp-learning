using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Study01
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Student name: ");
                newStudent.Grade = int.Parse(Util.Console.Ask("Student Grade: "));
                newStudent.Birthday = Util.Console.Ask("Student Birthday: ");
                newStudent.Address = Util.Console.Ask("Student Address: ");
                newStudent.Phone = int.Parse(Util.Console.Ask("Student Phone Number: "));

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);

            Console.ReadKey();
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set => phone = value;
            get => phone;
        }
    }

    class Student : Member
    {
        public static int Count = 0;

        public int Grade;
        public string Birthday;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            this.Name = name;
            this.Grade = grade;
            this.Birthday = birthday;
            this.Address = address;
            this.Phone = phone;
        }
    }

    class Teacher : Member
    {
        public string Subject;
    }
}