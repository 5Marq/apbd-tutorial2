using System;
using System.Diagnostics;

namespace tutorial2
{
    public class main
    {
        protected static void addContainer()
        {
            Console.WriteLine("Choose container type: ");
            Console.WriteLine("1. Liquid");
            Console.WriteLine("2. Refrigirated");
            Console.WriteLine("3. Gas");

            string containerChoice = Console.ReadLine();

            switch (containerChoice)
            {
                case "1":
                {
                    Console.WriteLine("Enter container weight: ");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container depth: ");
                    double depth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container max load: ");
                    double maxLoad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Is the container dangerous? (true/false)");
                    bool isDangerous = Convert.ToBoolean(Console.ReadLine());
                    Container liquidContainer = new LiquidContainer(height, 1420, depth, 'L', maxLoad,
                        isDangerous);
                    liquidContainer.addContainer(liquidContainer);
                    Console.WriteLine("Container added successfully!");
                    break;
                }
                case "2":
                {
                    Console.WriteLine("Enter container weight: ");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container depth: ");
                    double depth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container max load: ");
                    double maxLoad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container temperature: ");
                    double temperature = Convert.ToDouble(Console.ReadLine());
                    Container refrigiratedContainer = new RefrigiratedContainer(height, 1352, depth, 'R',
                        maxLoad, temperature);
                    refrigiratedContainer.addContainer(refrigiratedContainer);
                    Console.WriteLine("Container added successfully!");
                    break;
                }
                case "3":
                {
                    Console.WriteLine("Enter container weight: ");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container depth: ");
                    double depth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container max load: ");
                    double maxLoad = Convert.ToDouble(Console.ReadLine());
                    Container gasContainer = new GasContainer(height, 1680, depth, 'G', maxLoad);
                    gasContainer.addContainer(gasContainer);
                    Console.WriteLine("Container added successfully!");
                    break;
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("===Welcome to the ship simulation program===");
            Console.WriteLine("================= MENU =====================");
            bool programState = true;

            while (programState)
            {
                Console.WriteLine("1. Add a new container");
                Console.WriteLine("2. Load cargo to the container");
                Console.WriteLine("3. Add a new ship");
                Console.WriteLine("4. Load cargo to the ship");
                Console.WriteLine("5. Unload container from the ship");
                Console.WriteLine("6. Unload cargo from the container");
                Console.WriteLine("7. Show all containers");
                Console.WriteLine("8. Show all ships");
                Console.WriteLine("9. Exit program");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    {
                        addContainer();

                        break;
                    }
                    case "2":
                    {
                        break;
                    }
                    case "3":
                    {
                        break;
                    }
                    case "4":
                    {
                        break;
                    }
                    case "5":
                    {
                        break;
                    }
                    case "6":
                    {
                        break;
                    }
                    case "7":
                    {
                        break;
                    }
                    case "8":
                    {
                        break;
                    }
                    case "9":
                    {
                        programState = false;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid choice!");
                        break;
                    }
                }
            }

            Console.WriteLine("Program terminated");
            //todo UI
            //todo add ship class
        }
    }
}