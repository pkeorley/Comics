using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comics.ComicsImplementation
{
    public interface IComic : IPaginable, ITimeLoanProvider, ICollectionable
    {

    }
}