// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    public class Student
    {
        public int Roll_no { get; private set; }
        public string Name { get; private set; }
        public int[] Marks { get; private set; }

        public Student(int roll_no, string name, int[] marks)
        {
            Roll_no = roll_no;
            Name = name;
            Marks = marks;
        }
        public int CalculateTotal()
        {
            return Marks.Sum();
        }
        public int CalculatePercentage()
        {
            return CalculateTotal() / Marks.Length;

        }
        public string GetGrade()
        {
            if (CalculatePercentage() >= 90)
            {
                return "A";
            }
            else if (CalculatePercentage() >= 80)
            {
                return "B";
            }
            else if (CalculatePercentage() >= 70)
            {
                return "C";
            }
            else if (CalculatePercentage() >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }



        public static void displayStudents()
        {
            List<Student> students = new List<Student>() {

            new Student(1, "Alice", new int[] { 85, 90, 78, 92, 88 }),
            new Student(2, "Bob", new int[] { 75, 80, 70, 85, 90 }),
            new Student(3, "Ali", new int[] { 95, 92, 88, 90, 94 }),
            new Student(4, "David", new int[] { 60, 65, 70, 75, 80 }),
            new Student(5, "Eve", new int[] { 50, 55, 60, 65, 70 })
            };
            Console.WriteLine("\t Roll No \t Name \t\t Total \t\t Percentage \t Grade \t\t Marks ");

            foreach (var student in students)
            {
                Console.WriteLine($"\t{student.Roll_no} \t\t {student.Name} \t\t {student.CalculateTotal()} \t\t {student.CalculatePercentage()} \t\t {student.GetGrade()} \t\t {string.Join(", ", student.Marks)}");
            }



        }
        class Program
        {
            static void Main(string[] args)
            {
                Student.displayStudents();
            }

        }


        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine("Enter Roll Number: ");
        //        int roll_no = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Enter Name: ");
        //        string name = Console.ReadLine();
        //        int[] marks = new int[5];
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine($"Enter Marks for Subject {i + 1}: ");
        //            marks[i] = Convert.ToInt32(Console.ReadLine());
        //        }
        //        Student student = new Student(roll_no, name, marks);
        //        Console.WriteLine($"\nStudent Details:\nRoll Number: {student.Roll_no}\nName: {student.Name}\nTotal Marks: {student.CalculateTotal()}\nPercentage: {student.CalculatePercentage()}%\nGrade: {student.GetGrade()}");
        //    }
        //}

    }

}