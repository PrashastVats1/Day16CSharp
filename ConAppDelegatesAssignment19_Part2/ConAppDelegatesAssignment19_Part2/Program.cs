using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDelegatesAssignment19_Part2
{
    delegate T Operation<T>(T a, T b);
    class Program
    {
        static T Add<T>(T a, T b)=>(dynamic)a + (dynamic) b;
        static T Subtract<T>(T a, T b) => (dynamic)a - (dynamic)b;
        static T Multiply<T>(T a, T b) => (dynamic)a * (dynamic)b;
        static T Divide<T>(T a, T b) => (dynamic)a / (dynamic)b;
        static dynamic ReadInput()
        {
            while (true)
            {
                try
                {
                    return Convert.ChangeType(Console.ReadLine(), typeof(double));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, Please try again");
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter value 1");
                dynamic num1 = ReadInput();
                Console.WriteLine("Enter value 2");
                dynamic num2 = ReadInput();
                Console.WriteLine("Choose an operation");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                int choice = int.Parse(Console.ReadLine());
                Operation<dynamic> operation = null;
                switch (choice)
                {
                    case 1:
                        operation = Add;
                        break;
                    case 2:
                        operation = Subtract;
                        break;
                    case 3:
                        operation = Multiply;
                        break;
                    case 4:
                        operation = Divide;
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program, press any key");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Invalid choice, Try again");
                        continue;
                }
                if(operation != null)
                {
                    try
                    {
                        dynamic result = operation(num1, num2);
                        Console.WriteLine("Result: " + result);
                    }
                    catch(Exception ex) 
                    {
                        Console.WriteLine("Error: "+ex.Message);
                    }
                }
            }
        }
    }
}
