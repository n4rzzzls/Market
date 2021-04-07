using System;
using System.Data;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();

            MarketGoods marketGoods = new MarketGoods();
            MarketGoods.GoodsDataTable dt = new MarketGoods.GoodsDataTable();
            MarketGoods.GoodsRow dr = dt.NewGoodsRow();
            Storage storage = new Storage(dt, dr);

/*            string[] name = { "Banana", "Apple", "Tomato", "Cherry", "Watermelon", "Cucumber", "Merry" };
            double[] price = { 10.14, 11.11, 12.77, 13.34, 14.89, 15.28, 16.61 };
            double[] quantity = { 20, 22, 24, 26, 28, 30, 32 };

            for (int i = 0; i < name.Length; i++)
            {
                dr = dt.NewGoodsRow();
                dr["Name"] = name[i];
                dr["Price"] = price[i];
                dr["Quantity"] = quantity[i];
                dt.Rows.Add(dr);
            }*/

            storage.GetGoods(dt);
            Console.ReadKey();
        }
    }
}
