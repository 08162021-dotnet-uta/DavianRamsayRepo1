using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Domain.IRepository;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{

  public class OrderRepository : IRepository<Order>
  {
    private const string path = @"/home/davian/revature/davian_repo/data/Order.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();
    public static List<Order> Orders = new List<Order>();

    public OrderRepository()
    {
      if (_fileAdapter.ReadFromFile<Order>(path) == null)
      {
        //FileAdapter.WriteToFile<T>(string, List<T>)
        _fileAdapter.WriteToFile<Order>(path, new List<Order>());

      }
      else { Orders = _fileAdapter.ReadFromFile<Order>(path); }
    }


    public void AddOrder(Store s, Product p)
    {
      Orders.Add(new Order() { Store = s, Product = p });
      _fileAdapter.WriteToFile<Order>(path, Orders);
      Orders = _fileAdapter.ReadFromFile<Order>(path);
    }

    public List<Order> GetOrders()
    {
      return Orders;
    }


    public bool Insert(List<Order> entry)
    {
      _fileAdapter.WriteToFile<Order>(path, entry);
      return true;
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Order> Select()
    {
      return _fileAdapter.ReadFromFile<Order>(path);
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}