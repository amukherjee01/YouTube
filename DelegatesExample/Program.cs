namespace DelegatesExample
{
    public delegate void HelloDelegate(string message);
    public delegate int SumDelegate(int a, int b);
    public delegate bool IsPromoted(Employee emp);
    public delegate void MyDelegate();
    public delegate List<int> EvenNumberDelegate(List<int> numbers);

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int  Experience { get; set; }
        public static void EmployeePromoted(List<Employee> employees,IsPromoted isPromoted)
        {
            foreach(Employee emp in employees)
            {
                //Hard coded logic .This class cannot be used to promote employee based on salary
                //if (emp.Experience >=5)
                //{
                //    Console.WriteLine(emp.Name + " has been promoted");
                //}
                if (isPromoted.Invoke(emp))
                {
                    Console.WriteLine(emp.Name + " has been promoted");
                }
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate del = new HelloDelegate(Hello);
            del.Invoke("From delegate");

            //Anonymos function
            SumDelegate delsum = delegate (int a, int b) 
            {
                return a + b;
            };

            int result = delsum.Invoke(10, 20);
            Console.WriteLine(result);

            List<Employee> employeelist = new List<Employee>();
            employeelist.Add(new Employee() { Id = 101, Name = "Aditya", Experience = 5, Salary= 30000 });
            employeelist.Add(new Employee() { Id = 101, Name = "Gagan", Experience = 2, Salary = 10000 });
            employeelist.Add(new Employee() { Id = 101, Name = "Mukesh", Experience = 3, Salary = 20000 });
            employeelist.Add(new Employee() { Id = 101, Name = "Rakesh", Experience = 6, Salary = 50000 });

            //Program p = new Program();
            //IsPromoted isPromoted = new IsPromoted(p.IsEmployeePromoted);

            //Employee.EmployeePromoted(employeelist, isPromoted);
            //Employee.EmployeePromoted(employeelist, delegate (Employee emp)
            //{
            //    return emp.Experience >= 5;
            //});
            Employee.EmployeePromoted(employeelist, emp => emp.Experience >= 5);

            MyDelegate obj = () =>
            {
                Console.WriteLine("hello world");
            };

            obj.Invoke();


            EvenNumberDelegate evenobj = (num) => {
                List<int>newList = new List<int>(); 
                foreach (int i in num)
                {
                    if (i % 2 == 0)
                    {
                        newList.Add(i);
                    }
                }

                return newList;
            };

            List<int> numlist = evenobj.Invoke(new List<int> { 10, 12, 13, 44, 53, 21, 22, 43, 90 });

            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }
        }

        public static void Hello(string tcmessage)
        {
            Console.WriteLine(tcmessage);
        }

        //public bool IsEmployeePromoted(Employee emp)
        //{
        //    if (emp.Experience >=5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static int Sum(int a, int b) {
        //    return a + b;
        //}
    }

}