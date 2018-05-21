using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProfitCalculator.BusniessLogic
{
    public static class GainCalculator
    {
        /// <summary>
        /// This method will returen the bur data and sell date along with stock rate that gievs maximum profit
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static List<KeyValuePair<int, double>> GetBuySellForMaxGain(Dictionary<int, double> prices)
        {
            List<KeyValuePair<double, Tuple<int, int>>> buySellDetail = new List<KeyValuePair<double, Tuple<int, int>>>();

            List<KeyValuePair<int, double>> sellValuePair = new List<KeyValuePair<int, double>>();
   
            var datatOrderByPrice = prices.OrderBy(x => x.Value).ToList();

            for (int j = 0; j <= datatOrderByPrice.Count - 1; j++)
            {
                KeyValuePair<int, double> buyPrice = datatOrderByPrice[j];
                for (int i = datatOrderByPrice.Count - 1; i > 0; i--)
                {
                    var sellPrice = datatOrderByPrice[i];
                    double currentProfit = 0;
                    if (buyPrice.Key < sellPrice.Key)
                    {
                        currentProfit = CalculateStockGain(buyPrice.Value, sellPrice.Value);
                        buySellDetail.Add(new KeyValuePair<double, Tuple<int, int>>(currentProfit, new Tuple<int, int>(buyPrice.Key, sellPrice.Key)));
                    }
                }
            }
            var maxProfitDetail = buySellDetail.OrderByDescending(x => x.Key).FirstOrDefault();
            var buyDay = prices.FirstOrDefault(x => x.Key == maxProfitDetail.Value.Item1).Value;
            var sellDay = prices.FirstOrDefault(x => x.Key == maxProfitDetail.Value.Item2).Value;
            sellValuePair.Add(new KeyValuePair<int, double>(maxProfitDetail.Value.Item1, buyDay));
            sellValuePair.Add(new KeyValuePair<int, double>(maxProfitDetail.Value.Item2, sellDay));
            return sellValuePair;
        }              

        /// <summary>
        /// Calculate gain or loss based upon buying rate and selling rate
        /// </summary>
        /// <param name="buyRate"></param>
        /// <param name="sellRate"></param>
        /// <returns></returns>
        private static double CalculateStockGain(double buyRate, double sellRate)
        {
            var commisionRate = Convert.ToDouble(ConfigurationManager.AppSettings["CommisionRate"]);
            var result= Math.Round((((sellRate - commisionRate) - (buyRate + commisionRate)) / (buyRate + commisionRate)) * 100,2);
            return result;
        }
    }
}
