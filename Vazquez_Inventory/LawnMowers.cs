using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazquez_Inventory
{
    public class LawnMowers : IShippable
    {
        public decimal ShipCost
        {
            get => 24.00M;
        }
        public string Product
        {
            get => "Lawn Mowers";
        }
    }
}
