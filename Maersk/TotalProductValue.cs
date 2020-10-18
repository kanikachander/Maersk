using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maersk
{
    public class Product
    {
        public int TotalProductValue(List<Product> ProductList)
        {
            var value = 0;
            var ItemC = ProductList.Where(x => x.ProductName == "C").FirstOrDefault();
            var ItemD = ProductList.Where(x => x.ProductName == "D").FirstOrDefault();
            if (ItemC != null && ItemD != null && ItemC.Quantity == ItemD.Quantity)
                value = ItemC != null ? ItemC.Quantity * 30 : 0;
            else
            {
                value += ItemC != null ? ItemC.Quantity * ItemC.Price : 0;
                value += ItemD != null ? ItemD.Quantity * ItemD.Price : 0;
            }
            for (var i =0; i < ItemList.Count; i++)
            {
                if(ItemList[i].ProductName == "A")
                {
                    var quotient = ProductList[i].Quantity / 3;
                    var rem = ProductList[i].Quantity % 3;
                    value += rem * ProductList[i].Price + quotient * 130;
                }
                else if (ItemList[i].ProductName == "B")
                {
                    var quotient = ProductList[i].Quantity / 2;
                    var rem = ProductList[i].Quantity % 2;
                    value += rem * ProductList[i].Price + quotient * 45;
                }
            }

            return value;

        }
    }
}
