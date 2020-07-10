using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maersk
{
    public class Order
    {
        public int TotalOrderValue(List<Item> ItemList)
        {
            var value = 0;
            var ItemC = ItemList.Where(x => x.ItemName == "C").FirstOrDefault();
            var ItemD = ItemList.Where(x => x.ItemName == "D").FirstOrDefault();
            if (ItemC != null && ItemD != null && ItemC.Quantity == ItemD.Quantity)
                value = ItemC != null ? ItemC.Quantity * 30 : 0;
            else
            {
                value += ItemC != null ? ItemC.Quantity * ItemC.Price : 0;
                value += ItemD != null ? ItemD.Quantity * ItemD.Price : 0;
            }
            for (var i =0; i < ItemList.Count; i++)
            {
                if(ItemList[i].ItemName == "A")
                {
                    var quotient = ItemList[i].Quantity / 3;
                    var rem = ItemList[i].Quantity % 3;
                    value += rem * ItemList[i].Price + quotient * 130;
                }
                else if (ItemList[i].ItemName == "B")
                {
                    var quotient = ItemList[i].Quantity / 2;
                    var rem = ItemList[i].Quantity % 2;
                    value += rem * ItemList[i].Price + quotient * 45;
                }
            }

            return value;

        }
    }
}
