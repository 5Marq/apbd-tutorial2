using System;

namespace tutorial2
{
    public class LiquidContainer : Container
    {
        private bool isDangerous = false;
        private string cargoType = "";
        private Product product;

        public LiquidContainer(double height, double netWeight, double depth, char type,
            double maxLoad) : base(height, netWeight, depth, type, maxLoad)
        {
        }

        public override void unloadCargo()
        {
            setCargoWeight(0);
        }

        public override void loadCargo(double cargoWeight)
        {
            Product
                product = new Product(cargoType);
            Console.WriteLine("==========Cargo==========");
            Console.WriteLine("1. Water");
            Console.WriteLine("2. PB95");
            Console.WriteLine("3. ON");
            Console.WriteLine("Choose cargo type:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                {
                    try
                    {
                        this.product = new Product("Water");
                        if (cargoWeight > getMaxLoad())
                        {
                            throw new OverfillException("Cannot load cargo! Max load exceeded!");
                        }

                        setCargoWeight(cargoWeight);
                        Console.WriteLine("Cargo loaded successfully!");
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
                        this.product = new Product("PB95");

                        if (cargoWeight > getMaxLoad() * 0.5)
                        {
                            throw new OverfillException(
                                "Cannot load cargo! Max load exceeded! Allowed only 50% of the max load for dangerous liquid cargo!");
                        }

                        setCargoWeight(cargoWeight);
                        isDangerous = true;
                        Console.WriteLine("Cargo loaded successfully!");
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
                        this.product = new Product("ON");

                        if (cargoWeight > getMaxLoad() * 0.5)
                        {
                            throw new OverfillException(
                                "Cannot load cargo! Max load exceeded! Allowed only 50% of the max load for dangerous liquid cargo!");
                        }

                        setCargoWeight(cargoWeight);
                        isDangerous = true;
                        Console.WriteLine("Cargo loaded successfully!");
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