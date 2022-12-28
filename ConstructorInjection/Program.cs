namespace ConstructorInjection
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
        private IAccount account;
        public Account(IAccount account)
        {
            this.account = account;
        }

        public void PrintAccountDetails()
        {
            account.PrintDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAccount sa = new Saving();
            Account a = new Account(sa);
            a.PrintAccountDetails();

            IAccount ca = new Current();
            Account a1 = new Account(ca);
            a1.PrintAccountDetails();
        }
    }
}