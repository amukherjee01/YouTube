namespace InterFaceExample
{
    interface ICustomer1
    {
        //Public by default
        void PrintCustomer();
    }

    interface ICustomer2 : ICustomer1
    {
        void I2Method();
    }

    class Customer : ICustomer2
    {
        public void I2Method()
        {
            Console.WriteLine("Implimented I2 method");
        }

        public void PrintCustomer()
        {
            System.Console.WriteLine("Customer details");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {   
            Customer c = new Customer();
            c.PrintCustomer();
            c.I2Method();

            ICustomer2 I2 = new Customer();
            I2.I2Method();
        }
    }
    
}