using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind
{
    public class Worker : Human
    {
        private decimal salary;
        private decimal workHours;

        public Worker(string firstName, string lastName, decimal salary, decimal workHours)
           : base(firstName, lastName)
        {
            this.Salary = salary;
            this.WorkHours = workHours;
        }
        
        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value<=10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }

        public decimal WorkHours
        {
            get { return this.workHours; }
            set
            {

                if (value<1 || value>12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHours = value;
            }
        }

       
        public override string ToString()
        {
            return $"First Name: {this.FirstName}\r\nLast Name: {this.LastName}\r\nWeek Salary: {this.Salary:F2}\r\nHours per day: {this.WorkHours:F2}\r\nSalary per hour: {this.Salary / (this.WorkHours * 5):F2}";
        }
    }
}
