using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    class Program
    { 
   
        static void Main(string[] args)
        { 
            //this is the client payment 
            Console.WriteLine("Please type Your Payment: ");

            string mypayment = Console.ReadLine();

            Client me = new Client();

            me.topay(mypayment);

            //this is the staff payment 

            Console.WriteLine("Please type Your Payment: ");

            string mypayment2 = Console.ReadLine();

            staff me2 = new staff();

            me2.topay(mypayment2);

            Console.ReadKey();
        }
    }
}
