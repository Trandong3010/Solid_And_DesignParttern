using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPLibrary;

namespace UI
{
	class Program
	{
		static void Main(string[] args)
		{
			List<IPersonModel> person = new List<IPersonModel>
			{
				new PersonModel {FirtName = "Mai", LastName="Nguyen"},
				new ManagerModel {FirtName = "Hoang", LastName="Trong", TypeOfEmployee = EmployeeType.Manager},
				new ExecutiveModel {FirtName = "Ly", LastName="Mai", TypeOfEmployee = EmployeeType.Executive}
			};

			List<EmployeeModel> employees = new List<EmployeeModel>();
			// Cũ
			//Accounts account = new Accounts();

			// Mới

			foreach (var item in person)
			{
				employees.Add(item.AccountProcessor.Creates(item));
			}

			foreach (var item in employees)
			{
				Console.WriteLine($"{item.FirtName} {item.LastName} : {item.EmailAddress} IsManager: {item.IsManager} IsExecutive: {item.IsExecutive}");
			}

			Console.ReadLine();
		}
	}
}
