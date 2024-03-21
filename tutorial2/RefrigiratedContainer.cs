namespace tutorial2
{
    public class RefrigiratedContainer : Container, IHazardNotifier
    {
        private string cargoType = "";
        private double temperature = 0;
        private Product product;
        public RefrigiratedContainer(double weight, double height, double netWeight, double depth, char type,
            double maxLoad, string cargoType) : base(weight, height, netWeight, depth, type, maxLoad)
        {
            this.cargoType = cargoType;
        }
        public void notify()
        {
            System.Console.WriteLine("Niebezpieczna sytuacja! Numer kontenera: "+getSerialNunber());
        }
        
        protected override void unloadCargo()
        {
            setCargoWeight(0);
        }
        
        protected override void loadCargo(double cargoWeight)
        {
            Product product = new Product(cargoType, temperature); //todo let the user choose the cargo and then create the product
            //todo get rid of choosing product from the constructor
            
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