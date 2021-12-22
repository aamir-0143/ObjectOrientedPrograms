using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class StockManagement
    {
        public void CalutateTotalValue(List<Stock> stocks1)
        {
            foreach (Stock stock in stocks1)
            {
                stock.TotalPrice = stock.Price * stock.nostocks;
                Console.WriteLine($"{stock.Name} Has Total Price Of {stock.TotalPrice}");

            }

        }
    }
}
