using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using cust = DbContextWebApp.Models;

namespace StoreApplicationWebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region code to add customers by insatnce methods 

            //Customer c1 = new Customer();
            //c1.Fname = "Davian";
            //c1.Lname = "Ramsay";


            //Customer c2 = new Customer("Tori","Ramsay");

            //Console.WriteLine($"The names are{c1.Fname} {c1.Lname} {c2.Fname} {c2.Lname}");
            #endregion

            using (cust.StoreApplicationWebAppContext context = new cust.StoreApplicationWebAppContext())
            {

                #region code to add customer to database and select customers from database
                //var customers = context.Customers.FromSqlRaw<cust.Customer>("SELECT * FROM Customer").ToList();

                ////var customers = _context.Customers.ToList();

                //foreach (var x in customers)
                //{
                //    Console.WriteLine($"The customer is {x.FirstName} {x.LastName}");
                //}//end for each


                //cust.Customer c3 = new cust.Customer();
                //c3.FirstName = "Veronica";
                //c3.LastName = "Davids";
                //c3.Email = "millie.vd@gmail.com";
                //c3.Password = "123456";

                //context.Add(c3);
                //context.SaveChanges();
                #endregion

                //\n is a new line and \t is tab
                Console.WriteLine("Hello user, would you like to log in or are you a new customer ?");
                Console.WriteLine("Select an option \n\t1 - log in\n\t  2 - Register");

            }







        }
    }
}
