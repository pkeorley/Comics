﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comics
{
    public interface IPaginable
    {
        int NumberOfPages { get; }
    }
}
