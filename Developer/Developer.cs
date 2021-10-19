using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperClasses
{
    public class Developer
    {
        //Developer Name
        //Developer ID
        //method to identify one developer without mistake and also whether or not they have access to tool: Pluralsight
        public string DeveloperName { get; set; }
        public int DeveloperID { get; set; }
        public bool Puralsight { get; set; }

        public Developer() { }
        public Developer(string name, int ID, bool puralSight)
        {
            DeveloperName = name;
            DeveloperID = ID;
            Puralsight = puralSight;
        }
       //public override string ToString()
       // {
       //     return "ID: " + DeveloperID + "   Name: " + DeveloperName;
       // }
        //public string GetName()
        //{
        //    return DeveloperName;
        //}

        //public void SetName(string name)
        //{
        //    DeveloperName = name;
        //}
    }

}
