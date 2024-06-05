using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazquez_Inventory
{
    internal class BaseballGloves : IShippable
    {
        public decimal ShipCost
        {
            get => 3.23M;
        }
        public string Product
        {
            get => "BaseBall Gloves";
        }
    }
}
