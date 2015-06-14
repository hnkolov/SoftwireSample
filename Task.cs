using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
   /*
    * Task class which has the basic information about a task, i.e. name, difficulty and expected time to complete.
    */
   class Task
   {
	  //enum for difficulty levels
	  public enum DifficultyLevel { Easy, Average, Hard }

	  //default values
	  private const int defaultExpectedTimeToComplete = 10;
	  private const string defaultName = "Some task";
	  private const DifficultyLevel defaultDiff = DifficultyLevel.Average;

	  //variables
	  protected string name;
	  protected DifficultyLevel difficulty;
	  protected int expectedTimeToComplete;

	  //properties
	  public string Name
	  {
		 get { return name; }
		 set { name = value; }
	  }

	  public DifficultyLevel Difficulty
	  {
		 get { return difficulty; }
		 set { difficulty = value; }
	  }

	  public int ExpectedTimeToComplete
	  {
		 get { return expectedTimeToComplete; }
		 set { expectedTimeToComplete = value; }
	  }

	  //constructors
	  public Task()
	  {
		 name = defaultName;
		 difficulty = defaultDiff;
		 expectedTimeToComplete = defaultExpectedTimeToComplete;
	  }

	  public Task(string newName, DifficultyLevel newDifficulty, int newTime)
	  {
		 name = newName;
		 difficulty = newDifficulty;
		 expectedTimeToComplete = newTime;
	  }
   }
}
