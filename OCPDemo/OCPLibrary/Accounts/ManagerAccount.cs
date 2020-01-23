using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
	class ManagerAccount : IAccounts
	{
		public EmployeeModel Creates(IPersonModel person)
		{
			EmployeeModel old = new EmployeeModel();

			old.FirtName = person.FirtName;
			old.LastName = person.LastName;
			old.EmailAddress = $"{person.FirtName.Substring(0, 1)}{person.LastName}@gmail.com";

			//if(person.TypeOfEmployee == EmployeeType.Manager)
			//{
			//	old.IsManager = true;
			//}

			switch (person.TypeOfEmployee)
			{
				case EmployeeType.Staff:
					break;
				case EmployeeType.Manager:
					old.IsManager = true;
					break;
				case EmployeeType.Executive:
					old.IsManager = true;
					old.IsExecutive = true;
					break;
				default:
					break;
			}

			return old;
		}
	}
}
