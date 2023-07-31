using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDelegatesAssignment19_Part1
{
    delegate int ArithmeticOp(int num1, int num2);
    class Program
    {
        static int Add(int num1, int num2) => num1 + num2;
        static int Subtract(int num1, int num2) => num1 - num2;
        static int Multiply(int num1, int num2) => num1 * num2;
        static int Divide(int num1, int num2) => num2 != 0 ? num2 / num1 : throw new ArgumentException("Cannot divide by 0");
        static void Main(string[] args)
        {
            ArithmeticOp add = Add;
            ArithmeticOp subtract = Subtract;
            ArithmeticOp multiply = Multiply;
            ArithmeticOp divide = Divide;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number 1");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number 2");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choose an arithmetic expression to be executed");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Exit");
                    int choice = int.Parse(Console.ReadLine());
                    int result = 0;
                    switch (choice)
                    {
                        case 1:
                            result = add(num1, num2);
                            break;
                        case 2:
                            result = subtract(num1, num2);
                            break;
                        case 3:
                            result = multiply(num1, num2);
                            break;
                        case 4:
                            result = divide(num1, num2);
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program. Press any key to exit");
                            Console.ReadKey();
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again");
                            continue;
                    }
                    Console.WriteLine("Result: " + result);
                }
                catch (Exception ex) 
                { Console.WriteLine("Error: " + ex.Message); }
            }
        }
    }
}
