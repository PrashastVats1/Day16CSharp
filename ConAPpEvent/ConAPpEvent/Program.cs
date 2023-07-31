using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAPpEvent
{
    delegate void OrderEventHandler();
    class Order
    {
        public event OrderEventHandler OnCreated;
        public void Create()
        {
            Console.WriteLine("Order created");
            if (OnCreated != null)
            {
                OnCreated();
            }
        }
    }

    class Email
    {
        public static void Send()
        {
            Console.WriteLine($"Send an Email");
        }
    }
    
    class SMS
    {
        public static void Send()
        {
            Console.WriteLine($"Send an SMS");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.OnCreated += Email.Send;
            order.OnCreated += SMS.Send;
            order.Create();
            Console.ReadKey();
        }
    }
}
