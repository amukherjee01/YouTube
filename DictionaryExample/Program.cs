using System;
using System.Collections.Generic;
namespace DictionaryExample
{
	class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Salary { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee1 = new Employee()
			{
				Id = 1,
				Name = "Test",
				Salary = 1000
			};

			Employee employee2 = new Employee()
			{
				Id = 2,
				Name = "Test123",
				Salary = 2000
			};

			Employee employee3 = new Employee()
			{
				Id = 3,
				Name = "Test234",
				Salary = 3000
			};

			Dictionary<int, Employee> employeedict = new Dictionary<int, Employee>();

			employeedict.Add(employee1.Id, employee1);
            employeedict.Add(employee2.Id, employee2);
            employeedict.Add(employee3.Id, employee3);

			//if (!employeedict.ContainsKey(employee3.Id))
			//{
			//	employeedict.Add(employee3.Id, employee3);

   //         }
			//else
			//{
			//	Console.WriteLine("Key already exist");
   //         }

			Employee employee;
			
			if (employeedict.TryGetValue(employee1.Id, out employee))
			{
                Console.WriteLine($"id={employee.Id} Name={employee.Name} Salary={employee.Salary}");
            }
			else
			{
				Console.WriteLine("Key already exist");
			}
			//foreach (KeyValuePair<int, Employee> dictkey in employeedict)
			//{
			//	int key = dictkey.Key;
			//	Employee e = dictkey.Value;
			//	Console.WriteLine($"id={e.Id} Name={e.Name} Salary={e.Salary}");
			//}

			

        }

	}
}