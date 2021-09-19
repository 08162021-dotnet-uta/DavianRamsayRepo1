//using BusinessLayer.Interfaces;
//using DbContextWebApp.Models;
//using Microsoft.EntityFrameworkCore;
//using ModelsLayer.EfModels;
//using ModelsLayer.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StoreApplicationWebAppBusinessLayer.Repositories
//{
//    public class OrderProductRepo : IModelMapper<OrderProduct, ViewModelOrderProduct>
//    {
//        private readonly StoreApplicationWebAppContext _context;
//        public OrderProduct ViewToEF(ViewModelOrderProduct view)
//        {
//            int orderid = view.OrderId;
//            Product p = _context.Products.FromSqlRaw<Product>("SELECT * FROM Product WHERE ProductName = {0}", view.OrderProductId).FirstOrDefault();
//            OrderProduct op1 = _context.OrderProducts.FromSqlRaw<OrderProduct>("SELECT * FROM OrderProducts WHERE OrderID = {0} AND ProductID = {1}", orderid, p.ProductId).FirstOrDefault();
//            return op1;
//        }
//        public ViewModelOrderProduct EFToView(OrderProduct ef)
//        {
//            ViewModelOrderProduct p = new ViewModelOrderProduct(ef.Product.ProductName, ef.Product.Price);
//            ViewModelCustomer c = new ViewModelCustomer(ef.Order.Customer, ef.Order.Customer.FirstName, ef.Order.Customer.LastName);
//            ViewModelStore s = new ViewModelStore(ef.Order.Store.StoreLocation)1;
//            ViewModelOrder o = new ViewModelOrder(ef.Order.OrderId, ef.Order.OrderDate, c, s, ef.Order.TotalPrice);
//            ViewModelOrderProduct c1 = new ViewModelOrderProduct(ef.Quantity, p, o);
//            return c1;
//        }
//    }

//}
