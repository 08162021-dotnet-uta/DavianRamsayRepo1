using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplicationWebAppBusinessLayer.Interfaces
{
   public interface IProductRepo
    {

        Task<List<ViewModelProduct>> ProductListAsync();
    }
}

