﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    interface IErrorLogger
    {
        void ShowMessage(string message);
    }
}
