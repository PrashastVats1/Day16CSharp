using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConAppFunctionPredicateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, string> printFullName = (fn, ln) =>
            { Console.WriteLine("Full Name is " + fn + " " + ln); };
            Console.WriteLine("Action string example");
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter second name");
            string lastName = Console.ReadLine();
            printFullName(firstName, lastName);
            Console.WriteLine();

            Action<double, double, double> printMulti = (n1, n2, n3) =>
            { Console.WriteLine("{0} * {1} * {2}= \t{3} : ", n1, n2, n3, (n1 * n2 * n3)); };
            Console.WriteLine("Action double example");
            Console.WriteLine("Enter first number");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            double thirdNum = double.Parse(Console.ReadLine());
            printMulti(firstNum, secondNum, thirdNum);
            Console.WriteLine();

            Func<double, double, double> multi = (a, b) => a * b;
            Console.WriteLine("Func double example");
            Console.WriteLine("Enter first number");
            double firstN = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondN = double.Parse(Console.ReadLine());
            double thirdN = multi(firstN, secondN);
            Console.WriteLine("After multiplying, {0} * {1} = \t{2}", firstN,secondN,thirdN);
            Console.WriteLine();

            Predicate<int> isEven = (number) => number % 2 == 0;
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            if (isEven(num))
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
            }
            Console.ReadKey();
        }
    }
}
