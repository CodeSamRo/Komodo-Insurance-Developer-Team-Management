using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperClasses
{
    public class Developer
    {
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
    }
}
