using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.ViewModels
{
    public class ViewModelOrderProduct
    {
        private string productName;
        private object productPrice;

        public ViewModelOrderProduct(int orderId, int productId)
        {
            OrderId = orderId;
            ProductId = productId;
        }

        public ViewModelOrderProduct(string productName, object productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public Guid OrderProductId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
    }
}
