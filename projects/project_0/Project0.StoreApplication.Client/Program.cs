using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Serilog;
using Project0.StoreApplication.Client.Singletons;
using System;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Storage;

namespace Project0.StoreApplication.Client
{
  class Program
  {

    // Declaring instance variables 
    private static readonly CustomerSingleton _custSing = CustomerSingleton.Instance;

    private static readonly StoreSingleton _storeSing = StoreSingleton.Instance;

    private static readonly ProductSingleton _productSing = ProductSingleton.Instance;

    private static OrderSingleton _orderSing = OrderSingleton.Instance;

    //Declaring file paths 
    private const string _filepath = @"/home/davian/revature/davian_repo/data/logs.txt";

    //static I want it to be able to be available at compile time and have access to it for the lifetime of our code 
    private static string genericPath = @"/home/davian/revature/davian_repo/data/";
    DateTime localDate = DateTime.Now;
    private static readonly FileAdapter _fileAdapter = new FileAdapter();



    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_filepath).CreateLogger();


      Run();


    }


    static void Run()
    {

      //utilizing logs to know when the run method is being used by the application
      Log.Information("Initiated Run Method");


      // DataAdapter();

      Console.WriteLine("Press '1' to sign in as a Store Manager and '2' as Customer");
      int signIn = int.Parse(Console.ReadLine());

      if (signIn == 1)
      {
        Console.WriteLine("Welcome Store Manager! Please see all Recent orders and Locations below \n");
        PrintAllOrder();

      }
      else if (signIn == 2)
      {
        Console.WriteLine("Would you like to see your past purchases? Press '1' for YES and '2' for NO");
        int sel = int.Parse(Console.ReadLine());

        if (sel == 1)
        {
          Console.WriteLine("Orders below");
          PrintAllOrder();
        }

        else if (sel == 2)
        {
          var tempStore = SelectStore();
          var tempProduct = SelectProduct();

          Console.WriteLine("The selected Store: " + tempStore);

          Console.WriteLine("The Selected Product: " + tempProduct);

          Console.WriteLine("\n\n Do you want to see the purchases for the: " + tempStore + " Store?");

          if (Confirmation())
          {
            output(GetOrdersFromStore(tempStore));
          }

          else
          {
            //Console.Write("You selected not to see your purchases");
          }



          Console.WriteLine("Do you want to confirm this purchase?");




          if (Confirmation())
          {
            var tempOrder = new Order() { Store = tempStore, Product = tempProduct };
            _orderSing.AddToOrderRepository(tempStore, tempProduct);
            AddOrdertoStore(tempStore, tempOrder);
          }
          else
          {

          }
        }
        else { Console.WriteLine("INVALID SELECTION"); }

      }
      else { Console.WriteLine("INVALID SELECTION"); }
    }











    // All the methods implemented in the run

    /// <summary>
    /// this method has no parameter and print all the orders of the stores
    /// </summary>
    /// <param></param>
    /// <returns></returns>

    private static void PrintAllOrder()
    {
      int count = 0;
      foreach (var o in _orderSing.getRepo().GetOrders())
      {
        count++;
        Console.WriteLine(count + "__" + o);
      }
    }

    /// <summary>
    /// this generic method provides a list of items 
    /// </summary>
    /// <param></param>
    /// <returns></returns>
    //implementing generics for a list of items
    private static void output<T>(List<T> data)
    {
      var select = 0;

      foreach (var item in data)
      {
        //++select;
        Console.WriteLine(++select + "__" + item);

      }
    }

    /// <summary>
    /// this method has no parameter and select the List of Store Locations throught the store singleton. 
    /// </summary>
    /// <param></param>
    /// <returns></returns>

    static Store SelectStore()
    {
      var d = _storeSing.Store;
      output(d);
      Console.WriteLine("Please select a Location");

      var selected = int.Parse(Console.ReadLine());

      var ret = d[selected - 1];


      return (ret);


    }


    /// <summary>
    /// this method has no parameter and select the products throught the product singleton. 
    /// </summary>
    /// <param></param>
    /// <returns></returns>

    //Getting a list of products through the products singleton
    static Product SelectProduct()
    {
      var d = _productSing.Product;
      output(d);
      Console.WriteLine("Please select a product");
      var selected = int.Parse(Console.ReadLine());
      var ret = d[selected - 1];

      return ret;
    }


    /// <summary>
    /// this method has no parameter and retrieves customer throught the singleton and receives the a generic output. 
    /// </summary>
    /// <param></param>
    /// <returns></returns>

    static Customer SelectCustomer()
    {
      var d = _custSing.Customer;
      output(d);
      Console.WriteLine("");


      return null;
    }

    /// <summary>
    /// This method takes 2 parameters Store and Order. This method stores the orders to the location of the stores and s
    /// </summary>
    /// <param name="s"></param>
    /// <param name="o"></param>
    static void AddOrdertoStore(Store s, Order o)
    {
      string ThePath = genericPath + s.Location + ".xml";
      List<Order> tempOrder;
      if (_fileAdapter.ReadFromFile<Order>(ThePath) == null)
      {
        _fileAdapter.WriteToFile<Order>(ThePath, new List<Order>());
      }
      else
      {
        tempOrder = _fileAdapter.ReadFromFile<Order>(ThePath);
        tempOrder.Add(o);
        _fileAdapter.WriteToFile<Order>(ThePath, tempOrder);
      }

    }

    /// <summary>
    /// this method has a parameter of Store, and returns a list of orders. 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    static List<Order> GetOrdersFromStore(Store s)
    {
      string ThePath = genericPath + s.Location + ".xml";

      return _fileAdapter.ReadFromFile<Order>(ThePath);
    }

    /// <summary>
    /// this method no parameteres and is used for a confirmation. 
    /// </summary>
    /// <param ></param>
    /// <returns></returns>
    static bool Confirmation()
    {
      Console.WriteLine("Y/N");
      if (Console.ReadLine() == "Y")
      {
        return true;
      }
      else
        return false;

    }

    /// <summary>
    /// this method no parameters and is used to communicate with the database. 
    /// </summary>
    /// <param></param>
    /// <returns></returns>

    private static void DataAdapter()
    {
      var def = new DemoEF();

      // def.SetCustomer(new Customer());

      foreach (var item in def.GetCustomers())
      {
        Console.WriteLine(item);
      }
    }
  }


}