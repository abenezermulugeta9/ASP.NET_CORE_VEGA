﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.API.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
