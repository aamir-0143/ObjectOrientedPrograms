using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class StockManagement
    {

        List<Stock> stocklist = new List<Stock>();
        public StockManagement(List<Stock> stocks) 
        {
            stocklist = stocks;
        }

        public void CalutateTotalValue()
        {
            foreach (Stock stock in stocklist)
            {
                stock.TotalPrice = stock.Price * stock.nostocks;
                Console.WriteLine($"{stock.Name} Has Total Price Of {stock.TotalPrice}");

            }

        }

        public void Buy(int amount, string name)
        {
            foreach (Stock stock in stocklist)
            {
                if (stock.Name == name)
                {
                    double Price = stock.Price;
                    int share = Convert.ToInt32(amount / Price);
                    Console.WriteLine($"No of share buy : {share}");
                }

            }

        }
        public void Sell(int share, string name)
        {
            foreach (Stock stock in stocklist)
            {
                if (stock.Name == name)
                {
                    double price = stock.Price;
                    int amount = Convert.ToInt32(share * price);
                    Console.WriteLine($"The share sell amount : {amount}");
                }
            }
        }
        public void PrintReport(int value, string name)
        {
            Console.WriteLine($"the share name : {name}");
            Console.WriteLine($"the total value amount : {value}");

        }

    }
}
    
