using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.ViewModels
{
    public class ViewModelOrder
    {


        public ViewModelOrder(int orderId, int storeId, int customerId, DateTime orderDate, decimal totalCost)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            CustomerId = customerId;
            StoreId = storeId;
            TotalCost = totalCost;

        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public decimal TotalCost { get; set; }
    }
}
