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
            dr["Name"] = "Banana";
            dr["Price"] = 10;
            dr["Quantity"] = 100;

            MarketGoods.GoodsRow dr1 = dt.NewGoodsRow();
            dr1["Name"] = "Apple";
            dr1["Price"] = 12;
            dr1["Quantity"] = 50;

            dt.Rows.Add(dr);
            dt.Rows.Add(dr1);
            
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine("Name = {0}\tPrice = {1}\tQuantity = {2}", r["Name"], r["Price"], r["Quantity"]);
            }
            Console.ReadKey();
        }
    }
}
