using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Home_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Method Syntax

            #region Question 4
            //List<int> myIntsList = new List<int> { 1, 5, 6, 4, 2, 3, 1, 6, 5, 8, 9, 10 };
            //List<string> newIntsList = myIntsList.Select(x => x + ",").ToList();

            //newIntsList.ForEach(i => Console.WriteLine(i));
            //Console.WriteLine("\n**********************************************\n");
            #endregion

            #region Question 5

            //List<string> myStringsList = new List<string> { "Asaf", "Shimi", "Dana", "Orel", "Vladik", "Itzhak", "Ortal" };
            //List<string> newStringList = myStringsList.Where(name => name.Length > 4).ToList();

            //newStringList.ForEach(name => Console.WriteLine(name));
            //Console.WriteLine("\n**********************************************\n");
            #endregion

            #region Question 6
            //OrderBy
            //List<int> OrderByIntList = myIntsList.OrderBy(x => x).ToList();
            //OrderByIntList.ForEach(i => Console.WriteLine(i));

            //Console.WriteLine("\n**********************************************\n");

            //List<string> OrderByStringList = myStringsList.OrderBy(x => x.StartsWith("O")).ToList();
            //OrderByStringList.ForEach(i => Console.WriteLine(i));
            //Console.WriteLine("\n**********************************************\n");

            ////OrderByDescending
            //List<int> OrderByDesIntList = myIntsList.OrderByDescending(x => x).ToList();
            //OrderByDesIntList.ForEach(i => Console.WriteLine(i));
            //Console.WriteLine("\n**********************************************\n");

            //List<string> OrderByDesStringList = myStringsList.OrderByDescending(x => x.StartsWith("O")).ToList();
            //OrderByDesStringList.ForEach(i => Console.WriteLine(i));
            //Console.WriteLine("\n**********************************************\n");

            #endregion

            #region Question 7
            //List<int> intList1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> intList2 = new List<int>() { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 5, 6, 7, 8 };

            //Common numbers - Section a
            //var commonNumbersList = intList1.Join(intList2,
            //    num1 => num1,
            //    num2 => num2,
            //    (common, y) => new
            //    {
            //        common
            //    }).ToList();
            //commonNumbersList.ForEach(x => Console.WriteLine(x));

            //Numbers that not in other list - Section b
            //var NumbersNotInList = intList2.Except(intList1).ToList();
            //NumbersNotInList.ForEach(num => Console.WriteLine(num));

            //Unique numbers - Section c
            //var uniqueList = intList2.Distinct().ToList();
            //uniqueList.ForEach(num => Console.WriteLine(num));

            //First element that's bigger then 12 - Section d
            //int firstBigger12 = intList2.FirstOrDefault(num => num > 12);
            //Console.WriteLine(firstBigger12);

            //First element that's bigger then 12 from both list - Section e
            //int firstBiggerThen12 = intList1.Concat(intList2).FirstOrDefault(num => num > 12);
            //Console.WriteLine(firstBiggerThen12);



            #endregion

            #region Question 8
            //Customer c1 = new Customer("Asaf", 1, 10, "Coca-Cola", 10, 550);
            //Customer c2 = new Customer("Dana", 2, 11, "Sprite", 20, 1000);
            //Customer c3 = new Customer("Shimi", 3, 12, "Fanta", 10, 350);
            //Customer c4 = new Customer("Ron", 4, 10, "Pepsi", 5, 500);
            //List<Customer> cu_List = new List<Customer>() { c1, c2, c3, c4 };


            //SalesAgent s1 = new SalesAgent("Tom", "Netanya", 10);
            //SalesAgent s2 = new SalesAgent("Dor", "Tel-Aviv", 11);
            //SalesAgent s3 = new SalesAgent("Alon", "Netanya", 15);
            //List<SalesAgent> agent_List = new List<SalesAgent>() { s1, s2, s3 };

            //var agent_Customer_List = agent_List.Join(cu_List,
            //    agent => agent.AgentID,
            //    customer => customer.AgentID,
            //    (agent, customer) => new
            //    {
            //        cu_Name = customer.Name,
            //        cu_Order = customer.Order,
            //        cu_Quantity = customer.Quantity,
            //        Total = customer.OrderPrice,
            //        agent_Name = agent.Name,
            //        agent_City = agent.City,
            //    }).ToList();

            //agent_Customer_List.ForEach(action => Console.WriteLine(action));

            #endregion

            #region Question 9 & Challange
            //Copied from question 8 
            //Customer c1 = new Customer("Asaf", 1, 10, "Coca-Cola", 10, 550);
            //Customer c2 = new Customer("Dana", 2, 11, "Sprite", 20, 1000);
            //Customer c3 = new Customer("Shimi", 3, 12, "Fanta", 10, 450);
            //Customer c4 = new Customer("Ron", 4, 10, "Pepsi", 5, 200);
            //List<Customer> cu_List = new List<Customer>() { c1, c2, c3, c4 };


            //SalesAgent s1 = new SalesAgent("Tom", "Netanya", 10);
            //SalesAgent s2 = new SalesAgent("Dor", "Tel-Aviv", 11);
            //SalesAgent s3 = new SalesAgent("Alon", "Netanya", 15);
            //List<SalesAgent> agent_List = new List<SalesAgent>() { s1, s2, s3 };

            //var customer_Agent_GroupJoin = agent_List.GroupJoin(cu_List,
            //    agent => agent.AgentID,
            //    cu => cu.AgentID,
            //    (agent, cu) => new
            //    {
            //        customer = cu,
            //        agent_Name = agent.Name,
            //        agent_ID = agent.AgentID,
            //    });

            //foreach (var item in customer_Agent_GroupJoin)
            //{
            //    Console.WriteLine("Agent: " + item.agent_Name);

            //    foreach (var cu in item.customer)
            //    {
            //        Console.WriteLine($"Customer Name: {cu.Name} \n" +
            //            $"Customer Order: {cu.Order} \n" +
            //            $"Order Quantity: {cu.Quantity} \n");
            //    }
            //}


            //CHALLANGE, Got data from Question 8
            //foreach (var obj in agent_Customer_List)
            //{
            //    if (obj.Total >= 500)
            //    {
            //        Console.WriteLine($"Name: {obj.cu_Name} \n" +
            //            $"Order: {obj.cu_Order} \n" +
            //            $"Quantity: { obj.cu_Quantity} \n" +
            //            $"Total: { obj.Total} \n" +
            //            $"Agent: {obj.agent_Name} \n");
            //    }








            #endregion

            #endregion

            #region Query Syntax

            #region Question 4
            //List<int> myIntsList = new List<int> { 1, 5, 6, 4, 2, 3, 1, 6, 5, 8, 9, 10 };
            //var newIntList = from num in myIntsList
            //                 select num + ",";

            #endregion

            #region Question 5
            //List<string> myStringsList = new List<string> { "Asaf", "Shimi", "Dana", "Orel", "Vladik", "Itzhak", "Ortal" };
            //var newStringsList = from str in myStringsList
            //                     where str.Length > 4
            //                     select str;
            //foreach (string str in newStringsList)
            //{
            //    Console.WriteLine(str);
            //}


            #endregion

            #region Question 6
            //var orderByIntList = (from num in myIntsList
            //                      orderby num descending
            //                      select num).ToList();
            //orderByIntList.ForEach(num => Console.WriteLine(num));


            //var orderByStringList = (from str in myStringsList
            //                         orderby str ascending where str.StartsWith("O")
            //                         select str).ToList();
            //orderByStringList.ForEach(str => Console.WriteLine(str));


            #endregion

            #region Question 7
            //Doesn't have a supported func to this question
            #endregion

            #region Question 8
            //Copied from Method Syntax Question 8
            //Customer c1 = new Customer("Asaf", 1, 10, "Coca-Cola", 10, 550);
            //Customer c2 = new Customer("Dana", 2, 11, "Sprite", 20, 1000);
            //Customer c3 = new Customer("Shimi", 3, 12, "Fanta", 10, 350);
            //Customer c4 = new Customer("Ron", 4, 10, "Pepsi", 5, 500);
            //List<Customer> cu_List = new List<Customer>() { c1, c2, c3, c4 };


            //SalesAgent s1 = new SalesAgent("Tom", "Netanya", 10);
            //SalesAgent s2 = new SalesAgent("Dor", "Tel-Aviv", 11);
            //SalesAgent s3 = new SalesAgent("Alon", "Netanya", 15);
            //List<SalesAgent> agent_List = new List<SalesAgent>() { s1, s2, s3 };

            //var customer_Agent_List = (from cu in cu_List
            //                          join agent in agent_List
            //                          on cu.AgentID equals agent.AgentID
            //                          select new
            //                          {
            //                              Customer_Name = cu.Name,
            //                              Agent_Name = agent.Name
            //                          }).ToList();
            //customer_Agent_List.ForEach(x => Console.WriteLine(x));

            #endregion

            #region Question 9
            //Doesn't have a supported func to this question



            #endregion

            #endregion


        }

    }
}
