using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comics
{
    public class ModernComic : IComic
    {
        private int _numberOfPages;

        public ModernComic(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        public int NumberOfPages
        {
            get => _numberOfPages;
            set
            {
                if (value < 20)
                {
                    _numberOfPages = 20;
                    return;
                }

                _numberOfPages = value;
            }
        }

        public double GiveTimeLoan()
        {
            return NumberOfPages * 0.3;
        }
    }
}