
// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;
// using Project0.StoreApplication.Domain.Models;

// namespace Project0.StoreApplication.Storage.Adapters
// {
//   public class DataAdapter : DbContext
//   {
//     //entiry creations
//     public DbSet<Customer> Customers { get; set; }
//     public DbSet<Order> Orders { get; set; }
//     public DbSet<Product> Products { get; set; }
//     public DbSet<Store> Stores { get; set; }


//     //connections to database 
//     protected override void OnConfiguring(DbContextOptionsBuilder builder)
//     {
//       //Truscted_Connection=True
//       builder.UsecdSqlServer("server=(localdb)\\MSSQLLocalDB; database=StoreApplicationDb; Truscted_Connection=True ");
//     }


//public List<Customer> GetCustomers()
// {
// return _da.Customers.FromSqlRaw("Select Name from Customer.Customer").ToList();
// }
// public void setCustomer(Customer customer)
// {
//  _da.Customers.FromSqlRaw("insert into Customer.Customer(Name) values ({0}),", customer.userName);
// }





//   }

// }