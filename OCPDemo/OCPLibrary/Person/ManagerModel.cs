using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
	public class ManagerModel : IPersonModel
	{
		public string FirtName { get; set; }
		public string LastName { get; set; }
		public EmployeeType TypeOfEmployee { get; set; }
		public IAccounts AccountProcessor { get; set; } = new ManagerAccount();
	}
}
