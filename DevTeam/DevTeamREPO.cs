using DeveloperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamMethods
{
    public class DevTeamREPO
    {
        //Create a team
        //Add member to team by unique identifier
        //Delete member from team by unique identifier

        List<DevTeam> _devTeamREPO = new List<DevTeam>();
        DevTeam DevTeam = new DevTeam();
        DeveloperREPO DeveloperREPO = new DeveloperREPO();
        public void CreateTeam(DevTeam ID)
        {
            //Create a team thats within the _devTeamREPO list
            _devTeamREPO.Add(ID);
            
            //initalize a new list when a _devTeamREPO is created
            //Add developers to new list
        }

        public void AddDeveloperToTeam(int ID)
        {
            List<Developer> listOfDevelopers = DeveloperREPO.GetAllContents();
            foreach (Developer developer in listOfDevelopers)
            {
                if (developer.DeveloperID == ID)
                {
                    DevTeam.TeamMembers = listOfDevelopers;
                }
            }
            DevTeam.TeamMembers = new List<Developer>();
        }
        public List<DevTeam> ShowAllTeams()
        {
            return _devTeamREPO;
        }
        public void DeleteExistingDevTeam(DevTeam existingDevTeam)
        {

            _devTeamREPO.Remove(existingDevTeam);
        }
        public DevTeam GetDevTeamByID(int ID)
        {
            foreach (DevTeam devTeam in _devTeamREPO)
            {
                if (ID == devTeam.TeamID)
                {
                    return devTeam;
                }
            }
            return null;
        }


    }
}
