using System;
using System.Runtime.CompilerServices;

namespace AccessModifiers
{
    public class Customer
    {
        private int _Id;
        protected string FirstName;

        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

    }

    public class ChildCustomer : Customer
    {
        public void PrintNameDetail()
        {
            ChildCustomer cc = new ChildCustomer();
            cc.FirstName = "aditya";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Id = 101;
            Console.WriteLine(c1.Id);
            
        }
    }
}