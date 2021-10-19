using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperClasses
{
    public class DeveloperREPO
    {
        //CRUD
        //method to identify one developer without mistake and also whether or not they have access to tool: Pluralsight
        //Add member to team by unique identifier
        //Delete member from team by unique identifier
        //_DevRepo.Add(new Developer(Console.ReadLine(),Convert.ToInt32(Console.ReadLine()), false));

        List<Developer> _DevRepo = new List<Developer>();
        
       
        
        public Developer GetDeveloperByID(int ID)
        {
            foreach(Developer developer in _DevRepo)
            {
                if(ID == developer.DeveloperID)
                {
                    return developer;
                }
            }
            return null;
        }
      
        public void AddDeveloperToDirectory(Developer developer)
        {
            _DevRepo.Add(developer);
            
        }

        public List<Developer> GetAllContents()
        {
            return _DevRepo;
        }

        public Developer GetContentByName(string name)
        {
            foreach (Developer developer in _DevRepo)
            {
                if (developer.DeveloperName.ToLower() == name.ToLower())
                {
                    return developer;
                }
            }
            return null;
        }

        public bool UpdateExistingContent(string originalDeveloper, Developer newDeveloper)
        {
            Developer oldDeveloper = GetContentByName(originalDeveloper);
            if (oldDeveloper != null)
            {
                oldDeveloper.DeveloperName = newDeveloper.DeveloperName;
                oldDeveloper.DeveloperID = newDeveloper.DeveloperID;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteExistingDeveloper(Developer existingDeveloper)
        {

            _DevRepo.Remove(existingDeveloper);
        }
        public void HasPuralSight(Developer developer)
        {
            string respond = Console.ReadLine();
            switch (respond.ToLower())
            {
                case "no":
                    developer.Puralsight = false;
                    break;
                case "yes":
                    developer.Puralsight = true;
                    break;
                default:
                    Console.WriteLine("Please type Yes or No");
                    Console.ReadKey();
                    break;
            }
        }
        //public string ShowList()
        //{

        //    return _DevRepo.ToString;
        //}


    }
}
