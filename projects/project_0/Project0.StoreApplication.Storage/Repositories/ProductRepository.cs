using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Domain.IRepository;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{

  public class ProductRepository : IRepository<Product>
  {
    private const string path = @"/home/davian/revature/davian_repo/data/Products.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public ProductRepository()
    {
      if (_fileAdapter.ReadFromFile<Product>(path) == null)
      {
        //FileAdapter.WriteToFile<T>(string, List<T>)
        _fileAdapter.WriteToFile<Product>(path, new List<Product>()
        {
          new Product(){Name  ="Bags: ", Price = 5.50},
          new Product(){Name = "Oatmeal: " , Price = 10.50},
          new Product(){Name = "Snickers: ", Price = 20.50},


        });
      }
    }
    public bool Insert(List<Product> entry)
    {
      _fileAdapter.WriteToFile<Product>(path, entry);
      return true;
    }

    public Product Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Product> Select()
    {
      return _fileAdapter.ReadFromFile<Product>(path);
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}