namespace OCPLibrary
{
	public interface IPersonModel
	{
		string FirtName { get; set; }
		string LastName { get; set; }
		EmployeeType TypeOfEmployee { get; set; }
		IAccounts AccountProcessor { get; set; }
	}
}