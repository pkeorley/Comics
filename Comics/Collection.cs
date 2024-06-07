using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comics
{
    public class Collection
    {
        private List<Comic> _comics = new();
        private int _totalNumberOfPages = 0;

        public int TotalNumberOfPages
        {
            get {
                return _totalNumberOfPages;
            }
            private set
            {
                if (value < 0)
                {
                    _totalNumberOfPages = 0;
                    return;
                }
                _totalNumberOfPages = value;
            }
        }
    
        public void Add(Comic comic)
        {
            _comics.Add(comic);
            TotalNumberOfPages += comic.NumberPage;
        }

    }
}
