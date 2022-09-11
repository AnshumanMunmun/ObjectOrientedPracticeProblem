using ObjectOrientedPracticeProblem.InventoryDataManagment;
using ObjectOrientedPracticeProblem.InventoryManagmentSystem;

namespace ObjectOrientedPracticeProblem
{
    internal class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"E:\Git\GitRepository\ObjectOrientedPracticeProblem\ObjectOrientedPracticeProblem\ObjectOrientedPracticeProblem\InventoryDataManagment\Inventory.json";
        const string DETAILS_DATA_FILE_PATH = @"E:\Git\GitRepository\ObjectOrientedPracticeProblem\ObjectOrientedPracticeProblem\ObjectOrientedPracticeProblem\InventoryManagmentSystem\Details.json";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Programs\n 1.Inventory Data Management \n 2.InventoryManagementSystem");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("1.Inventory Data Management");
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                    case 2:
                        {
                            while (true)
                            {
                                Console.WriteLine("Select Programs\n 1.Adding Items in Inventory Management System \n 2. Editing Items in Inventory Management System\n 3.Deleting Items in Inventory Management System ");
                                int option2 = Convert.ToInt32(Console.ReadLine());
                                switch (option2)
                                {
                                    case 1:
                                        Factory factory = new Factory();
                                        factory.ReadJsonFile(DETAILS_DATA_FILE_PATH);
                                        Details detail = new Details()
                                        {
                                            Name = "Brown",
                                            Weight = 15,
                                            Price = 35
                                        };
                                        factory.AddingInventory("RiceList", detail);
                                        factory.WriteToJson(DETAILS_DATA_FILE_PATH);
                                        break;
                                    case 2:
                                        Factory factory1 = new Factory();
                                        factory1.ReadJsonFile(DETAILS_DATA_FILE_PATH);
                                        factory1.EditingInventory("PulsesList", "Moong");
                                        factory1.WriteToJson(DETAILS_DATA_FILE_PATH);
                                        break;
                                    case 3:
                                        Factory factory2 = new Factory();
                                        factory2.ReadJsonFile(DETAILS_DATA_FILE_PATH);
                                        Details detail1 = new Details()
                                        {
                                            Name = "Durum",
                                            Weight = 20,
                                            Price = 35
                                        };
                                        factory2.DeletingInventory("WheatList", "Brown");
                                        factory2.WriteToJson(DETAILS_DATA_FILE_PATH);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Choice");
                                        break;
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }
    }
}