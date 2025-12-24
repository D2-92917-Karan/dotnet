using System.Security.Cryptography.X509Certificates;

namespace assignment2
{
    class Person
    {
        private string Name;
        private int Age;

        public Person() 
        {
            this.Name = "";
            this.Age = 0;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void Accept()
        {
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            Age=int.Parse(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Age:{Age}");
        }
    }
    class Emp : Person
    {
        private int Id;
        private double Salary;
        public Emp()
        {
            this.Id = 0;
            this.Salary = 0;
        }
        public Emp(string name, int age,int id,double salay) : base(name, age)
        {
            this.Id = id;
            this.Salary = salay;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter  the Id");
            Id = int.Parse(Console.ReadLine());

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Salary :{Salary}");
        }
        public virtual void CalculateSal(){ }
        public double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double salary)
        {
            this.Salary = salary;
        }
    }

    class Labor : Emp
    {
        private int Hours;
        private double Rate;

        public Labor()
        {
            this.Hours = 0;
            this.Rate = 0;
        }
        public Labor(string name, int age, int id, double salary, int hours, double rate) : base(name, age, id, salary)
        {
            this.Hours = hours;
            this.Rate = rate;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Working Hours:");
            Hours=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate Per Hour");
            Rate=int.Parse(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Hours Workded: {Hours}");
            Console.WriteLine($"Rate per Hour: {Rate}");
        }
        public override void CalculateSal()
        {
           SetSalary(Hours * Rate);
        }
    }

    class Manager : Emp
    {
        private double bonus;
        public Manager()
        {
            this.bonus = 0;
        }
        public Manager(string name, int age, int id, double salary, double bonus):base(name, age, id, salary) 
        {
            this.bonus=bonus;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the Bonus");
            bonus = double.Parse(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Bonus :{bonus}");
        }
        public override void CalculateSal()
        {
            SetSalary(GetSalary() + bonus);
        }
    }
    class Salesman : Emp
    {
        private double Commision;
        public Salesman()
        {
            this.Commision = 0;
        }
        public Salesman(string name, int age, int id, double salary, double Commision) : base(name, age, id, salary)
        {
            this.Commision = Commision;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the Commision:");
            Commision = double.Parse(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Commision :{Commision}");
        }
        public override void CalculateSal()
        {
            SetSalary(GetSalary() + Commision);
        }
    }
    class Clerk : Emp
    {
        public override void Accept()
        {
            base.Accept();
        }
        public override void Display()
        {
            base.Display();
        }
        public override void CalculateSal()
        {
        }
    }
    internal class Program
    {
            static void Main(string[] args)
            {
                Emp[] employees = new Emp[4];

                employees[0] = new Labor();
                employees[1] = new Manager();
                employees[2] = new Salesman();
                employees[3] = new Clerk();

                double totalSalary = 0;

                foreach (Emp e in employees)
                {
                    Console.WriteLine("\n--- Enter Employee Details ---");
                    e.Accept();
                    e.CalculateSal();
                    e.Display();
                    Console.WriteLine("-----------------------------");

                    totalSalary += e.GetSalary();
                }

                Console.WriteLine($"\nTotal Salary Expense = {totalSalary}");
                Console.ReadLine();
            }
        }
    
}
