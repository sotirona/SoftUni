using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CompanyRoster
{
    public class Company
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {

                var input = Console.ReadLine().Split();

                var name = input[0];
                var salary = double.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                var currentEmployee = new Employee(name, salary, position, department);
              
                if (input.Length >=5)
                {
                    int s;
                    var result = int.TryParse(input[4], out s);

                    if (result)
                    {
                        currentEmployee.Age = int.Parse(input[4]);
                    }
                    else
                    {
                        currentEmployee.Email = input[4];
                    }
                }

                if (input.Length == 6)
                {
                    currentEmployee.Age = int.Parse(input[5]);
                }

                employees.Add(currentEmployee);
            }

            var employeesByDeptAvgSalary = employees.GroupBy(x => x.Department).Select(gr => new
            {
                Name = gr.Key,
                AvgSalary = gr.Average(x => x.Salary),
                Employees = gr

            })
            .OrderByDescending(x => x.AvgSalary)
            .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {employeesByDeptAvgSalary.Name}");

            foreach (var empl in employeesByDeptAvgSalary.Employees.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{empl.Name} {empl.Salary:F2} {empl.Email} {empl.Age}");
            }
        }
    }
}
