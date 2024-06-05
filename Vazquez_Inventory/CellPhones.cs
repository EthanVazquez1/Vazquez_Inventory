using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazquez_Inventory
{
    internal class CellPhones : IShippable
    {
        public decimal ShipCost
        {
            get => 5.95M;
        }
        public string Product
        {
            get => "Cell Phones";
        }
    }
}
