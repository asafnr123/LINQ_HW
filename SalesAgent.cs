using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Home_Work
{
    internal class SalesAgent
    {
        public string Name { get; set; }
        public string City  { get; set; }
        public int AgentID { get; set; }



        public SalesAgent(string name, string city, int id)
        {
            Name = name;
            City = city;
            AgentID = id;
        }
    }


    
}
