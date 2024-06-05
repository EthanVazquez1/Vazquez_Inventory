using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Vazquez_Inventory
{
    public class Crackers : IShippable
    {
        public decimal ShipCost
        {
            get => 0.57M;
        }
        public string Product
        {
            get => "Crackers";
        }
    }
}
