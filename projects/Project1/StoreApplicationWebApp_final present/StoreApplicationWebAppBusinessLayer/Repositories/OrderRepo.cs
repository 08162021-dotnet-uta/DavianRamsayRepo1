using BusinessLayer.Interfaces;
using DbContextWebApp.Models;
using Microsoft.EntityFrameworkCore;
using ModelsLayer.EfModels;
using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplicationWebAppBusinessLayer.Repositories
{
    class OrderRepo : IModelMapper<Order, ViewModelOrder>
    {
        private readonly StoreApplicationWebAppContext _context;

        public OrderRepo(StoreApplicationWebAppContext context)
        {
            _context = context;
        }
        public ViewModelOrder EFToView(Order ef)
        {
            ViewModelOrder o1 = new ViewModelOrder(ef.OrderId, ef.StoreId, ef.CustomerId, ef.OrderDate, ef.TotalCost);
            return o1;
        }

        public Order ViewToEF(ViewModelOrder view)
        {
            Order o1 = (Order)_context.Orders.FromSqlRaw<Order>("Select * from [Order] where OrderID = {0}", view.OrderId).FirstOrDefault();
            return o1;
        }
    }
}
