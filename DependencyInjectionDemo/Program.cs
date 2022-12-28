namespace DependencyInjectionDemo
{
	class Saving
	{
		public void PrintDetails()
		{
			Console.WriteLine("Saving Account details....");
		}
	}
	class Current
	{
		public void PrintDetails()
		{
			Console.WriteLine("Current Account details...");
		}
	}

	//Account class is dependent on Saving and Current Class.
	//Tight coupling. Impliment DI in order to make it lose coupling.
	class Account
	{
		public void PrintAccountDetails()
		{
			Saving s = new Saving();
			Current c = new Current();
			s.PrintDetails();
			c.PrintDetails();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Account a = new Account();
			a.PrintAccountDetails();
		}
	}
}