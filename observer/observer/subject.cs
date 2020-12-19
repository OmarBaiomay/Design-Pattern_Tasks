using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
	public interface subject
	{
		void addCustomer(observers observer);
		void removeCustomer(observers observer);
		void notifyCustomers();

	}

	public class product : subject
	{
		private string info;
		private List<observers> customerList;

		public void setInfo(string info)
		{
			this.info = info;
			notifyCustomers();
		}

		public product()
		{
			customerList = new List<observers>();
		}

		public void addCustomer(observers observer)
		{
			customerList.Add(observer);
		}
		public void removeCustomer(observers observer)
		{
			customerList.Remove(observer);
		}

		public void notifyCustomers()
		{
			foreach (observers observer in customerList)
			{
				observer.action(info);
			}
		}
	}
}
