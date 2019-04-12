using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Study01
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }
    class Program
    {
        static List<Student> Students = new List<Student>();
        static void Main(string[] args)
        {
            PayRoll p = new PayRoll();
            p.PayAll();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student name: ");
                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");
                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");
                    newStudent.Address = Util.Console.Ask("Student Address: ");
                    newStudent.School = (School)Util.Console.AskInt("School Name (type corresponding number): \n0: Hogwarts, \n1:Harvard, \n2: MIT\n");
                    newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");

                    Students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");
                    if (Console.ReadLine() != "y")
                        adding = false;
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception");
                }
            }

            foreach (var student in Students)
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);

            Exports();

            Console.ReadKey();
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 660660660);
            Console.WriteLine(importedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in Students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }
    }

    public class Member
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
        public School School;

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
}