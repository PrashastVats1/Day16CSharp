using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAnonymousMethods
{
    internal class Program
    {
        public delegate void WelDel(string name);
        static void Main(string[] args)
        {
            //Anonymous Method
            WelDel objDel = delegate (string name)
            {
                Console.WriteLine("Welcome to anonymous method Mr./Ms. " + name);
            };
            objDel("Ram Mohan Rai");
            //Normal call/ method
            WelDel objDel1 = new WelDel(OurMethod);
            objDel1("Normal Method");
            //Lambda Method
            WelDel objDel2 = (string name) => Console.WriteLine("Welcome to Lambdas " + name);
            objDel2("Rishi");
            Console.ReadKey();
        }
        public static void OurMethod(string msg)
        {
            Console.WriteLine("Message for you " + msg);
        }
    }
}
