using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Q3
{
    class Person
    {
        private string name;
        private Boolean gender;
        private int age;
        private int std;
        private Char div;
        private Double marks;

        public Person() : this(" ", false, 0, 0, '\\', 0.0)
        {

        }
        public Person(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Boolean Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public int Age
        {
            get{ return this.age; }
            set { this.age = value; }
        }
        public int Std
        {
            get{ return this.std; } 
            set { this.std = value; }

        }
        public Char Div
        {
            get{ return this.div; }
            set { this.div = value; }
        }
        public Double Marks
        {
            get { return this.marks; }
            set{ this.marks = value; }
        }

        public void printRecord()
        {
            Console.WriteLine("User Details:");
            Console.WriteLine("Name :" + this.name);
            Console.WriteLine("Gender :" +(this.gender ? "Male" :"FeMale"));
            Console.WriteLine("age :" + this.age);
            Console.WriteLine("std :" + this.std);
            Console.WriteLine("div :" + this.div);
            Console.WriteLine("marks :" + this.marks);
        }
                  
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter True if Male otherwise false");
           bool gender=bool.Parse(Console.ReadLine());
            Console.WriteLine("Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("std : ");
            int std = int.Parse(Console.ReadLine());
            Console.WriteLine("div : ");
            Char div = char.Parse(Console.ReadLine());
            Console.WriteLine("Marks : ");
            double marks = double.Parse(Console.ReadLine());
            Person person = new Person(name,gender,age,std,div,marks);
            person.printRecord();

        }
    }
}
