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
        public void Display(List<Details> list, string Name)
        {
            Console.WriteLine("Inventory of " + Name);
            Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "Price" + "\t" + "PricePerkg");
            foreach (var data in list)
            {
                Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price + "\t" + data.Weight * data.Price);
            }
        }
        public void WriteToJson(string filepath)
        {
            var json = JsonConvert.SerializeObject(this.inventory);
            File.WriteAllText(filepath, json);
        }
        public void AddingInventory(string Name, Details details)
        {
            if (Name == "RiceList")
                this.inventory.RiceList.Add(details);
            Display(this.inventory.RiceList, "RiceList");
            if (Name == "WheatList")
                this.inventory.WheatList.Add(details);
                Display(this.inventory.WheatList, "WheatList");
            if (Name == "PulsesList")
                this.inventory.PulsesList.Add(details);
                Display(this.inventory.PulsesList, "PulsesList");
        }
        public void EditingInventory(string ItemName, string inventoryDetailName)
        {
            Console.WriteLine("For Editing Please chosse list by using: \nRiceList, \nWheatList, \nPulsesList ");
            string Inventory = Console.ReadLine();

            if (ItemName == "RiceList")
            {
                Console.WriteLine("enter the Rice name that you want to edit: ");
                string RiceList = Console.ReadLine();
                foreach (var data in this.inventory.RiceList)
                {
                    if (data.Name == inventoryDetailName)
                    {
                        Console.WriteLine("For Edit RiceList Enter \n1.Weight \n2.Price");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                data.Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("please choose correct options");
                                break;
                        }
                    }
                }
            }
            if (ItemName == "Wheat List")
            {
                Console.WriteLine("Enter Wheat list name that you want to edit:");
                string WheatName = Console.ReadLine();
                foreach (var data in this.inventory.WheatList)
                {
                    if (data.Name == inventoryDetailName)
                    {
                        Console.WriteLine("For Edit WheatList Enter \n1.Weight \n2.Price");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                data.Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("please choose correct options ");
                                break;
                        }
                    }
                }
            }
            if (ItemName == "Pulses List")
            {
                Console.WriteLine("Enter the Pulses name that you want to edit: ");
                string itemName = Console.ReadLine();
                foreach (var data in this.inventory.PulsesList)
                {
                    if (data.Name == inventoryDetailName)
                    {
                        Console.WriteLine("for Edit Pulses List Enter \n1.Weight \n2.Price");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                data.Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("please choose correct options ");
                                break;
                        }
                    }
                }
                Console.WriteLine("Inventory not exists");
            }
        }
        public void DeletingInventory(string inventoryName, string inventoryDetailsName)
        {
            if (inventoryName == "RiceList")
            {
                foreach (var data in this.inventory.RiceList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.RiceList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory not exist");
            }
            if (inventoryName == "WheatList")
            {
                foreach (var data in this.inventory.WheatList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.WheatList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory not exists");
            }
            if (inventoryName == "PulsesList")
            {
                foreach (var data in this.inventory.PulsesList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.PulsesList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory not exists");
            }

        }
    }
}
