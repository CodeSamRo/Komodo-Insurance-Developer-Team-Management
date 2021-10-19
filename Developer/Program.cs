using Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //POCO
            //Developer Name
            //Developer ID
            //whether or not they have access to tool: Pluralsight
            //Teams need their team MEMBERS and team NAME along with team ID
            //CRUD
            //method to identify one developer without mistake
            //Add member to team by unique identifier
            //Delete member from team by unique identifier
            //See list of existing developers to choose from and add to existing teams
            //Manager will create a team, and then add developers individually from the developer dictory to that team
            Developer.DeveloperREPO ui = new Developer.DeveloperREPO();
            ui.Add();
            Console.ReadKey();
        }
    }
}
