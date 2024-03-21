namespace tutorial2
{
    public class GasContainer : Container, IHazardNotifier
    {
        public GasContainer(double weight, double height, double netWeight, double depth, char type,
            double maxLoad) : base(weight, height, netWeight, depth, type, maxLoad)
        {
            
        }
        public void notify()
        {
            System.Console.WriteLine("Niebezpieczna sytuacja! Numer kontenera: "+getSerialNunber());
        }
        
        protected override void unloadCargo()
        {
            setCargoWeight(getLoad()*0.05);
        }
        
        protected override void loadCargo(double cargoWeight)
        {
            if (cargoWeight > getMaxLoad()*0.9)
            {
                notify();
            }
            else
            {
                setCargoWeight(cargoWeight);
            }
        }

    }
}