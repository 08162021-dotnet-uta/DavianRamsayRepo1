using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.ViewModels
{
   public  class ViewModelStore
    {
        public ViewModelStore(string location)
        {
            
          
             Location = location;

        }


        public int StoreId { get; set; } = -1;
        public string Location { get; set; }

    }
}
