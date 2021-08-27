using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Domain.IRepository;


namespace Project0.StoreApplication.Storage.Repositories
{

  public class StoreRepository : IRepository<Store>
  {
    private const string _path = @"/home/davian/revature/davian_repo/data/Store.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    //public List<Store> Stores
    //{ get; set; }

    public StoreRepository()
    {

      if (_fileAdapter.ReadFromFile<Store>(_path) == null)
      {
        _fileAdapter.WriteToFile<Store>(_path, new List<Store>()
      {
        new Store(){Name = "Grocery Store"},
        new Store(){Name = "Athletic Store"},
        new Store(){Name = "Online Store"}

    });

      }
    }
    public bool Insert(List<Store> entry)
    {
      _fileAdapter.WriteToFile<Store>(_path, entry);
      return true;
    }

    public Store Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Store> Select()
    {
      return _fileAdapter.ReadFromFile<Store>(_path);
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }



  }

}
