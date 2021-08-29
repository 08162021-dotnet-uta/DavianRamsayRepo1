using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Domain.IRepository;

namespace Project0.StoreApplication.Storage.Repositories
{

  public class CustomerRepository : IRepository<Customer>
  {
    private const string _path = @"/home/davian/revature/davian_repo/data/customers.xml";

    private static readonly FileAdapter _fileAdapter = new FileAdapter();
    //public List<Customer>  { get; set; }

    public CustomerRepository()
    {



      if (_fileAdapter.ReadFromFile<Customer>(_path) == null)
      {
        _fileAdapter.WriteToFile<Customer>(_path, new List<Customer>()
          {
          new Customer(){Name = "Davian1"},
          new Customer(){Name = "Davian2"},
          new Customer(){Name = "Davian3"}
          });
      }
      //Stores = fileAdapter.ReadFromFile();


    }

    public bool Insert(List<Customer> entry)
    {
      _fileAdapter.WriteToFile<Customer>(_path, entry);
      return true;
    }

    public Customer Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Customer> Select()
    {
      return _fileAdapter.ReadFromFile<Customer>(_path);
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }



  }

  /*  public Store GetStore(int index)
   {
     try
     {

       return Stores[index];

     }
     catch
     {
       return null;

     }

   } */
}


