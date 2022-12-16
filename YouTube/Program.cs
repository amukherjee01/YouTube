using System;
namespace YouTube
{
   class  YouTube
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            YouTube youTube= new YouTube();
            youTube.Print();
            //youTube.InputFromUser();
            youTube.ValueTypes();
            int sq = youTube.SquareOfNumber(4);
            Console.WriteLine($"Square of number {sq}");
            youTube.ReferenceType();
            int x = 10;
            youTube.PassByValue(ref x);
            Console.WriteLine(x);
            
        }

       public  void Print()
        {
            Console.WriteLine("hello buddy");
            Console.WriteLine(23);
        }

       void InputFromUser()
        {
            Console.WriteLine("Enter number: ");
            var x = Console.ReadLine();    
            Console.WriteLine($"Entered number is {x}");
        }

        void DataTypes()
        {
            int a = 5;
            int b = -6;
            uint c = 100;
            long d = 1000000000000000;
            char e = '!';
            float f = 10.8944f;
            double g = 10.78;
            decimal h = 19.3M;
            string i = "string";
            bool j = true;
            string name = null;
            int? num = null;
        }

        void ValueTypes()
        {
            int a = -10;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            b = 100;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        void ReferenceType()
        {
            int[] a = { -5 };
            int[] b = a;
            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);

            b[0] = 100;

            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);

        }

        int SquareOfNumber(int number)
        {
            return (number * number);
        }

        void SwapNumber(int a, int b)
        {
            Console.WriteLine($"Before swapping a = {a} and b = {b}");
            int temp;
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine($"After swapping a = {a} and b = {b}");
        }

        void PassByValue(ref int value)
        {
            value = 101;
        }

    }

    
}