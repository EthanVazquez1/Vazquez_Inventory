﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazquez_Inventory
{
    public interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
