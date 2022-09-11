using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPracticeProblem.StockManagment
{
    internal class CreateStocks
    {
        List<StocksPortfolio> Stock = new List<StocksPortfolio>();
        public void ReadJsonFile(string filename)
        {
            using StreamReader reader = new StreamReader(filename);
            var Json = reader.ReadToEnd();
            this.Stock = JsonConvert.DeserializeObject<List<StocksPortfolio>>(Json);
            Console.WriteLine("Name" + "\t" + "NumberOfShares" + "\t" + "PricePerShares" + "\t" + "TotalSharesPrice");
            foreach (var data in Stock)
            {
                Console.WriteLine(data.Name + "\t" + data.NumberOfShares + "\t" + data.PricePerShares + "\t" + data.NumberOfShares * data.PricePerShares);
            }
        }
    }
}
