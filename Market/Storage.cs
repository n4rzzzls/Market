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
        string[] name;
        double[] price; = { 10.14, 11.11, 12.77, 13.34, 14.89, 15.28, 16.61 };
        double[] quantity; = { 20, 22, 24, 26, 28, 30, 32 };

        public Storage()
        {
            name = { "Banana", "Apple", "Tomato", "Cherry", "Watermelon", "Cucumber", "Merry" };
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
