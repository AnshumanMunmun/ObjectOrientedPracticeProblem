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
                        Console.WriteLine("2.Inventory Management System");
                        Factory inventoryFactory = new Factory();
                        inventoryFactory.ReadJsonFile(DETAILS_DATA_FILE_PATH);
                        break;
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }
    }
}