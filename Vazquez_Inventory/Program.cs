namespace Vazquez_Inventory
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            bool ShipActive = true;
            Shipper Amazon = new();
            Bicycles Bicycle = new();
            LawnMowers Lawnmowers = new();
            BaseballGloves Baseballgloves = new();
            Crackers Crackers = new();
            CellPhones Cellphones = new();

            do
            {
                Console.WriteLine("Please add a product.");
                Console.WriteLine("When finished, please select option 7.\n");
                
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add a Crackers to the shipment");
                Console.WriteLine("5. Add a Cell phone to the shipment");
                Console.WriteLine("6. List Shipment Items");
                Console.WriteLine("7. Compute Shipping Charges\n");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.Clear();
                    Amazon.Add(Bicycle);
                    Console.WriteLine("1 Bicycle has been added");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (answer == "2")
                {
                    Console.Clear();
                    Amazon.Add(Lawnmowers);
                    Console.WriteLine("1 Lawn Mower has been added");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (answer == "3")
                {
                    Console.Clear();
                    Amazon.Add(Baseballgloves);
                    Console.WriteLine("1 Baseball Glove has been added");
                    Console.WriteLine("Press any key to return tot he menu");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (answer == "4")
                {
                    Console.Clear();
                    Amazon.Add(Crackers);
                    Console.WriteLine("1 Cracker has been added");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (answer == "5")
                {
                    Console.Clear();
                    Amazon.Add(Cellphones);
                    Console.WriteLine("1 Cell Phone has been added");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (answer == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Shipment Manifest:\n" + Amazon.PrintItems());
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (answer == "7")
                {
                    Console.Clear();
                    Console.WriteLine("Total Cost: " + Amazon.ComputeItems().ToString("c"));
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (ShipActive);
        }
    }
}
