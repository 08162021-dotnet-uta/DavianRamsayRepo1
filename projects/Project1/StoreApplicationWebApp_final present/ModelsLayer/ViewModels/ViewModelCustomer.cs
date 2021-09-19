using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.ViewModels
{
	public class ViewModelCustomer
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
                    this.fname = "invalid First Name Input";
                }
                else
                {
                    this.fname = value;
                }
            }
        }
        public string Lname
        {
            get
            {
                return this.lname;
            }
            set
            {
                if (value.Length > 50 || value.Length == 0)
                {
                    this.lname = "invalid Last Name Input";
                }
                else
                {
                    this.lname = value;
                }
            }
        }
       
        
        public ViewModelCustomer() { }
        public ViewModelCustomer(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
            
        
    }
}//EOC
}//EON