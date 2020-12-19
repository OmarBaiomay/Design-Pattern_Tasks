using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{ 
    public interface fruitInterface
    {
        void PrintFruit();
    }
    class Apple: fruitInterface
    {
        public void PrintFruit()
        {
            Console.WriteLine("this is an Apple" );
        }
    }

    class Banana : fruitInterface
    {
        public void PrintFruit()
        {
            Console.WriteLine("this is a Banana");
        }
    }
}
