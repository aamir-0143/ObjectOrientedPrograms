using System;
using ObjectOrientedPrograms;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        static void Main(string[] agrs) 
        {
            List<Stock> stocks = new List<Stock>()
            {
               new Stock()
               {
                  Price = 10, Name = "Bajaj", nostocks  = 5, Symbol = "Bajaj.Pic"
               },

               new Stock()
               {
                   Name = "Flipkart", Price = 20, Symbol = "Flipkart.coc", nostocks = 10
               },

            };


            StockManagement stockManagement = new StockManagement(stocks);

            stockManagement.CalutateTotalValue();
            stockManagement.Buy(100, "Bajaj");
            stockManagement.Sell(40, "Flipkart");
            stockManagement.PrintReport(20, "Flipkart,Bajaj");
        }


    }
}

