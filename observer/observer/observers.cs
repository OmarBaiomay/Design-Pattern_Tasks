using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
	public interface observers
	{
		void action(string info);
		void setName(string name);

		string getName();
	}

	public class customer:observers
	{
		private string name;
		public void action(string info)
		{
			Console.WriteLine("Hey {0} {1}", name, info);
		}

		public void setName(string name)
		{
			this.name = name;
		}

		public string getName()
		{
			return this.name;
		}

	} 
}
