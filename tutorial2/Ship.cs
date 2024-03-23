using System.Collections.Generic;

namespace tutorial2
{
    public class Ship : IHazardNotifier
    {
        private List<Container> containersOnTheShip = new List<Container>();
        private double maxLoad;
        private int maxContainers;
        private double speed;
        private string serialNumber = "SHI";
        private static int number;
        private double load = 0;

        public Ship(double maxLoad, int maxContainers, double speed)
        {
            this.maxLoad = maxLoad;
            this.maxContainers = maxContainers;
            this.speed = speed;
            serialNumber += "-" + number;
            number++;
        }

        public string getSerialNumber()
        {
            return serialNumber;
        }

        public void addContainer(Container container)
        {
            if (containersOnTheShip.Count < maxContainers)
            {
                containersOnTheShip.Add(container);
                load += container.getLoad();
                return;
            }

            if (load + container.getLoad() > maxLoad)
            {
                throw new OverfillException("Cannot load container! Max ship load exceeded!");
            }

            notify();
        }

        public double getLoad()
        {
            return load;
        }

        public void unloadContainer(int index)
        {
            containersOnTheShip.RemoveAt(index);
        }

        public List<Container> getContainers()
        {
            return containersOnTheShip;
        }

        public void notify()
        {
            System.Console.WriteLine("Danger! Ship ID: " + getSerialNumber());
        }
    }
}