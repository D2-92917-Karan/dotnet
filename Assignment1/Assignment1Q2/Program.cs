using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static int program(int x, int b, int c)
        { int res=0;
            switch (x)
            {
                case 1:
                    res = b + c;
                    break;
                case 2:
                    res = b - c;
                    break;
                case 3:
                    res = b * c;
                    break;
                case 4:
                    res = b / c;
                    break;
                case 5:
                    break;
            }
            return res;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Enter Numnber1:");
            string str1= Console.ReadLine();
            int num1=int.Parse(str1);
            Console.WriteLine("Enter Number 2");
            string str2 = Console.ReadLine();
            int num2 = int.Parse(str2);
            Console.WriteLine("Enter the cohice");
            Console.WriteLine("1.Addoition");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            string op1 = Console.ReadLine();
            int op = int.Parse(op1);
            Console.WriteLine("Result :"+program(op,num1,num2));
        }
    }
}
