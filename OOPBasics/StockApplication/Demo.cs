using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.Adapter.StockApplication
{
    public static class Demo
    {
        public static void Main____(string[] args)
        {
            IStockManager stockManager = new StockAdapter();
            string data = stockManager.GetStockData();

            Console.WriteLine(data);

            Console.ReadKey();
        }

    }
}
