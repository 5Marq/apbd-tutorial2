using System;

namespace tutorial2
{
    public class LiquidContainer  : Container, IHazardNotifier
    {
        private bool isDangerous = false;
        public LiquidContainer(double height, double netWeight, double depth, char type,
            double maxLoad, bool isDangerous) : base(height, netWeight, depth, type, maxLoad)
        {
            this.isDangerous = isDangerous;
        }
        public void notify()
        {
            Console.WriteLine("Danger! Container ID: "+getSerialNumber());
        }
        
        protected override void unloadCargo()
        {
            setCargoWeight(0);
        }

        public override void loadCargo(double cargoWeight)
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