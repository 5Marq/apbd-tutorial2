using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace tutorial2
{
    public class main
    {
        static List<Container> containersToShow = new List<Container>();
        static List<Ship> shipsToShow = new List<Ship>();

        protected static void showContainers()
        {
            Console.WriteLine("==========Containers===========");
            if (containersToShow.Count == 0)
            {
                Console.WriteLine("No containers to show!");
                Thread.Sleep(1000);
                return;
            }
                        
            for (int i = 0; i < containersToShow.Count; i++)
            {
                Console.WriteLine($"{i}. Serial: {containersToShow[i].getSerialNumber()}, Load: {containersToShow[i].getLoad()}");
            }
            Thread.Sleep(1000);
        }

        protected static void showShips()
        {
            Console.WriteLine("==========Ships===========");
            if (shipsToShow.Count == 0)
            {
                Console.WriteLine("No ships to show!");
                Thread.Sleep(1000);
                return;
            }
                        
            for (int i = 0; i < shipsToShow.Count; i++)
            {
                Console.WriteLine(i+". Serial: "+shipsToShow[i].getSerialNumber());
                Console.WriteLine("Containers on this ship:");
                List<Container> tempContainers = shipsToShow[i].getContainers();
                if (containersToShow.Count == 0)
                {
                    Console.WriteLine("No containers to show!");
                    Thread.Sleep(1000);
                    return;
                }
                for (int j = 0; j < shipsToShow[i].getContainers().Count; j++)
                {
                    Console.WriteLine(tempContainers[i].getSerialNumber());
                }
            }
            Thread.Sleep(1000);
        }
        
        protected static void addContainer()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("1. Liquid");
            Console.WriteLine("2. Refrigirated");
            Console.WriteLine("3. Gas");
            Console.WriteLine("Choose container type: ");
            
            string containerChoice = Console.ReadLine();

            switch (containerChoice)
            {
                case "1":
                {
                    Console.WriteLine("===========Liquid=============");
                    Console.WriteLine("Enter container height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container depth: ");
                    double depth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container max load: ");
                    double maxLoad = Convert.ToDouble(Console.ReadLine());
                    Container liquidContainer = new LiquidContainer(height, 1420, depth, 'L', maxLoad);
                    liquidContainer.addContainer(liquidContainer);
                    containersToShow.Add(liquidContainer);
                    Console.WriteLine("Container added successfully!");
                    Thread.Sleep(1000);
                    break;
                }
                case "2":
                {
                    Console.WriteLine("==========Refrigerated===========");
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
                    containersToShow.Add(refrigiratedContainer);
                    Console.WriteLine("Container added successfully!");
                    Thread.Sleep(1000);
                    break;
                }
                case "3":
                {
                    Console.WriteLine("==========Gas===========");
                    Console.WriteLine("Enter container height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container depth: ");
                    double depth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter container max load: ");
                    double maxLoad = Convert.ToDouble(Console.ReadLine());
                    Container gasContainer = new GasContainer(height, 1680, depth, 'G', maxLoad);
                    gasContainer.addContainer(gasContainer);
                    containersToShow.Add(gasContainer);
                    Console.WriteLine("Container added successfully!");
                    Thread.Sleep(1000);
                    break;
                }
            }
        }
        
        protected static void addShip()
        {
            Console.WriteLine("Enter max ship load: ");
            double maxLoad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter max containers allowed: ");
            int maxContainers = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter cruising speed: ");
            double cruisingSpeed = Convert.ToDouble(Console.ReadLine());
            Ship ship = new Ship(maxLoad, maxContainers, cruisingSpeed);
            shipsToShow.Add(ship);
            Console.WriteLine("Ship added successfully!");
            Thread.Sleep(1000);
        }

        protected static void addContainerToShip()
        {
            showContainers();
            Console.WriteLine("Choose container to load to the ship(pick a number): ");
            int containerChoice = Convert.ToInt16(Console.ReadLine());
            showShips();
            Console.WriteLine("Choose ship to load the container(pick a number): ");
            int shipChoice = Convert.ToInt16(Console.ReadLine());
            shipsToShow[shipChoice].addContainer(containersToShow[containerChoice]);
            Console.WriteLine("Container loaded to the ship successfully!");
            Thread.Sleep(1500);
        }

        protected static void unloadContainerFromShip()
        {
            showShips();
            Console.WriteLine("Choose ship to unload the container(pick a number): ");
            int shipChoice = Convert.ToInt16(Console.ReadLine());
            List<Container> tempContainers = shipsToShow[shipChoice].getContainers();
            Console.WriteLine("Choose container to unload from the ship(pick a number): ");
            int containerChoice = Convert.ToInt16(Console.ReadLine());
            shipsToShow[shipChoice].unloadContainer(containerChoice);
            Console.WriteLine("Container unloaded from the ship successfully!");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("===Welcome to the ship simulation program===");
            bool programState = true;

            while (programState)
            {
                Thread.Sleep(1000); //using sleep to allow user to read the info
                Console.WriteLine("=================MENU====================");
                Console.WriteLine("1. Add a new container");
                Console.WriteLine("2. Load cargo to the container");
                Console.WriteLine("3. Add a new ship");
                Console.WriteLine("4. Load container to the ship");
                Console.WriteLine("5. Unload container from the ship");
                Console.WriteLine("6. Unload cargo from the container");
                Console.WriteLine("7. Show all containers");
                Console.WriteLine("8. Show all ships");
                Console.WriteLine("9. Exit program");
                Console.WriteLine("Choose an option: ");

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
                        showContainers();
                        Console.WriteLine("Choose container to load cargo(pick a number): ");
                        int containerChoice = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Loading cargo for container: "+containersToShow[containerChoice].getSerialNumber());
                        Console.WriteLine("Enter cargo weight: ");
                        double cargoWeight = Convert.ToDouble(Console.ReadLine());
                        containersToShow[containerChoice].loadCargo(cargoWeight);
                        Thread.Sleep(1000);
                        break;
                    }
                    case "3":
                    {
                        addShip();
                        break;
                    }
                    case "4":
                    {
                        addContainerToShip();
                        break;
                    }
                    case "5":
                    {
                        unloadContainerFromShip();
                        break;
                    }
                    case "6":
                    {
                        showContainers();
                        Console.WriteLine("Choose container to unload cargo(pick a number): ");
                        int containerChoice = Convert.ToInt16(Console.ReadLine());
                        if (containersToShow[containerChoice].getLoad() == 0)
                        {
                            Console.WriteLine("Container is empty!");
                            Thread.Sleep(1000);
                            break;
                        }
                        Console.WriteLine("Removed cargo from container: "+containersToShow[containerChoice].getSerialNumber()+" with load of (kg): "+containersToShow[containerChoice].getLoad());
                        containersToShow[containerChoice].unloadCargo();
                        Thread.Sleep(1500);
                        break;
                    }
                    case "7":
                    {
                        showContainers();
                        break;
                    }
                    case "8":
                    {
                        showShips();
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