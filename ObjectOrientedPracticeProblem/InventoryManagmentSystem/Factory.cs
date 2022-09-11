using Newtonsoft.Json;
using ObjectOrientedPracticeProblem.InventoryDataManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPracticeProblem.InventoryManagmentSystem
{
    internal class Factory
    {
        Managment inventory = new Managment();
        public void ReadJsonFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var Json = reader.ReadToEnd();
                this.inventory = JsonConvert.DeserializeObject<Managment>(Json);
                Display(this.inventory.RiceList, "RiceList");
                Display(this.inventory.WheatList, "WheatList");
                Display(this.inventory.PulsesList, "PulsesList");
            }
        }
        public void Display(List<Details> list, string inventoryName)
        {
            Console.WriteLine("Inventory of " + inventoryName);
            Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "Price" + "\t" + "PricePerkg");
            foreach (var data in list)
            {
                Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price + "\t" + data.Weight * data.Price);
            }
        }
    }
}
