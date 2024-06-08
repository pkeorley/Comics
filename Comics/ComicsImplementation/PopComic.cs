using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comics.ComicsImplementation
{
    public class PopComic : IComic
    {
        private int _numberOfPages;

        public PopComic(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        public int NumberOfPages
        {
            get => _numberOfPages;
            set
            {
                if (value < 5)
                {
                    _numberOfPages = 5;
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