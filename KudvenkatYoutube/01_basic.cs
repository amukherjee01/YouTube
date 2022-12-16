using System;

namespace YouTube
{
    class Customer
    {
        string _Name;
        string _Addr;

    
        public Customer(string Name, string Addr) {
            this._Name = Name;
            this._Addr = Addr;
        }

        public Customer() : this("No Name", "No Address")
        {

        }

        public void CustomerInfo() {

            Console.WriteLine("Customer info = {0}", this._Name + " " + this._Addr);
        }
    }
    class MyProgram
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Aditya", "Lucknow");
            Customer c1 = new Customer();
            c.CustomerInfo();
            c1.CustomerInfo();
            /*
            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter your number :");
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 10:
                    case 20:
                        Console.WriteLine("Enter number is 20");
                        break;
                    case 30:
                        Console.WriteLine("Enter number is 30");
                        break;
                    case 40:
                        Console.WriteLine("Enter number is 40");
                        break;
                    default:
                        Console.WriteLine("Default statement");
                        break;

                }
                
                Console.WriteLine("Please enter number : ");
                int? num = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= num)
                {
                    Console.WriteLine(start);
                    start++;
                }

                do
                {
                    Console.WriteLine("Do you want to continue");
                    userChoice = Console.ReadLine();
                    if (userChoice.ToUpper() != "YES" || userChoice.ToUpper() != "NO")
                    {
                        Console.WriteLine("Please input valid choice");
                    }
                } while (userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO");
            } while (userChoice.ToUpper() == "YES");
        }*/

            /*
            //For Loop

            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }

            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }

            //Continue
            for(int i = 1; i<=20; i++)
            {
                if (i == 11)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            //Break
            for (int i = 1; i <=20; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
            */


            //Methods 
            MyProgram myprogram = new MyProgram();
            MyProgram.EvenNumbers();
            int Result = myprogram.Add(10, 20);
            Console.WriteLine("sum = {0}", Result);

            //PassByValue
            int value = 0;
            PassByValue(value);
            Console.WriteLine(value);

            //PassByReference
            int value1 = 0;
            PassByReference(ref value1);
            Console.WriteLine(value1);

            //Out variable
            int Total = 0;
            int Product = 0;
            AddandProduct(10, 20, out Total, out Product);
            Console.WriteLine("sum = {0} and product = {1}", Total, Product);

        }

        //Instance method
        public int Add(int first, int second)
        {
            return first + second;
        }

        //Static Method
        public static void EvenNumbers()
        {
            int start = 0;

            while(start < 11)
            {
                if (start % 2 == 0)
                {
                    Console.WriteLine(start);
                    
                }

                start++;
            }
        }

        public static void PassByValue(int j)
        {
            j = 101;
        }

        public static void PassByReference(ref int j)
        {
            j = 101;
        }

        public static void AddandProduct(int first, int second, out int sum, out int product)
        {
            sum =  first+ second;
            product = first * second;
        }
    }

}