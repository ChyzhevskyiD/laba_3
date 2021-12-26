using System;
namespace Laba_3333
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new StudentProfessorTest("Jim");
            test.Main();
        }
    }
    class Person
    {
        public string name { get; set; }
        int age;
        public int SetAge
        {
            set { age = value; }
        }
        public int Greet
        {
            get { return age; }
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge(int x)
        {
            Console.WriteLine($"My age is: " + x + " years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    class StudentProfessorTest
    {
        string name { get; }
        public StudentProfessorTest(string name_)
        {
            name = name_;
        }
        public void Main()
        {
            Console.WriteLine("Good morning said " + name);
            var student = new Student();
            student.SetAge = 19;
            student.name = "Alex";
            Console.WriteLine("Hello, my name is " + student.name + ", i'm a student");
            student.ShowAge(student.Greet);
            var teacher = new Professor();
            teacher.SetAge = 40;
            teacher.name = "Bob";
            Console.WriteLine("Good morning, i'm " + teacher.name + ", i'm " +
           teacher.Greet + " years old");
            teacher.Explain();
        }
    }
}
