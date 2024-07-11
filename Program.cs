using System;

namespace ConsoleApp3
{
    internal class Program
    {
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Student(int iD, string name, int age)
            {
                ID = iD;
                Name = name;
                Age = age;
            }

            public void Prints()
            {
                Console.WriteLine($"ID = {ID} \nName = {Name}\nAge = {Age}");
            }
        }

        static void Main(string[] args)
        {
            // Correct way to instantiate the Student object using the constructor
            Student student = new Student(1, "Mohamed", 20);

            student.Prints();
        }
    }
}
