using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comics.ComicsImplementation
{
    public class ClassicComic : IComic
    {
        private int _numberOfPages;

        public ClassicComic(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        public int NumberOfPages
        {
            get => _numberOfPages;
            set
            {
                if (value < 10)
                {
                    _numberOfPages = 10;
                    return;
                }

                _numberOfPages = value;
            }
        }

        public double GiveTimeLoan()
        {
            return NumberOfPages * 0.5;
        }
    }
}