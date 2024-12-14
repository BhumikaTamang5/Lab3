using System;
using System.Collections.Generic;
using System.Linq;

namespace Bhumika.Unit_3
{
    class Employe
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    internal class EmployeeDemo
    {
       /* static void Main(string[] args)
        {
            List<Employe> employeeList = new List<Employe>()
            {
                new Employe { Name = "John", Address = "Kathmandu", Salary = 70000 },
                new Employe { Name = "Akash", Address = "Jhapa", Salary = 20000 },
                new Employe { Name = "Preksha", Address = "Kathmandu", Salary = 30000 },
                new Employe { Name = "Srihan", Address = "Morang", Salary = 150000 },
                new Employe { Name = "Roshma", Address = "Kathmandu", Salary = 100000 }
            };
            List<Employe> filteredEmployees = employeeList
                .Where(employe => employe.Salary > 50000 && employe.Address == "Kathmandu")
                .OrderBy(employe => employe.Name)
                .ToList();

            foreach (Employe emp in filteredEmployees)
            {
                Console.WriteLine("Name: {0}, Salary: {1}, Address: {2}", emp.Name, emp.Salary, emp.Address);
            }

            Console.ReadKey();
        }*/
    }
}
