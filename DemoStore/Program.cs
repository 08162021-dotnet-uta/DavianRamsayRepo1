

namespace DemoStore
{
  class Program
  {
    static void Main(string[] args)
    {
      Customer c1 = new Customer();
      c1.Fname = "Daviannnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";
      c1.Lname = "Jones";

      Customer c2 = new Customer("Jerry", "McGuire");

      Console.WriteLine($"The names are {c1.Fname}{c1.Lname}{c2.Fname}{c2.Lname }");



    }
  }//end of class
}//end of namespace