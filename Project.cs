using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
   /*
    * Project class which has the information about a current project, i.e. the team working on it, the client who asked for it,
    * its name, the budget and all the tasks it consists of.
    */ 
   class Project
   {
	  //default values
	  private const string defaultProjectName = "Unknown Project";
	  private const int defaultBudget = 4200;

	  //variables
	  protected Team devTeam;
	  protected Person client;
	  protected string projectName;
	  protected int budget;
	  protected List<Task> tasks;

	  //properties
	  public Team DevTeam
	  {
		 get { return devTeam; }
		 set { devTeam = value; }
	  }

	  public Person Client
	  {
		 get { return client; }
		 set { client = value; }
	  }

	  public string ProjectName
	  {
		 get { return projectName; }
		 set { projectName = value; }
	  }

	  public int Budget
	  {
		 get { return budget; }
		 set { budget = value; }
	  }

	  public List<Task> Tasks
	  {
		 get { return tasks; }
		 set { tasks = value; }
	  }

	  //constructors
	  public Project()
	  {
		 devTeam = new Team();
		 client = new Person();
		 projectName = defaultProjectName;
		 budget = defaultBudget;
		 tasks = new List<Task>();
	  }

	  public Project(Team newDevTeam, Person newClient, string newProjectName, int newBudget, List<Task> newTasks)
	  {
		 devTeam = newDevTeam;
		 client = newClient;
		 projectName = newProjectName;
		 budget = newBudget;
		 tasks = newTasks;
	  }

	  //methods
	  //total expected time to complete the project
	  public int TotalExpectedTime()
	  {
		 int totalTime = 0;
		 foreach (Task t in tasks)
		 {
			totalTime += t.ExpectedTimeToComplete;
		 }
		 return totalTime;
	  }

	  //return the lengths of the shortest and longest (expected) tasks to complete
	  public void MinMaxTasksLength(ref int minTask, ref int maxTask)
	  {
		 minTask = tasks[0].ExpectedTimeToComplete;
		 maxTask = tasks[0].ExpectedTimeToComplete;

		 foreach (Task t in tasks)
		 {
			if (minTask > t.ExpectedTimeToComplete)
			   minTask = t.ExpectedTimeToComplete;

			if (maxTask < t.ExpectedTimeToComplete)
			   maxTask = t.ExpectedTimeToComplete;
		 }
	  }

	  //add a new task
	  public void AddTask(Task newTask)
	  {
		 tasks.Add(newTask);
	  }

	  //remove a task
	  public void RemoveTask(Task oldTask)
	  {
		 if (tasks.Contains(oldTask))
			tasks.Remove(oldTask);
	  }
   }
}
