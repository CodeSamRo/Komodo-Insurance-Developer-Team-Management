using DeveloperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamMethods
{
    public class DevTeam
    {
        //Teams need their team MEMBERS and team NAME along with team ID
        public int TeamID { get; set; }
        public List<Developer> TeamMembers{ get; set; }
        public DevTeam() { }
        public DevTeam(int teamID, List<Developer> teamMembers)
        {
            TeamID = teamID;
            TeamMembers = teamMembers;
        }
    }
}
