using System.Collections.Generic;

namespace tutorial2
{
    public class Ship
    {
     private List<Container> containersOnTheShip = new List<Container>();
     private double maxLoad;
     private int maxContainers;
     private double speed;
     private string serialNumber = "SHI";
     private static int number;
     
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
    }
}