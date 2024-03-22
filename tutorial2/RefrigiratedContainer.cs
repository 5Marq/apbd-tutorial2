using System;
using System.Diagnostics;

namespace tutorial2
{
    public class RefrigiratedContainer : Container, IHazardNotifier
    {
        private string cargoType = "";
        private double temperature = 0;
        private Product product;

        public RefrigiratedContainer(double height, double netWeight, double depth, char type,
            double maxLoad, double temperature) : base(height, netWeight, depth, type, maxLoad)
        {
            this.temperature = temperature;
        }

        public void notify()
        {
            System.Console.WriteLine("Danger! Container ID: " + getSerialNunber());
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
                    this.product = new Product("Bananas", temperature);
                    if (this.product.isTempOk())
                    {
                        Console.WriteLine("Enter cargo weight: ");
                        setCargoWeight(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Cargo loaded successfully!");
                    }

                    break;
                }
                case "2":
                {
                    this.product = new Product("Chocolate", temperature);
                    if (this.product.isTempOk())
                    {
                        Console.WriteLine("Enter cargo weight: ");
                        setCargoWeight(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Cargo loaded successfully!");
                    }

                    break;
                }
                case "3":
                {
                    this.product = new Product("Fish", temperature);
                    if (this.product.isTempOk())
                    {
                        Console.WriteLine("Enter cargo weight: ");
                        setCargoWeight(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Cargo loaded successfully!");
                    }

                    break;
                }
                case "4":
                {
                    this.product = new Product("Meat", temperature);
                    if (this.product.isTempOk())
                    {
                        Console.WriteLine("Enter cargo weight: ");
                        setCargoWeight(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Cargo loaded successfully!");
                    }

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