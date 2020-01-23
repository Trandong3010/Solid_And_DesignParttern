using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary.Person
{
	class TechnicianModel : IPersonModel
	{
		public string FirtName { get; set; }
		public string LastName { get; set; }
		public EmployeeType TypeOfEmployee { get; set; }
		public IAccounts AccountProcessor { get; set; }
	}
}
