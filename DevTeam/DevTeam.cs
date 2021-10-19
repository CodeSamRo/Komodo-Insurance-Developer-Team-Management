using DeveloperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam
{
    public class DevTeam
    {
        //Teams need their team MEMBERS and team NAME along with team ID
        public string TeamName { get; set; }
        public List<Developer> TeamMembers{ get; set; }
        public DevTeam() { }
        public DevTeam(string teamName, List<Developer> teamMembers)
        {
            TeamName = teamName;
            TeamMembers = teamMembers;
        }
    }
}
