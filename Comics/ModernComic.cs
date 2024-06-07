using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comics
{
    public class ModernComic : Comic
    {
        public ModernComic(int numberOfPages) : base(numberOfPages)
        {
            this.NumberPage = numberOfPages;
        }

        public override double GiveTimeLoan()
        {
            return this.NumberPage * 0.3;
        }
    }
}