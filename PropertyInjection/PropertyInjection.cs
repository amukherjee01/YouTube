namespace PropertyInjection
{
    interface IAccount
    {
        void PrintDetails();
    }
    class Saving : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Saving Account Details...");
        }
    }
    class Current : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Current Account Details...");
        }
    }

    class Account
    {
        public IAccount account { get; set; }

        public void PrintAccountDetails()
        {
            account.PrintDetails();
        }
    }
    class PropertyInjection
	{
		static void Main(string[] args)
		{
            Account sa = new Account();
            sa.account = new Saving();
            sa.PrintAccountDetails();

            Account ca = new Account() { account = new Current() };
            ca.PrintAccountDetails();
            Console.WriteLine("hello world");
           
        }
	}
}