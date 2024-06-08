using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Comics.Interfaces;

namespace Comics.ComicsImplementation
{
    public interface IComic : IPaginable, ITimeLoanProvider, ICollectionable
    {

    }
}