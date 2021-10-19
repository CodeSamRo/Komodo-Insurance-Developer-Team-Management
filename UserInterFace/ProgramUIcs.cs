using DeveloperClasses;
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
                "2. Find Developer content by Name, and ID \n" +
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
                "4. Exit");
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
                    RunMenu();
                    break;
                default:
                    Console.WriteLine("Please enter in a valid number between 1 and 3. " +
                           "Press any key to continue...");
                    Console.ReadKey();
                    DeveloperOptions();
                    break;
            }
        }
        private void ShowAllDevelopers()
        {
            Console.Clear();
            List<Developer> listOfDevelopers = _devRepo.GetAllContents();
            
            foreach (Developer developer in listOfDevelopers)
            {
                    DisplayDeveloper(developer);   
            }
            
        }
        private void DisplayDeveloper(Developer developer)
        {
            Console.WriteLine("ID: {0}   Name: {1}   HasPuralsight: {2}", developer.DeveloperID, developer.DeveloperName, developer.Puralsight);
        }
        //Add member to team by unique identifier
        private void AddDeveloper()
        {
            Console.Clear();
            Developer developer = new Developer();
            Console.WriteLine("Type in the Name of Developer: ");
            developer.DeveloperName = Console.ReadLine();
            Console.WriteLine("Type in ID of Developer: ");
            developer.DeveloperID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Has Puralsight? Yes or No");
            _devRepo.HasPuralSight(developer);
            _devRepo.AddDeveloperToDirectory(developer);
        } 

        private void RemoveDeveloper()
        {

            Console.Clear();
            Console.WriteLine("Type in ID of Developer: ");
            int result = Convert.ToInt32(Console.ReadLine());
            Developer developer = _devRepo.GetDeveloperByID(result);
           _devRepo.DeleteExistingDeveloper(developer);
       }
        //private void FindDeveloper()
        //{
            
        //    Console.Clear();
        //    Console.WriteLine("What is the name?");
        //    string nameResult = Console.ReadLine();
        //    if (DeveloperREPO.Equals(nameResult, content.DeveloperName))
        //    {
        //        DisplayContent(content);
        //    }
            
            
        //    Console.WriteLine("What is the ID");
        //    string idResult = Console.ReadLine();
        //    if (DeveloperREPO.Equals(idResult, content.DeveloperID))
        //    {
        //        DisplayContent(content);
        //    } 
        //    Console.ReadKey();
        //}
        private void FindDeveloper()
        {
            Console.Clear();
            Console.WriteLine("ID of Developer: ");
            int result = Convert.ToInt32(Console.ReadLine());
            Developer developer = _devRepo.GetDeveloperByID(result);
            DisplayDeveloper(developer);
            Console.ReadKey();
        }
        private void ShowAllTeams()
        {

        }
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
                    Console.WriteLine("Please enter in a valid number between 1 and 3. " +
                           "Press any key to continue...");
                    Console.ReadKey();
                    TeamOptions();
                    break;
            }
        }
        private void CreateTeamPropt()
        {

        }
        private void AddDeveloperToTeamPropt()
        {

        }
        private void RemoveDeveloperFromTeamPropt()
        {

        }
        private void DashSpacer()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" +
                "------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
