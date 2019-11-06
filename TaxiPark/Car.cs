using System;

namespace TaxiPark
{
    public class Car
    {
        private string brand;
        private int registrationNumber;
        private int yearOfIssue;
        private int mileage;
        private int fuelConsuption;

        public string Brand//properties for field brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (value.Trim().Length == 0)//deletes all the blankspaces from the string and then compare it's length to zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    brand= value;
                }
            }
        }
        
        public int RegistrationNumber//properties for field registration number
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    registrationNumber= value;
                }
            }
        }
        
        public int YearOfIssue//properties for field year of issue
        {
            get
            {
                return yearOfIssue;
            }
            set
            {
                if (value < 2000)//checks if the inputed value is above 2000
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    yearOfIssue = value;
                }
            }
        }
        
        public int Mileage//properties for field mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    mileage = value;
                }
            }
        }
        
        public int FuelConsumption//properties for field fuel consumption
        {
            get
            {
                return fuelConsuption;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    fuelConsuption = value;
                }
            }
        }

        public Car(string brand, int registrationNumber, int yearOfIssue, int mileage, int fuelConsuption)
        {
            this.brand = brand;
            this.registrationNumber = registrationNumber;
            this.yearOfIssue = yearOfIssue;
            this.mileage = mileage;
            this.fuelConsuption = fuelConsuption;
        }

        public Car()//empty constructor
        {
        }

        public override string ToString()//overriden method ToString(), that is used to convert objects into the string
        {
            return "\nBrand: " + Brand + ", registration number: " + RegistrationNumber + ", year of issue: " + YearOfIssue + ", fuel consumption: " + FuelConsumption;
        }
    }
}
