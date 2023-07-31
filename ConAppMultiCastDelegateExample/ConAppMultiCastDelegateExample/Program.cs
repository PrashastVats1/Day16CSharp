using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMultiCastDelegateExample
{
    internal class Program
    {
        public delegate void CalcDel(double num1, double num2);
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            CalcDel objDel = new CalcDel(cal.Add);
            Console.WriteLine("After adding one method in invocation list");
            objDel(12.5, 13.45);
            objDel += new CalcDel(cal.Diff);
            Console.WriteLine("After adding 2 methods in invocation list");
            objDel(34, 56.5);
            objDel += new CalcDel(cal.Multi);
            Console.WriteLine("After adding 3 methods in invocation list");
            objDel(34, 56.5);
            objDel -= new CalcDel(cal.Diff);
            Console.WriteLine("After removing diff as well");
            objDel(34, 56.5);
            Console.ReadKey();
        }
    }
}
