using DemoStoreDbContext.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using cust = DemoStoreDbContext.Models.Customer;




namespace DemoStore
{
  class Program
  {
    static void Main(string[] args)
    {
            //Customer c1 = new Customer();
            //c1.Fname = "Daviannnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";
            //c1.Lname = "Jones";

            //Customer c2 = new Customer("Jerry", "McGuire");

            //Console.WriteLine($"The names are {c1.Fname}{c1.Lname}{c2.Fname}{c2.Lname }");

            using (Demo_DBContext context = new Demo_DBContext())
            {
               var customers = context.Customers.FromSqlRaw<cust>("SELECT * FROM Customers").ToList();
                //to note: I do  not need to use toList() method when pulling just one person from the database I could use .FirstOrDefault()- meaning the first
                ////one it finds with the required parameteres and give the first one it finds

               
                foreach (var x in customers)
                {
                    Console.WriteLine($"This Customer is {x.FirstName} {x.LastName}");
                }

                //cust c3 = new cust();  //using directive created an alias of the classs Customer in the DbContex Class so i dont have to write the entire word out 
                //c3.FirstName = "Christopher";
                //c3.LastName = "Moore";

                //context.Add(c3);
                //context.SaveChanges();

                //c3.FirstName = "Blake";
                //c3.LastName = "Drost";
                //context.Add(c3);
                //context.SaveChanges();

                //c3.FirstName = "Kimberly";
                //c3.LastName = "Burke";
                //context.Add(c3);
                //context.SaveChanges();


            }



        }
  }//end of class
}//end of namespace