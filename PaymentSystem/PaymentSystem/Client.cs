using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    class Client
    { 
        public void topay(string type="Cash")
        {
            if(type == "Cash")
            { 
                //the obj doesnot show any function although in the Payment InterFace
                Payment obj = new Cash();

                obj.Pay(); 
            } else if (type == "Credit")
            {
                Payment obj = new Credit();

                obj.Pay(); 
                
            }
            else if (type == "Debit")
            {
                Payment obj = new Debit();

                obj.Pay();

            } 
            else
            {
                Console.WriteLine("Your Payment Method Doesnot Clear!!");
            }
        }
    }
}
