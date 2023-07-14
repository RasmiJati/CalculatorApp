using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("........................................");
                Console.WriteLine("Choose one operation:");
                Console.WriteLine("+ for addition");
                Console.WriteLine("- for subtraction");
                Console.WriteLine("* for multiplication");
                Console.WriteLine("/ for division");
                Console.WriteLine("........................................");

                Console.Write("Enter the operator: ");
                char c = ReadOperator();

                Console.WriteLine("Enter the first number:");
                int num1 = ReadInput();

                Console.WriteLine("Enter the second number:");
                int num2 = ReadInput();

                Operation(num1, num2, c);

                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                string response = Console.ReadLine().ToLower();

                if (response.Equals("n"))
                {
                    exit = true;
                }
            }
        }

        static int ReadInput()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static char ReadOperator()
        {
            char ch = Char.Parse(Console.ReadLine());
            return ch;
        }


        static void Operation(int a, int b, char c)
        {
            switch (c)
            {
                case '+':
                    Console.WriteLine("Result: " + add(a,b));
                    break;
                case '-':
                    Console.WriteLine("Result: " + subtract(a,b));
                    break;
                case '*':
                    Console.WriteLine("Result: " + multiply(a,b));
                    break;
                case '/':
                    Console.WriteLine("Result: " + divide(a,b));
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
    
        static int add(int a , int b)
        {
            return a+b;
            
        }

        static int subtract(int a, int b)
        {
            return a - b;
        }

        static int multiply(int a , int b)
        {
            return a * b;
        }

        static int divide(int a , int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            return 0;
        }
    }
}
