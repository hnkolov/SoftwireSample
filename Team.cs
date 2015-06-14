using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
   /*
    * Team class which stores the leader and members of a team.
    */
   class Team
   {
	  //variables
	  protected Employee leader;
	  protected List<Employee> members;

	  //properties
	  public Employee Leader
	  {
		 get { return leader; }
		 set { leader = value; }
	  }

	  public List<Employee> Members
	  {
		 get { return members; }
		 set { members = value; }
	  }

	  //constructors
	  public Team()
	  {
		 leader = new Employee();
		 members = new List<Employee>();
	  }
	  public Team(Employee newLeader)
	  {
		 leader = newLeader;
		 members = new List<Employee>();
	  }

	  public Team(Employee newLeader, List<Employee> newMembers)
	  {
		 leader = newLeader;
		 members = newMembers;
	  }

	  //methods
	  //team member that has the highest salary
	  public Employee BestPaidEmployee()
	  {
		 Employee bestPaid = leader;

		 foreach (Employee emp in members)
		 {
			//comparisons use the salary
			if (emp > bestPaid)
			   bestPaid = emp;
		 }

		 return bestPaid;
	  }

	  //add a member
	  public void AddMember(Employee newMember)
	  {
		 members.Add(newMember);
	  }

	  //remove a member
	  public void RemoveMember(Employee oldMember)
	  {
		 if (members.Contains(oldMember))
			members.Remove(oldMember);
	  }
   }
}
