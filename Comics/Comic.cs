using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comics
{
    public abstract class Comic
    {
        private int _numberOfPages;

        public Comic(int numberOfPages)
        {
            this.NumberPage = numberOfPages;
        }

        public int NumberPage
        {
            get => _numberOfPages;
            set
            {
                if (value < 1)
                {
                    this._numberOfPages = 1;
                } else
                {
                    this._numberOfPages = value;
                }

            }
        }

        public abstract double GiveTimeLoan();
    }
}