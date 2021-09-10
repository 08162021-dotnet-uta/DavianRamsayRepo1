using System;


namespace _9_ClassesChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {


      //human class with args 
      string fname = "Davian";
      string lname = "Ramsay";

      Human human = new Human(fname, lname);


      //human class without args 
      Human human1 = new Human();


      //calling the about me method 
      Console.WriteLine(human.AboutMe());



      Human2 human20 = new Human2("Davian", "Ramsay", "Brown");
      Human2 human21 = new Human2("Davian", "Ramsay", 20);
      Human2 human22 = new Human2("Davian", "Ramsay", "Brown", 20);


      human20.AboutMe2();
      human21.AboutMe2();
      human22.AboutMe2();






    }
  }
}
