using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
		//properties
		public int EmployeeId { get;  }
		public string FirstName { get; }
		public string LastName { get; set; }
		public string FullName
		{
			get
			{
				return $"{LastName}, {FirstName}";
			}
		}
		public string Department { get; set; }
		public double AnnualSalary { get; private set; }


		//constructors
		public Employee(int employeeId, string firstName, string lastName, double salary)
		{
			EmployeeId = employeeId;
			FirstName = firstName;
			LastName = lastName;
			AnnualSalary = salary;
		}


		//methods
		public void RaiseSalary(double percent)
		{
			double raise = 0.0;
			raise = AnnualSalary * (percent / 100);
			AnnualSalary += raise;
		}      
    }
}
