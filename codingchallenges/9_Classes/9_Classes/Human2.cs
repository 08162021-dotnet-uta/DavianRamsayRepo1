using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
  internal class Human2
  {

    private string firstname = "Pat";
    private string lastname = "Smyth";
    private string eyeColor;
    private int age;
    private int _weight;

    private int Weight
    {
      get
      {
        return _weight;
      }
      set
      {

        /////////////////////////////////////////review from here for this challenge--number 9 and 10////////////////////////////////////////////////////////////////
        if (_weight < 0 && _weight > 400)
        {
          _weight = 0;
          //Console.WriteLine("Invalid weight");
        }

      }
    }




    //number 1 constructor that takes first and last name 
    public Human2(string firstname, string lastname)
    {
      this.firstname = firstname;
      this.lastname = lastname;

    }


    //number 2 constructor that takes first and last name and eye color
    public Human2(string firstname, string lastname, string eyeColor)
    {
      this.firstname = firstname;
      this.lastname = lastname;
      this.eyeColor = eyeColor;

    }



    ////number 3 constructor that takes first and last name and age 
    public Human2(string firstname, string lastname, int age)
    {
      this.firstname = firstname;
      this.lastname = lastname;
      this.age = age;

    }
    ////number 4 constructor that takes first and last name and age 
    public Human2(string firstname, string lastname, int age, string eyeColor)
    {
      this.firstname = firstname;
      this.lastname = lastname;
      this.age = age;
      this.eyeColor = eyeColor;

    }




    public Human2()
    { }


    public string AboutMe2()
    {


      return $"My name is {firstname} {lastname}";
    }






    public string AboutMe2()

    {
      if (eyeColor == null)
      {
        return $"My name is {firstname} {lastname}. My age is {age}";
      }
      else if (age == 0)
      {
        return $"My name is {firstname} {lastname}. My eye color is {eyeColor}";
      }
      else if (eyeColor == null && age == 0)
      {
        return $"My name is {firstname} {lastname}";
      }
      else ($"My name is {firstname} {lastname}.My age is {age}. and eye color is {eyeColor}.");

    }


  }
}