

namespace DemoStore
{

  internal class Customer
  {
    private string fname;
    private string lname;

    public string Fname
    {
      get
      {
        return this.fname;
      }
      set
      {
        if (value.Length > 50 || value.Length == 0)
        {
          this.fname = "invalid Name Input";
        }
        else
        {
          this.fname = value;

        }
      }
    }

    public string Lname {
            get
            {
                return this.lname;
            }
            set 
            {
                if (value.Length > 50 || value.Length == 0)
                {
                    this.lname = "invalid Name Input";
                }
                else 
                { 
                    this.fname = value;
                }
            }
         }



    //default constructor
    public Customer()
    {

    }

    //creating a constructor 
    public Customer(string fname, string lname)
    {
      this.Fname = fname;
      this.Lname = lname;

    }


  }//end of class
}//end of namespace