using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sample
{
   /*
    * Person class which contains the basic information of a single person, i.e. age and name.
    */
   public class Person
   {
	  //default values
	  private const int defaultAge = 18;
	  private const string defaultName = "J Doe";
	  private const int currentYear = 2015;

	  //variables
	  protected int age;
	  protected string name;

	  //properties
	  public int Age
	  {
		 get { return age; }
		 set { age = value; }
	  }

	  public string Name
	  {
		 get { return name; }
		 set { name = value; }
	  }

	  //constructors
	  public Person()
	  {
		 age = defaultAge;
		 name = defaultName;
	  }

	  public Person(int newAge, string newName)
	  {
		 age = newAge;
		 name = newName;
	  }

	  //methods
	  //basic information about the person in string format
	  public string BasicInfo()
	  {
		 return "Name: " + name + " Age: " + age;
	  }

	  //year of birth
	  public int YearOfBirth()
	  {
		 return currentYear - age;
	  }
   }

}
