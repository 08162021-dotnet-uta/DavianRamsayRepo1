using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplicationWebApp
{
    class ViewModelCustomer
    {
        private string fname;
        private string lname;
        public string Fname {
           
         //setters and getters with constraints for input validation    
            get
            {
                return this.fname;
            }


            set
            {
                if (value.Length > 50 || value.Length == 0)
                    {
                    this.fname = "Invalid First Name format";
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
                    this.lname = "Invalid Last Name format";
                }
            
            }    
        
        }


        //Constructor created that takes a first name and last name
        public ViewModelCustomer(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        
        }


        //default constructor explicitely created due to the parameterized one created above 

        public ViewModelCustomer()
        { }


    }//end of class
}//end of namespace 
