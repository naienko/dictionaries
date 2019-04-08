using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("KM", "Kimbrell's Furniture");
            stocks.Add("AMZN", "Amazon");

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add(new Dictionary<string, double>(){ {"GM", 234.12} });
            purchases.Add(new Dictionary<string, double>(){ {"KM", 2348.32} });
            purchases.Add(new Dictionary<string, double>(){ {"GM", 123.34} });
            purchases.Add(new Dictionary<string, double>(){ {"AMZN", 23.42} });

            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            foreach (Dictionary<string, double> purchase in purchases) {
                foreach (KeyValuePair<string, double> stock in purchase) {
                    string stockCompany = stocks[stock.Key];
                    if (stockReport.ContainsKey(stockCompany)) {
                        double currentStockValue = stockReport[stockCompany];
                        double newStockValue = currentStockValue + stock.Value;
                        stockReport[stockCompany] = newStockValue;

                        //stockReport[stockCompany] = stockReport[stockCompany] + stock.Value;
                    } else {
                        stockReport.Add(stockCompany, stock.Value);
                    }
                }
            };

            foreach(KeyValuePair<string, double> item in stockReport) {
                Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
            }
        }
    }
}
