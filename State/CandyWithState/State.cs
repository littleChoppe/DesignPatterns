﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyWithState
{
    interface State
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurenCrank();
        void Dispense();
    }
}
