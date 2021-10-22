using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperClasses
{
    public class DeveloperREPO
    {
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

        public Developer GetContentByDeveloper(string name)
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
            Developer oldDeveloper = GetContentByDeveloper(originalDeveloper);
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


    }
}
