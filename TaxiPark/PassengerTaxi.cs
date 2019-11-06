using System;

namespace TaxiPark
{
    public class PassengerTaxi : Car
    {
        private int numberOfPassengers;
        private int cost;
        
        public int NumberOfPassengers//properties for field number of passengers
        {
            get
            {
                return numberOfPassengers;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    numberOfPassengers = value;
                }
            }
        }
        
        public int Cost//properties for field cost for 5 km
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

        public PassengerTaxi(string brand, int registrationNumber, int yearOfIssue, int mileage, int fuelConsuption, int numberOfPassengers, int cost) : base(brand, registrationNumber, yearOfIssue, mileage, fuelConsuption)//constructor of the class, that uses constructor of the parent class
        {
            this.numberOfPassengers = numberOfPassengers;
            this.cost = cost;
        }

        public PassengerTaxi()//empty constructor
        {
        }

        public override string ToString()//overriden method ToString(), that is used to convert objects into the string
        {
            return "\nBrand: " + Brand + ", registration number: " + RegistrationNumber + ", year of issue: " + YearOfIssue + ", fuel consumption: " + FuelConsumption + ", number of passengers: " + NumberOfPassengers + ", cost for 5 km: " + Cost;
        }
    }
}