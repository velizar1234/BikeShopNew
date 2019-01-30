using System;
namespace BikeShopNew
{
    public class Product
    {
        public string productType;
        public int productTypeNum;//1-Off Road, 2-Racers, 3- Kids Carrier

        public int productSystem; //1-electic, 2-mechanical
        public string productSystemName; //1-electic, 2-mechanical

        public double pricePerHour;

        public Product( int prodType, int prodSystem, double prodPrice)
        {
            switch(prodType)
            {
                case 1:
                    productType = "OffRoad ";
                    break;
                case 2:
                    productType = "Racer ";
                    break;
                case 3:
                    productType = "KidsCarrier ";
                    break;
                default:
                    productType = "Null ";
                    break;

            }
            if (prodSystem == 1)
            {
                productSystem = 1;
                productSystemName = "Electric";
            }
            else
            {
                productSystem = 2;
                productSystemName = "Mechanical";
            }


            switch (prodPrice)
            {
                case 1:
                    pricePerHour = 5.00;
                    break;
                case 2:
                    pricePerHour = 7.25;
                    break;
                case 3:
                    pricePerHour = 8.50;
                    break;
                default:
                    pricePerHour = 0.00;
                    break;

            }
            if ( productSystem == 1)
            {
                productSystem = 1;
                pricePerHour += 1.25;
            }
            else
            {
                productSystem = 2;
                pricePerHour += 0.00;
            }

        }
        public void PrintDetails()
        {
            Console.WriteLine("I am a " + productType + "and I am of type " + productSystemName + " and I am worth " + pricePerHour);
        }
    }
}
