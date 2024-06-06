using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comics
{
    public class PopComic : Comic
    {
        public PopComic(int numberOfPages) : base(numberOfPages)
        {
            this.NumberPage = numberOfPages;
        }

        public new double GiveTimeLoan()
        {
            return this.NumberPage * 0.2;
        }

    }
}