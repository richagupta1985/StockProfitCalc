using StockProfitCalculator.BusniessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProfitCalculator.BusinessLogic
{
    public static class ImportFileHelper
    {
      public   static string ReadInputFile(StreamReader streamReader)
        {

            string str = streamReader.ReadToEnd();

            var data = str.Split(',').Select(double.Parse).ToList();

            if (data.Count >= 28)
            {
                Dictionary<int, double> inputData = data.Select((s, i) => new { s, i }).ToDictionary(x => x.i, x => x.s); ;

                var MaxGainDetail = GainCalculator.GetBuySellForMaxGain(inputData);


                if (MaxGainDetail != null && MaxGainDetail.Any() && MaxGainDetail.Count() > 1)
                {
                    return string.Format("{0}({1}),{2}({3})", MaxGainDetail[0].Key + 1, MaxGainDetail[0].Value, MaxGainDetail[1].Key + 1, MaxGainDetail[1].Value);
    
                }
            }
            return string.Empty;
        }
    }
}
