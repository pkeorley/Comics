using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comics
{
    public class ClassicComic : Comic
    {
        public ClassicComic(int numberOfPages) : base(numberOfPages)
        {
            this.NumberPage = numberOfPages;
        }

        public new double GiveTimeLoan()
        {
            return this.NumberPage * 0.5;
        }
    }
}