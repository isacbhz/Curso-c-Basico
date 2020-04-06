using System;
using System.Globalization;
using System.Collections.Generic;

namespace Employers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("==== Employers Record ====");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            
            Console.Write("How many employees will be registered? ");
            int nEmp = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < nEmp; i++)
            {
                Console.WriteLine("Employee #"+(i+1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that have salary increase: ");
            int idSearch = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == idSearch);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percetage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percetage);
            }
            else
            {
                Console.WriteLine("This id does not exist");
                Console.WriteLine();
            }
            
            Console.WriteLine("Update list of Employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }            
            Console.ReadLine();
        }
    }
}
