using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            fruit f1 = new fruit("Apple");
            fruit f2 = new fruit("Banana");
            fruit f3 = new fruit("Water Melon");

            f1.printFruit();
            f2.printFruit();
            f3.printFruit();

            Console.ReadKey();
        }
    }
}
