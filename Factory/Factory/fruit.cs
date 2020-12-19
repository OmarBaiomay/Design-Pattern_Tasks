using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class fruit
    { 
        private fruitInterface fruite;
        
        public fruit(string fruit)
        {
             if(fruit == "Apple")
            {
                this.fruite = new Apple();
            } else if (fruit == "Banana")
            {
                this.fruite = new Banana();
            }
            else
            { 
            
                this.fruite = null;
                
            }
        }

        public void printFruit()
        {
            //here to check if he enter a car isnot found or not 
         
            if (this.fruite != null)
            {
                this.fruite.PrintFruit();
            } else
            {
                Console.WriteLine("you try to enter fruit do not exist" );
            }

            

        }
    }
}
