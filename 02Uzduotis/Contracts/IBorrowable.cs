﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02Uzduotis.Models;

namespace _02Uzduotis.Contracts
{
    public interface IBorrowable
    {
        void Borrow(Reader reader);
        void Return(Reader reader);
    }
}
