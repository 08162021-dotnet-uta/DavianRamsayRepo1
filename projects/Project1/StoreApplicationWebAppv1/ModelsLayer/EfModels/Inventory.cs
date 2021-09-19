using System;
using System.Collections.Generic;

#nullable disable

namespace DbContextWebApp.Models
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int StoreId { get; set; }
        public int ProductsId { get; set; }

        public virtual Product Products { get; set; }
        public virtual Store Store { get; set; }
    }
}
