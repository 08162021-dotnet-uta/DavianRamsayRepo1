using BusinessLayer.Interfaces;
using DbContextWebApp.Models;
using Microsoft.EntityFrameworkCore;
using ModelsLayer.EfModels;
using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{


    public class CustomerRepo : IModelMapper<Customer, ViewModelCustomer>, ICustomerRepo
    {
        private readonly StoreApplicationWebAppContext _context;

        public CustomerRepo(StoreApplicationWebAppContext context)
        {
            _context = context;
        }

        public CustomerRepo()
        {
        }

        public ViewModelCustomer EFToView(Customer ef)
        {

            ViewModelCustomer c1 = new ViewModelCustomer(ef.FirstName, ef.LastName);
            return c1;
        }

        public Customer ViewToEF(ViewModelCustomer view)
        {

            Customer c1 = (Customer)_context.Customers.FromSqlRaw<Customer>("Select * From Customer where FirstName = {0} AND LastName = {1}", view.Fname, view.Lname).FirstOrDefault();
            return c1;
        }

        public async Task<ViewModelCustomer> LoginCustomerAsync(ViewModelCustomer vmc)
        {
            Customer c1 = await _context.Customers.FromSqlRaw<Customer>("Select * From Customer where FirstName = {0} AND LastName = {1}", vmc.Fname, vmc.Lname).FirstOrDefaultAsync();
            if (c1 == null)
            {
                return null;
            }

            ViewModelCustomer vmc1 = EFToView(c1);

            return vmc1;
        }

        public async Task<ViewModelCustomer> RegisterCustomerAsync(ViewModelCustomer vmc)
        {
            Customer c = ViewToEF(vmc);
            int response = await _context.Database.ExecuteSqlRawAsync("INSERT into Customer(FirstName, LastName) values ({0}, {1})", c.FirstName, c.LastName);

            if (response != 1) return null;

            return await LoginCustomerAsync(vmc);

        }

        public async Task<List<ViewModelCustomer>> CustomerListAsync()
        {
            List<Customer> customers = await _context.Customers.FromSqlRaw<Customer>("Select * FROM Customer").ToListAsync();
            List<ViewModelCustomer> vmc = new List<ViewModelCustomer>();
            foreach (Customer c in customers)
            {
                vmc.Add(EFToView(c));
            }
            return vmc;
        }
    }
}
