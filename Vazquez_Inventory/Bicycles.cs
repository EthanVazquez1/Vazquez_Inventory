using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazquez_Inventory
{
    public class Bicycles : IShippable
    {
        public decimal ShipCost
        {
            get => 9.50M;
        }
        public string Product
        {
            get => "Bicycles";
        }
    }
}
