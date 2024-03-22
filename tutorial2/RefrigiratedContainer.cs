using System;
using System.Diagnostics;

namespace tutorial2
{
    public class RefrigiratedContainer : Container, IHazardNotifier
    {
        private string cargoType = "";
        private double temperature = 0;
        private Product product;

        public RefrigiratedContainer(double weight, double height, double netWeight, double depth, char type,
            double maxLoad, double temperature) : base(weight, height, netWeight, depth, type, maxLoad)
        {
            this.temperature = temperature;
        }

        public void notify()
        {
            System.Console.WriteLine("Niebezpieczna sytuacja! Numer kontenera: " + getSerialNunber());
        }

        protected override void unloadCargo()
        {
            setCargoWeight(0);
        }

        protected override void loadCargo(double cargoWeight)
        {
            Product
                product = new Product(cargoType,
                    temperature); //todo let the user choose the cargo and then create the product
            //todo get rid of choosing product from the constructor

            Console.WriteLine("Choose cargo type:");
            Console.WriteLine("1. Bananas");
            Console.WriteLine("2. Chocolate");
            Console.WriteLine("3. Fish");
            Console.WriteLine("4. Meat");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                {
                    product = new Product("Bananas", temperature);
                    break;
                }
                case "2":
                {
                    product = new Product("Chocolate", temperature);
                    break;
                }
                case "3":
                {
                    product = new Product("Fish", temperature);
                    break;
                }
                case "4":
                {
                    product = new Product("Meat", temperature);
                    break;
                    
                }
                default:
                {
                    Console.WriteLine("Invalid choice!");
                    break;
                }
            }
            


            if (cargoWeight > getMaxLoad())
                    {
                        notify();
                    }
                    else
                    {
                        setCargoWeight(cargoWeight);
                    }
            }
        }
    }