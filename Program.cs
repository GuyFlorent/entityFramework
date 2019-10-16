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
            int i = 1;
            foreach (var c in l)
            {
                //Console.WriteLine(i + " "+c.OrderID+" "+c.ShippedDate);

                i++;
            }

            var listeOrders = dbContext.Customers.FirstOrDefault(f => f.ContactName == "Maria Anders").Orders.ToList();
            int j = 1;
            foreach (var d in listeOrders)
            {
                Console.WriteLine(j + " " + d.OrderID + " " + d.ShippedDate);

                j++;
            }

            /*Ajout d'une colonne dans customers grace au click droit dans sqlServer 
             puis creation et ensuite actualisé sur mon IDE dur le fichier .edmx 
             de entity et apres METTRE A JOUR LE MODELE puis sur terminer et la colonne est ajouter */

            var nouv = dbContext.Customers.Where(f => f.Email != null);

            int m = 1;
            foreach (var o in nouv)
            {
                Console.WriteLine(m + " "+o.ContactName);

                m++;
            }
        }
    }
}
