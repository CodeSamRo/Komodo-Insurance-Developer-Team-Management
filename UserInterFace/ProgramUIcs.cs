using DeveloperClasses;
using DevTeamMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterFace
{
    public class ProgramUIcs
    {
        DeveloperREPO _devRepo = new DeveloperREPO();
        DevTeamREPO _devTeamREPO = new DevTeamREPO();
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                DashSpacer();
                Console.WriteLine("Welcome! This is the Komodo Team Management console \n" +
                "Here is where you can create and interact with Developers and DevTeams! \n" +
                "Enter the number of the option you would like to select. \n" +
                "------------------------------------------------------------------------------------------------------------------------\n" +
                "1. Developers and options \n" +
                "2. Find Developer by ID \n" +
                "3. Show Teams and Options \n" +
                "4. Exit") ;
                DashSpacer();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all
                        DeveloperOptions();
                        break;
                    case "2":
                        //Find
                        FindDeveloper();
                        break;
                    case "3":
                        //Show Teams and Options
                        TeamOptions();
                        break;
                    case "4":
                        //exit
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 5. " +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        
        //Developer Methods
        private void DeveloperOptions()
        {
            ShowAllDevelopers();
            DashSpacer();
            Console.WriteLine("Above is the current list of Developers in the system.\n" +
                "Below are a list of options to choose from!\n" +
                "------------------------------------------------------------------------------------------------------------------------\n" +
                "1. Add Developer\n" +
                "2. Remove Developer\n" +
                "3. Find Developer\n" +
                "4. List by PuralSight\n" +
                "5. Back");
            DashSpacer();
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //Add
                    AddDeveloper();
                    break;
                case "2":
                    //Remove
                    RemoveDeveloper();
                    break;
                case "3":
                    //Find
                    FindDeveloper();
                    break;
                case "4":
                    FindAllFalsePuralSight();
                    break;
                case "5":
                    RunMenu();
                    break;
                default:
                    ErrorMessage();
                    DeveloperOptions();
                    break;
            }
        }
        //Options
        private void AddDeveloper()
        {
            Console.Clear();
            try
            {
                List<Developer> listOfDevelopers = _devRepo.GetAllContents();
                Developer developer = new Developer();
                Console.WriteLine("Type in the Name of Developer: ");
                developer.DeveloperName = Console.ReadLine();
                Console.WriteLine("Type in ID of Developer: ");
                //developer.DeveloperID = Convert.ToInt32(Console.ReadLine());
                UniqueID(listOfDevelopers, developer);
                //Console.WriteLine("Has Puralsight? Yes or No");
                //HasPuralSight(developer);

            }
            catch
            {
                ErrorMessage();
                AddDeveloper();
            }
        }

        private void RemoveDeveloper()
        {

            Console.Clear();
            Console.WriteLine("Type in ID of Developer: ");
            int result = Convert.ToInt32(Console.ReadLine());
            Developer developer = _devRepo.GetDeveloperByID(result);
            _devRepo.DeleteExistingDeveloper(developer);
        }

        private void FindDeveloper()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("ID of Developer: ");
                int result = Convert.ToInt32(Console.ReadLine());
                Developer developer = _devRepo.GetDeveloperByID(result);
                DisplayDeveloper(developer);
                Console.ReadKey();
            }
            catch
            {
                ErrorMessage();
            }
        }

        private void FindAllFalsePuralSight()
        {
            Console.Clear();
            List<Developer> listOfDevelopers = _devRepo.GetAllContents();
            Console.WriteLine("Needs Puralsight");
            foreach (Developer developerName in listOfDevelopers)
            {
                if (developerName.Puralsight == false)
                {
                    DisplayDeveloper(developerName);
                }
            }
            Console.ReadKey();
        }
        //Helper Methods
        private void ShowAllDevelopers()
        {
            Console.Clear();
            List<Developer> listOfDevelopers = _devRepo.GetAllContents();
            foreach (Developer developerName in listOfDevelopers)
            {
                DisplayDeveloper(developerName);
            }
            
        }

        private void DisplayDeveloper(Developer developer)
        {
            if (developer == null)
            {
                Console.WriteLine("There is no person matching ID, try again.");
            }
            else
            {
                Console.WriteLine("ID: {0}               Name: {1}                              " +
                    "HasPuralsight: {2}", developer.DeveloperID, developer.DeveloperName, developer.Puralsight);
            }
        }

        private void HasPuralSight(Developer developer)
        {
            string respond = Console.ReadLine();
            switch (respond.ToLower())
            {
                case "no":
                    developer.Puralsight = false;
                    _devRepo.AddDeveloperToDirectory(developer);
                    break;
                case "yes":
                    developer.Puralsight = true;
                    _devRepo.AddDeveloperToDirectory(developer);
                    break;
                default:
                    _devRepo.DeleteExistingDeveloper(developer);
                    Console.WriteLine("Please type Yes or No");
                    Console.ReadKey();
                    AddDeveloper();
                    break;
            }
        }

        public void UniqueID(List<Developer> developers, Developer developer)
        {
            bool test = false;
            int ID = Convert.ToInt32(Console.ReadLine());
            try
            {
                foreach (Developer developer1 in developers)
                    
                    if (ID == developer1.DeveloperID)
                    {
                        test = true;
                    }
            }
            catch
            {
                ErrorMessage();
            }
            finally
            {
                if (test == true)
                {
                    Console.WriteLine("ID Already exists.");
                    _devRepo.DeleteExistingDeveloper(developer);
                    Console.ReadKey();
                }
                else
                {
                    developer.DeveloperID = ID;
                    Console.WriteLine("Has Puralsight? Yes or No");
                    HasPuralSight(developer);
                }

            }
                


        }
        
        //DevTeam Methods
        private void TeamOptions()
        {
            Console.Clear();
            ShowAllTeams();
            DashSpacer();
            Console.WriteLine("Above is the current list of Teams.\n" +
               "Below are a list of options to choose from!\n" +
               "------------------------------------------------------------------------------------------------------------------------\n" +
               "1. Create Team\n" +
               "2. Assign Developer to a team\n" +
               "3. Remove Developer from team\n" +
               "4. Back");
            DashSpacer();
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //Create Team
                    CreateTeamPropt();
                    break;
                case "2":
                    //Add
                    AddDeveloperToTeamPropt();
                    break;
                case "3":
                    //Remove
                    RemoveDeveloperFromTeamPropt();
                    break;
                case "4":
                    RunMenu();
                    break;
                default:
                    ErrorMessage();
                    TeamOptions();
                    break;
            }
        }
        //Options
        private void CreateTeamPropt()
        {
            Console.Clear();
            DevTeam devTeam = new DevTeam();
            List<DevTeam> devTeams = _devTeamREPO.ShowAllTeams();
            Console.WriteLine("What would you like the team ID to be.");
            //devTeam.TeamID = Convert.ToInt32(Console.ReadLine());

            UniqueTeamID(devTeams ,devTeam);
            
        }

        private void AddDeveloperToTeamPropt()
        {
            Console.WriteLine("Please type the ID of the team you want to ADD to.");
            FindDevTeam();
            Console.WriteLine("Type the ID's of the developers you want to add to the team.");
            try
            { 
                int result = Convert.ToInt32(Console.ReadLine());
                Developer developer = _devRepo.GetDeveloperByID(result);
                _devTeamREPO.AddDeveloperToTeam(result);
                Console.ReadKey();
            }
            catch
            {
                ErrorMessage();
            }
        }

        private void RemoveDeveloperFromTeamPropt()
        {

        }
        //Helper Methods
        private void FindDevTeam()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("ID of Team: ");
                int result = Convert.ToInt32(Console.ReadLine());
                DevTeam devTeam = _devTeamREPO.GetDevTeamByID(result);
                Console.Clear();
                DisplayDevTeams(devTeam);
                Console.ReadKey();
            }
            catch
            {
                ErrorMessage();
            }
        }

        public void UniqueTeamID(List<DevTeam> listOfDevTeams, DevTeam devTeam)
        {
            bool test = false;
            bool testSecond = false;
            int teamID = 0;
            try
            {
                teamID = Convert.ToInt32(Console.ReadLine());
                foreach (DevTeam devTeam1 in listOfDevTeams)

                    if (teamID == devTeam1.TeamID)
                    {
                        test = true;
                    }
            }
            catch
            {
                testSecond = true;
            }
            finally
            {
                if (testSecond == true)
                {
                    _devTeamREPO.DeleteExistingDevTeam(devTeam);
                    ErrorMessage();
                }
                else
                {
                    if (test == true)
                    {
                        _devTeamREPO.DeleteExistingDevTeam(devTeam);
                        Console.WriteLine("TeamID Already exists.");
                        Console.ReadKey();
                    }
                    else
                    {
                        devTeam.TeamID = teamID;
                        _devTeamREPO.CreateTeam(devTeam);
                    }
                }
            }
        }

        private void ShowAllTeams()
        {
            List<DevTeam> listOfTeams = _devTeamREPO.ShowAllTeams();
            foreach (DevTeam team in listOfTeams)
            {
                DisplayDevTeams(team);
            }

        }

        private void DisplayDevTeams(DevTeam devTeam)
        {
            if (devTeam == null)
            {
                Console.WriteLine("There is no team matching ID, try again.");
            }
            else
            {
                Console.WriteLine("Team ID: {0}           Members: {1} ", devTeam.TeamID, devTeam.TeamMembers);
            }
        }


        //Line Saver Methods
        private void DashSpacer()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" +
                "------------------------------------------------------------------------------------------------------------------------");
        }

        private void ErrorMessage()
        {
            Console.WriteLine("Please enter in a valid input \n" +
                           "Press any key to continue...");
            Console.ReadKey();
        }
    }
}
