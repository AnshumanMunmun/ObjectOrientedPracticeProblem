using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPracticeProblem.InventoryDataManagment
{
    internal class Inventory
    {
        List<Details> detail = new List<Details>();
        public void ReadJsonFile(string fileName)
        {
            using StreamReader reader = new StreamReader(fileName);
            {
                var json = reader.ReadToEnd();
                this.detail = JsonConvert.DeserializeObject<List<Details>>(json);
                Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "Price" + "\t" + "PricePerkg");
                foreach (var data in detail)
                {
                    Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price + "\t" + data.Weight * data.Price);
                }
            }
        }
    }
}
