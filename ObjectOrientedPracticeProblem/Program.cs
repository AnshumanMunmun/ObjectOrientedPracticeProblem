using ObjectOrientedPracticeProblem.InventoryDataManagment;

namespace ObjectOrientedPracticeProblem
{
    internal class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"E:\Git\GitRepository\ObjectOrientedPracticeProblem\ObjectOrientedPracticeProblem\ObjectOrientedPracticeProblem\InventoryDataManagment\Inventory.json";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Programs\n 1.Inventory Data Management");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }
    }
}