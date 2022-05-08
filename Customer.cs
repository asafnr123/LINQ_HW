using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Home_Work
{
    internal class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AgentID { get; set; }   
        public string Order { get; set; }
        public int Quantity { get; set; }
        public double OrderPrice { get; set; }


        public Customer(string name, int id, int agentID, string order, int quantity, double orderPrice)
        {
            ID = id;
            Name = name;
            AgentID = agentID;
            Order = order;
            Quantity = quantity;
            OrderPrice = orderPrice;
        }
    }
}
