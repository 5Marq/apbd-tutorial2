using System;

namespace tutorial2
{
    public class Container
    {
        private double height;
        private double netWeight;
        private double depth;
        private char type;
        private string serialNumber = "KON";
        private static int number;
        private double maxLoad;
        private double load = 0;
        
        public Container(double weight, double height, double netWeight, double depth, char type, double maxLoad)
        {
            this.height = height;
            this.netWeight = netWeight;
            this.depth = depth;
            this.type = type;
            this.maxLoad = maxLoad;
            serialNumber += "-" + type + "-" + serialNumber;
            number++;
        }

        protected string getSerialNunber()
        {
            return serialNumber;
        }
        
        private void unloadCargo()
        {
            load = 0;
            Console.WriteLine("Pomyślnie rozładowano kontener");
        }

        private void loadCargo(double cargoWeight)
        {
            load += cargoWeight;
            if (load > maxLoad)
            {
                throw new ArgumentException("Przekroczono maksymalną ładowność!");
            }
            else
            {
                Console.WriteLine("Pomyślnie załadowano ładunek");
            }
        }
    }
}