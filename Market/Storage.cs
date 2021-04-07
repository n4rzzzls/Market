using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Storage
    {
        public List<Good> goods = new List<Good>();
        
        public Storage(MarketGoods.GoodsDataTable dt, MarketGoods.GoodsRow dr)
        {
            goods.Add(new Good("Banana", 10.14, 20));
            goods.Add(new Good("Apple", 11.11, 22));
            goods.Add(new Good("Tomato", 12.77, 24));
            goods.Add(new Good("Cherry", 13.34, 26));
            goods.Add(new Good("Watermelon", 14.89, 28));
            goods.Add(new Good("Cucumber", 15.28, 30));
            goods.Add(new Good("Merry", 16.61, 32));

            foreach (var item in goods)
            {

                dr = dt.NewGoodsRow();
                dr["Name"] = item.Name;
                dr["Price"] = item.Price;
                dr["Quantity"] = item.Quantity;
                dt.Rows.Add(dr);

            }
        }

    public void GetGoods(MarketGoods.GoodsDataTable dt)
        {
            Console.WriteLine("ID\tName\t\tPrice\tQuantity\n--\t----\t\t-----\t--------");
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine("{0}\t{1, -10}\t{2}\t{3}", r["ID"], r["Name"], r["Price"], r["Quantity"]);
            }
        }


    }
}
