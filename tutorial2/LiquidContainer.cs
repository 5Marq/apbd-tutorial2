using System;

namespace tutorial2
{
    public class LiquidContainer  : Container, IHazardNotifier
    {
        public LiquidContainer(double weight, double height, double netWeight, double depth, char type,
            double maxLoad) : base(weight, height, netWeight, depth, type, maxLoad)
        {
            
        }
        
        public void notify()
        {
            Console.WriteLine("Niebezpieczna sytuacja! Numer kontenera: "+getSerialNunber());
        }
        

    }
}