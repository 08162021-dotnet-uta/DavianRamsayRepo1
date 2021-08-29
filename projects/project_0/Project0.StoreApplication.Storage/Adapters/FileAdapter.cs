using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;


namespace Project0.StoreApplication.Storage.Adapters
{



  public class FileAdapter
  {


    public List<T> ReadFromFile<T>(string path) where T : class
    {
      if (!File.Exists(path))
      {
        return null;
      }
      var fileReader = new StreamReader(path);
      var xml = new XmlSerializer(typeof(List<T>));
      var results = xml.Deserialize(fileReader) as List<T>;
      return results;
    }


    public void WriteToFile<T>(string path, List<T> data) where T : class
    {
      // file path
      //var path = @"/home/davian/revature/davian_repo/data/project_0.xml";
      //open file
      var file = new StreamWriter(path);
      //serialize object
      var xml = new XmlSerializer(typeof(List<T>));
      //write to file
      xml.Serialize(file, data);

    }
  }

}

