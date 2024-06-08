using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comics
{
    public class Collection
    {
        private int _totalNumberOfPages;
        private List<ICollectionable> _comics;

        public Collection()
        {
            _totalNumberOfPages = 0;
            _comics = new();
        }

        public int TotalNumberOfPages
        {
            get => _totalNumberOfPages;
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

        public void Add(ICollectionable item)
        {
            _comics.Add(item);
            if (item is IPaginable)
            {
                TotalNumberOfPages += ((IPaginable)item).NumberOfPages;
            }
        }
    }
}
