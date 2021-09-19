using BusinessLayer.Interfaces;
using DbContextWebApp.Models;
using Microsoft.EntityFrameworkCore;
using ModelsLayer.EfModels;
using ModelsLayer.ViewModels;
using StoreApplicationWebAppBusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplicationWebAppBusinessLayer.Repositories
{
    public class StoreRepo : IModelMapper<Store, ViewModelStore>, IStoreRepo
    {
        private readonly StoreApplicationWebAppContext _context;
        public StoreRepo(StoreApplicationWebAppContext context)
        {
            _context = context;
        }
        public Store ViewToEF(ViewModelStore view)
        {
            Store s = _context.Stores.FromSqlRaw<Store>("SELECT * FROM Store WHERE Location = {0}", view.Location).FirstOrDefault();
            return s;
        }
        public ViewModelStore EFToView(Store ef)
        {
            ViewModelStore s = new ViewModelStore(ef.Location);
            return s;
        }

        public async Task<List<ViewModelStore>> StoreListAsync()
        {
            List<Store> stores = await _context.Stores.FromSqlRaw<Store>("SELECT * FROM Store").ToListAsync();
            List<ViewModelStore> vs = new List<ViewModelStore>();
            foreach (Store s in stores)
            {
                vs.Add(EFToView(s));
            }
            return vs;
        }
    }
}
