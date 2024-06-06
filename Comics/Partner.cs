using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comics
{
    public class Partner
    {
        private string _name;

        public Partner(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                if (value.Trim().Length < 1) { 
                    throw new ArgumentException("the length of name is 0");
                }
                
               _name = value;
            }
        }
    }
}