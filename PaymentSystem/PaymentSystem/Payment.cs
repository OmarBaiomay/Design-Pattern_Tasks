using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    interface Payment
    {
        string Pay();
    }  

   public class Cash: Payment
    {
      public  string  Pay()
        { 
            
            Console.WriteLine("Your Payment Method is Cash");

            return "0";
        }
    } 

   public class Credit : Payment
    {
        public string Pay()
        {
            Console.WriteLine("Your Payment Method is Credit");

            return "0";
        } 
    } 

  public  class Debit : Payment
    {
       public string Pay()
        {
            Console.WriteLine("Your Payment Method is Debit" );

            return "0";
        }
    }
}
