namespace AbstractClassExample
{
   public abstract class A
   {
        public abstract void Print();

        public void PrintDetails(){
            System.Console.WriteLine("hello how are you");
        }
   }

   class B : A 
   {
        public override void Print()
        {
            System.Console.WriteLine("Implimented abstract method print");
        }
   }
    class Program
    {
        static void Main(string[] args)
        {
            B child = new B();
            child.Print();

            A refvaribale = new B();
            refvaribale.Print();
            refvaribale.PrintDetails();
        }
    }
    
}