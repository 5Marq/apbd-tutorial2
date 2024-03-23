using System;

namespace tutorial2
{
    public class GasContainer : Container, IHazardNotifier
    {
        private string cargoType = "";
        private Product product;

        public GasContainer(double height, double netWeight, double depth, char type,
            double maxLoad) : base(height, netWeight, depth, type, maxLoad)
        {
        }

        public void notify()
        {
            System.Console.WriteLine("Danger! Container ID: " + getSerialNumber());
        }

        public override void unloadCargo()
        {
            setCargoWeight(getLoad() * 0.05);
        }

        public override void loadCargo(double cargoWeight)
        {
            Product
                product = new Product(cargoType);
            Console.WriteLine("==========Cargo==========");
            Console.WriteLine("1. Carbon dioxide");
            Console.WriteLine("2. Carbon monoxide");
            Console.WriteLine("3. Nitrous oxide");
            Console.WriteLine("Choose cargo type:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                {
                    try
                    {
                        this.product = new Product("Carbon dioxide");
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
                        this.product = new Product("Carbon monoxide");

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
                case "3":
                {
                    try
                    {
                        this.product = new Product("Nitrous oxide");

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
                default:
                {
                    Console.WriteLine("Invalid choice!");
                    break;
                }
            }
        }
    }
}