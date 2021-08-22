using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Abstracts;
using System.IO;
using System.Collections.Generic;
namespace Project0.StoreApplication.Storage.Adapters
{

  public class FileAdapter
  {
    public void WriteToFile(List<Store> stores)
    {
      // file path
      var path = @"/home/davian/revature/davian_repo/data/project_0.xml";
      //open file
      var file = new StreamWriter(path);
      //serialize object
      var xml = new XmlSerializer(typeof(List<Store>));
      //write to file
      xml.Serialize(file, stores);

    }


    public List<Store> ReadFromFile()
    {
      // file path
      var path = @"/home/davian/revature/davian_repo/data/project_0.xml";
      //open file
      var file = new StreamReader(path);
      //serialize object
      var xml = new XmlSerializer(typeof(List<Store>));
      //Read from file
      var stores = xml.Deserialize(file) as List<Store>;

      return stores;
    }

  }

}

