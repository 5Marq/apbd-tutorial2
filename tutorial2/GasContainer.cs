namespace tutorial2
{
    public class GasContainer : Container, IHazardNotifier
    {
        public GasContainer(double height, double netWeight, double depth, char type,
            double maxLoad) : base(height, netWeight, depth, type, maxLoad)
        {
            
        }
        public void notify()
        {
            System.Console.WriteLine("Danger! Container ID: "+getSerialNumber());
        }
        
        public override void unloadCargo()
        {
            setCargoWeight(getLoad()*0.05);
        }
        
        public override void loadCargo(double cargoWeight)
        {
            if (cargoWeight > getMaxLoad())
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