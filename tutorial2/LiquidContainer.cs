using System;

namespace tutorial2
{
    public class LiquidContainer  : Container, IHazardNotifier
    {
        private bool isDangerous = false;
        public LiquidContainer(double weight, double height, double netWeight, double depth, char type,
            double maxLoad, bool isDangerous) : base(weight, height, netWeight, depth, type, maxLoad)
        {
            this.isDangerous = isDangerous;
        }
        public void notify()
        {
            Console.WriteLine("Niebezpieczna sytuacja! Numer kontenera: "+getSerialNunber());
        }
        
        protected override void unloadCargo()
        {
            setCargoWeight(0);
        }

        protected override void loadCargo(double cargoWeight)
        {
            if (isDangerous && cargoWeight > getMaxLoad()/2)
            {
                notify();
            }
            else if (cargoWeight <= getMaxLoad()*0.9)
            {
                setCargoWeight(cargoWeight);
            }
            else
            {
                notify();
            }
            
        }
    }
}