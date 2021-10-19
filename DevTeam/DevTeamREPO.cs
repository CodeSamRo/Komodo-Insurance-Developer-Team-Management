using DeveloperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam
{
    class DevTeamREPO
    {
        List<DevTeam> _devTeamREPO = new List<DevTeam>();

        public void CreateTeam(DevTeam teamName)
        {

            _devTeamREPO.Add(teamName);
            
        }
        public void AddDeveloperToTeam(int ID)
        {
            DeveloperREPO developerREPO = new DeveloperREPO();
            developerREPO.GetDeveloperByID(ID);
            

        }

    }
}
