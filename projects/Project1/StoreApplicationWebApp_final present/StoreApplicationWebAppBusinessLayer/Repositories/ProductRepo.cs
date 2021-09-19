using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using ModelsLayer.EfModels;
using ModelsLayer.ViewModels;
using DbContextWebApp.Models;
using StoreApplicationWebAppBusinessLayer.Interfaces;

namespace StoreApplicationWebAppBusinessLayer.Repositories
{
    public class ProductRepo : IModelMapper<Product, ViewModelProduct>, IProductRepo
    {
        private readonly StoreApplicationWebAppContext _context;
        public ProductRepo(StoreApplicationWebAppContext context)
        {
            _context = context;
        }

        public ProductRepo()
        {
        }

        public Product ViewToEF(ViewModelProduct view)
        {
            Product p = _context.Products.FromSqlRaw<Product>("SELECT * FROM Product WHERE ProductName = {0}", view.ProductName).FirstOrDefault();
            return p;
        }
        public ViewModelProduct EFToView(Product ef)
        {
            ViewModelProduct p = new ViewModelProduct(ef.ProductName, ef.Price, ef.ProductDescription);
            return p;
        }

        public async Task<List<ViewModelProduct>> ProductListAsync()
        {
            List<Product> products = await _context.Products.FromSqlRaw<Product>("SELECT * FROM Product").ToListAsync();
            List<ViewModelProduct> vs = new List<ViewModelProduct>();
            foreach (Product p in products)
            {
                vs.Add(EFToView(p));
            }
            return vs;
        }
    }
}

