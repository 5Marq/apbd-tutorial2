using System;
using System.Diagnostics;

namespace tutorial2
{
    public class main
    {
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
                
                switch(choice)
                {
                    case "1":
                    {
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