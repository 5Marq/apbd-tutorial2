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
            System.Console.WriteLine("Danger! Container ID: " + getSerialNumber());
        }

        public override void unloadCargo()
        {
            setCargoWeight(0);
        }

        public override void loadCargo(double cargoWeight)
        {
            Product
                product = new Product(cargoType,
                    temperature);
            Console.WriteLine("==========Cargo==========");
            Console.WriteLine("1. Bananas");
            Console.WriteLine("2. Chocolate");
            Console.WriteLine("3. Fish");
            Console.WriteLine("4. Meat");
            Console.WriteLine("Choose cargo type:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                {
                    try
                    {
                        this.product = new Product("Bananas", temperature);
                        if (this.product.isTempOk())
                        {
                            if (cargoWeight > getMaxLoad())
                            {
                                throw new OverfillException("Cannot load cargo! Max load exceeded!");
                            }

                            setCargoWeight(cargoWeight);
                            Console.WriteLine("Cargo loaded successfully!");
                        }
                    }
                    catch (OverfillException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
                }
                case "2":
                {
                    try
                    {
                        this.product = new Product("Chocolate", temperature);
                        if (this.product.isTempOk())
                        {
                            if (cargoWeight > getMaxLoad())
                            {
                                throw new OverfillException("Cannot load cargo! Max load exceeded!");
                            }

                            setCargoWeight(cargoWeight);
                            Console.WriteLine("Cargo loaded successfully!");
                        }
                    }
                    catch (OverfillException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
                }
                case "3":
                {
                    try
                    {
                        this.product = new Product("Fish", temperature);
                        if (this.product.isTempOk())
                        {
                            if (cargoWeight > getMaxLoad())
                            {
                                throw new OverfillException("Cannot load cargo! Max load exceeded!");
                            }

                            setCargoWeight(cargoWeight);

                            Console.WriteLine("Cargo loaded successfully!");
                        }
                    }
                    catch (OverfillException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
                }
                case "4":
                {
                    try
                    {
                        this.product = new Product("Meat", temperature);
                        if (this.product.isTempOk())
                        {
                            if (cargoWeight > getMaxLoad())
                            {
                                throw new OverfillException("Cannot load cargo! Max load exceeded!");
                            }

                            setCargoWeight(cargoWeight);

                            Console.WriteLine("Cargo loaded successfully!");
                        }
                    }
                    catch (OverfillException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid choice!");
                    break;
                }
            }
        }
    }
}