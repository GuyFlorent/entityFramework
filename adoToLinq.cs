using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFramework
{
    class adoToLinq
    {
         public List<Customer> GetCustomers(string name = null, string adresse = null , string region = null)
            {
            NorthwindEntities dbContext = new NorthwindEntities();
            List<Customer> result = new List<Customer>();

                result = dbContext.Customers.ToList();
                if (!string.IsNullOrEmpty(name))
                {
                    result = dbContext.Customers.Where(f => f.ContactName == name).ToList(); 
                }
                if (!string.IsNullOrEmpty(adresse))
                {
                    result = dbContext.Customers.Where(f => f.Address == adresse).ToList();
                }
                if (!string.IsNullOrEmpty(region))
                {
                    result = dbContext.Customers.Where(f => f.Region == region).ToList();
                }


                return result;
            }

        //deuxieme facon de faire pour exercise diapo entity (linq to Sql)
        public List<Customer> GetCustomers2(string name = null, string adress = null, string region = null)
        {
            NorthwindEntities dbContext = new NorthwindEntities();

            List<Customer> listCustomer = dbContext.Customers.Where(p => (name == null || p.ContactName == name) && (adress == null || p.Address == adress) && (region == null || p.Region == region)).ToList();

            return listCustomer;
        }

    }
}
    

