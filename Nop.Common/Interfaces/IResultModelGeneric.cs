﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Common.Interfaces
{
    public interface IResultModelGeneric<T, S>
    {
        bool Success { get; set; }
        string Code { get; set; }
        bool HasAlert { get; set; }
        bool HasError { get; set; }
        S InputValue { get; set; }
        string Message { get; set; }
        T OutPutValue { get; set; }
    }
}
