using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDelegateExample
{
    public delegate void OurDelegate(string name);
    internal class Program
    {
        //delegates can represent static and instance methods but the signature must match
        public static void Welcome(string n)
        {
            Console.WriteLine("Welcome to Delegate " + n);
        }
        public void MyMethod(string msg)
        {
            Console.WriteLine("Message for you: "+msg);
        }
        static void Main(string[] args)
        {
            OurDelegate ourDelegate = new OurDelegate(Welcome);
            ourDelegate("Rajiv Kumar");
            Program obj = new Program();
            OurDelegate ourDelegate1 = new OurDelegate(obj.MyMethod);
            ourDelegate1("Let us begin");
            Console.ReadKey();
        }
    }
}
