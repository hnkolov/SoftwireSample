using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sample
{
   /*
    * Employee class which inherits from Person and has additional information such as
    * position in the company and salary.
    */
   public class Employee : Person
   {
	  //enum for roles
	  public enum Roles { Developer, Tester }

	  //default values
	  private const int defaultSalary = 20000;
	  private const Roles defaultPosition = Roles.Developer;

	  //variables
	  protected int salary;
	  protected Roles position;

	  //properties
	  public int Salary
	  {
		 get { return salary; }
		 set { salary = value; }
	  }

	  public Roles Position
	  {
		 get { return position; }
		 set { position = value; }
	  }

	  //constructors
	  public Employee()
		 : base()
	  {
		 salary = defaultSalary;
		 position = defaultPosition;
	  }

	  public Employee(int newAge, string newName, int newSalary, Roles newPosition)
		 : base(newAge, newName)
	  {
		 salary = newSalary;
		 position = newPosition;
	  }

	  //enable comparisons of employees' salaries

	  public static int Comparison(Employee employeeOne, Employee employeeTwo)
	  {
		 if (employeeOne.salary > employeeTwo.salary)
			return 1;
		 else if (employeeOne.salary == employeeTwo.salary)
			return 0;
		 else
			return -1;
	  }

	  public static bool operator > (Employee lhs, Employee rhs)
	  {
		 return Comparison(lhs, rhs) == 1;
	  }

	  public static bool operator < (Employee lhs, Employee rhs)
	  {
		 return Comparison(lhs, rhs) == -1;
	  }

	  public static bool operator >= (Employee lhs, Employee rhs)
	  {
		 return Comparison(lhs, rhs) != -1;
	  }

	  public static bool operator <= (Employee lhs, Employee rhs)
	  {
		 return Comparison(lhs, rhs) != 1;
	  }

	  public static bool operator == (Employee lhs, Employee rhs)
	  {
		 return Comparison(lhs, rhs) == 0;
	  }

	  public static bool operator != (Employee lhs, Employee rhs)
	  {
		 return !(lhs == rhs);
	  }

	  public override bool Equals(object obj)
	  {
		 if (!(obj is Employee))
			return false;
		 return this == (Employee)obj;
	  }
   }
}