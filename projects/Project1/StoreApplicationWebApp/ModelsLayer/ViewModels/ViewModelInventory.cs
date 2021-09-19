using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.ViewModels
{
    public class ViewModelInventory
    {


        public ViewModelInventory(int storeId, int productId, byte quantity)
        {
            StoreId = storeId;
            ProductId = productId;
            Quantity = quantity;
        }


        public int InventoryId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
