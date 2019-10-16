using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities dbContext = new NorthwindEntities();
           var a = dbContext.Customers.ToList();

            var custom = a.Where(f => f.Country == "France");

            foreach(var b in custom)
            {
               // Console.WriteLine(b.ContactName);
            }

            var person = dbContext.Customers.FirstOrDefault(f => f.ContactName == "Maria Anders");
            
            
                

            var l = dbContext.Orders.Where(f => f.CustomerID == person.CustomerID);

            foreach (var c in l)
            {
                Console.WriteLine(c.OrderID+" "+c.ShippedDate);
            }
        }
    }
}
