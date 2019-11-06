using System;

namespace TaxiPark
{
    public class CargoTaxi : Car
    {
        private int carryingCapacity;
        private int cost;
        
        public int CarryingCapacity//properties for field carrying capacity
        {
            get
            {
                return carryingCapacity;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    carryingCapacity = value;
                }
            }
        }
        
        public int Cost//properties for field cost for 1 hour
        {
            get
            {
                return cost;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    cost = value;
                }
            }
        }

        public CargoTaxi(string brand, int registrationNumber, int yearOfIssue, int mileage, int fuelConsuption, int carryingCapacity, int cost) : base(brand, registrationNumber, yearOfIssue, mileage, fuelConsuption)//constructor of the class, that uses constructor of the parent class
        {
            this.carryingCapacity = carryingCapacity;
            this.cost = cost;
        }

        public CargoTaxi()//empty constructor
        {
        }


        public override string ToString()//overriden method ToString(), that is used to convert objects into the string
        {
            return "\nBrand: " + Brand + ", registration number: " + RegistrationNumber + ", year of issue: " + YearOfIssue + ", fuel consumption: " + FuelConsumption + ", carrying capacity: " + CarryingCapacity + ", cost for 1 hour: " + Cost;
        }
    }
}