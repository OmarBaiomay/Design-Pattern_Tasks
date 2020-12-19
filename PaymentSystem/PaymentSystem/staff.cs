using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    class staff
    { 
        public void topay(string type)
        {
            if (type == "Cash")
            {
                Payment obj = new Cash();

                obj.Pay();
            } else if (type == "Credit")
            {
                Payment obj = new Credit();

                obj.Pay();
            } else if (type == "Debit")
            {
                Console.WriteLine("Sorry YOu Shouldnot Pay by Debit");
            } else
            {
                Console.WriteLine("Your Payment Method doesnot Clear!!" );
            }
        }
    }
}
