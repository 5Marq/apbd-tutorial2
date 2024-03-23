namespace tutorial2
{
    public class Product : IHazardNotifier
    {
        private string name = "";
        private double containerTemp = 0;

        public Product(string name, double containerTemperature)
        {
            this.name = name;
            this.containerTemp = containerTemperature;
        }

        public Product(string name)
        {
            this.name = name;
        }

        public bool isTempOk()
        {
            bool isOk = true;
            switch (name)
            {
                case "Bananas":
                {
                    if (containerTemp < 13.3)
                    {
                        notify();
                        isOk = false;
                    }

                    return isOk;
                }
                case "Chocolate":
                {
                    if (containerTemp < 18)
                    {
                        notify();
                        isOk = false;
                    }

                    return isOk;
                }
                case "Fish":
                {
                    if (containerTemp < 2)
                    {
                        notify();
                        isOk = false;
                    }

                    return isOk;
                }
                case "Meat":
                {
                    if (containerTemp < -18)
                    {
                        notify();
                        isOk = false;
                    }

                    return isOk;
                }
                default:
                {
                    return false;
                }
            }
        }

        public void notify()
        {
            System.Console.WriteLine("Invalid temperature! Product: " + name);
        }
    }
}