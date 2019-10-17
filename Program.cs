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

            /*var custom = a.Where(f => f.Country == "France");

            foreach(var b in custom)
            {
               // Console.WriteLine(b.ContactName);
            }

            var person = dbContext.Customers.FirstOrDefault(f => f.ContactName == "Maria Anders");
            
            
                

            var l = dbContext.Orders.Where(f => f.CustomerID == person.CustomerID);
            int i = 1;
           // foreach (var c in l)
            {
                //Console.WriteLine(i + " "+c.OrderID+" "+c.ShippedDate);

                i++;
            }

            var listeOrders = dbContext.Customers.FirstOrDefault(f => f.ContactName == "Maria Anders").Orders.ToList();
            int j = 1;
            //foreach (var d in listeOrders)
            {
               // Console.WriteLine(j + " " + d.OrderID + " " + d.ShippedDate);

                j++;
            }

            /*Ajout d'une colonne dans customers grace au click droit dans sqlServer 
             puis creation et ensuite actualisé sur mon IDE dur le fichier .edmx 
             de entity et apres METTRE A JOUR LE MODELE puis sur terminer et la colonne est ajouter */

            /* var nouv = dbContext.Customers.Where(f => f.Email != null);

             int m = 1;
             foreach (var o in nouv)
             {
                 //Console.WriteLine(m + " "+o.ContactName);

                 m++;
             }

             //Assigner un email au Customer HILAA

             var Updat = dbContext.Customers.FirstOrDefault(f => f.CustomerID == "HILAA");
             //Updat.Email = "GUY@Yaoo.de";
            // dbContext.SaveChanges();

             //Insérer un nouveau Customer

             var Etoo = new Customer();
             Etoo.CustomerID = "AAAAB";
             Etoo.CompanyName = "Fils"; // toujours remplir les champs not null
             Etoo.Address = "Paris";

            // dbContext.Customers.Add(Etoo);

           //  dbContext.SaveChanges();



             //Supprimer ce Customer


             var supprime = dbContext.Customers.FirstOrDefault(f => f.CustomerID == "AAAAB");

             if(supprime != null)
             {
                // dbContext.Customers.Remove(supprime);
                 //dbContext.SaveChanges();
             }


             //Que se passe t- il si vous essayez de supprimer ALFKI ? Pourquoi ?

             var supprimeALFKI = dbContext.Customers.FirstOrDefault(f => f.CustomerID == "ALFKI");

             if (supprimeALFKI != null)
             {
             //    dbContext.Customers.Remove(supprimeALFKI);
               //  dbContext.SaveChanges();
             }*/


            //test de la méthode lind to Sql
            /*  adoToLinq adoToLinq = new adoToLinq();
             var ad= adoToLinq.GetCustomers("Patricio Simpson", "Cerrito 333");
              foreach(var sz in ad)
              {
                  Console.WriteLine(sz.Region +" "+sz.ContactTitle);
              }*/


            var list = from cust in dbContext.Customers
                       join oder in dbContext.Orders on cust.CustomerID equals oder.CustomerID
                       join oderdetail in dbContext.Order_Details on oder.OrderID equals oderdetail.OrderID
                       select new
                       {
                           Unitprice = oderdetail.UnitPrice,
                           ContactName = cust.ContactName,
                           Quantity = oderdetail.Quantity
                       };

            foreach (var sz in list)
            {
                Console.WriteLine(sz.Unitprice + " " + sz.ContactName + " " + sz.Quantity);
            }


            /*var fullEntries = dbContext.tbl_EntryPoint
    .Join(
        dbContext.tbl_Entry,
        entryPoint => entryPoint.EID,
        entry => entry.EID,
        (entryPoint, entry) => new { entryPoint, entry }
    )
    .Join(
        dbContext.tbl_Title,
        combinedEntry => combinedEntry.entry.TID,
        title => title.TID,
        (combinedEntry, title) => new
        {
            UID = combinedEntry.entry.OwnerUID,
            TID = combinedEntry.entry.TID,
            EID = combinedEntry.entryPoint.EID,
            Title = title.Title*/
        }
    )

            var list2 = dbContext.Customers
                join(
                    dbContext.Orders,
                    entrer => entrer.OrderID

                    )
            }
        }
    }
}
