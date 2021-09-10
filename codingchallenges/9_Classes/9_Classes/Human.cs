using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
  internal class Human
  {
    private string firstname = "Pat";
    private string lastname = "Smyth";

    public Human(string firstname, string lastname)
    {
      this.firstname = firstname;
      this.lastname = lastname;

    }

    public Human()
    { }


    public string AboutMe()
    {


      return $"My name is {this.firstname} {this.lastname}.";
    }











  }//end of class
}//end of namespace