using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.ViewModels
{
    public class ViewModelProduct
    {
       
        public ViewModelProduct(string productName, decimal price, string description)
        {
            
            ProductName = productName;
            Price = price;
            Description = description;
        }



        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Description {get; set;}



    }
}
