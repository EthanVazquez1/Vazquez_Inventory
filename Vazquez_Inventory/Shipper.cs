using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazquez_Inventory
{
    internal class Shipper
    {
        private IShippable[] MyCart = new IShippable[10];
        public int[] count = new int[10];

        public IShippable Add(IShippable Item)
        {
            for (int i = 0; i < MyCart.Length; i++)
            {
                if (MyCart[i] != null && MyCart[i].GetType() == Item.GetType())
                {
                    count[i]++;
                    return MyCart[i];
                }
            }

           for (int i = 0; i < MyCart.Length; i++)
            {
                if (MyCart[i] == null)
                {
                    MyCart[i] = Item;
                    count[i] = 1;
                    return MyCart[i];
                }
            }
            return Item;
        }

        public string PrintItems()
        {
            string Result = "";
            for (int i = 0; i < MyCart.Length; i++)
            {
                if (MyCart[i] != null)
                {
                    Result += count[i].ToString() + "\t" + MyCart[i].Product.ToString() + "\n";
                }
            }
            return Result;
        }

        public decimal ComputeItems()
        {
            decimal Total = 0;
            for (int i = 0;i < MyCart.Length; i++)
            {
                if (MyCart[i] != null)
                {
                    Total += MyCart[i].ShipCost * count[i];
                }
            }
            return Total;
        }
    }
}