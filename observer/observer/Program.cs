using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
	class Program
	{
		static void Main(string[] args)
		{
			observers observer1 = new customer();
			observer1.setName("Omar");
			observers observer2 = new customer();
			observer2.setName("Mohamed");
			
			product product = new product();

			product.addCustomer(observer1);
			product.addCustomer(observer2);

			product.setInfo("The product is Avilable Now !!");

			Console.ReadKey();
		}
	}
}
