using System;
using System.Collections.Generic;

namespace tutorial2
{
    public abstract class Container
    {
        private double height;
        private double netWeight;
        private double depth;
        private char type;
        private string serialNumber = "KON";
        private static int number;
        private double maxLoad;
        private double load = 0;
        
        private static List<Container> containers = new List<Container>();

        public Container(double height, double netWeight, double depth, char type, double maxLoad)
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
        public void addContainer(Container container)
        {
            containers.Add(container);
        } 

        protected double getMaxLoad()
        {
            return maxLoad;
        }
        
        protected double getLoad()
        {
            return load;
        }
        
        protected void setCargoWeight(double cargoWeight)
        {
            this.load = cargoWeight;
        }

        protected abstract void unloadCargo();

        protected abstract void loadCargo(double cargoWeight);
    }
}