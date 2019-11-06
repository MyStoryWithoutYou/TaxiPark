using System;
using System.IO;

namespace TaxiPark
{
    public class Services
    {
        PassengerTaxi passengerTaxi = new PassengerTaxi(); //creating an instance of a class
        CargoTaxi cargoTaxi = new CargoTaxi(); //creating an instance of a class

        Car[] taxiPark = new Car[2]; //creating an array of instances

        public int rangeOfTravel;
        public int numberOfHours;
        public int revenue;

        public void readFromFile()
        {
            using (FileStream fstream = File.OpenRead($"/Users/aliakseihudyma/RiderProjects/TaxiPark/input.txt")
            ) //starting the stream of reading from the file
            {
                byte[] array = new byte[fstream.Length]; //transforming the line from the file into bytes
                fstream.Read(array, 0, array.Length); //reading data
                string textFromFile = System.Text.Encoding.Default.GetString(array); //decoding bytes into string
                string[] words =
                    textFromFile.Split(new char[] {','},
                        StringSplitOptions.RemoveEmptyEntries); //spliting the string, separating by the comma

                int j = 0;
                passengerTaxi.Brand = words[j]; //attaching the value from the file to the instance of the class
                passengerTaxi.RegistrationNumber = int.Parse(words[j += 1]);
                passengerTaxi.YearOfIssue = int.Parse(words[j += 1]);
                passengerTaxi.Mileage = int.Parse(words[j += 1]);
                passengerTaxi.FuelConsumption = int.Parse(words[j += 1]);
                passengerTaxi.NumberOfPassengers = int.Parse(words[j += 1]);
                passengerTaxi.Cost = int.Parse(words[j += 1]);

                cargoTaxi.Brand = words[j += 1];
                cargoTaxi.RegistrationNumber = int.Parse(words[j += 1]);
                cargoTaxi.YearOfIssue = int.Parse(words[j += 1]);
                cargoTaxi.Mileage = int.Parse(words[j += 1]);
                cargoTaxi.FuelConsumption = int.Parse(words[j += 1]);
                cargoTaxi.CarryingCapacity = int.Parse(words[j += 1]);
                cargoTaxi.Cost = int.Parse(words[j += 1]);

                if (fstream != null)
                {
                    fstream.Close(); //closing the stream of reading from the file
                }
            }
        }

        public void createArrayOfCars()
        {
            taxiPark[0] = passengerTaxi; //putting the instances of the classes into the array
            taxiPark[1] = cargoTaxi;
        }

        public void printUnsortedArray()
        {
            Console.WriteLine("***** Unsorted array *****");
            foreach (Car c in taxiPark)
            {
                Console.WriteLine(c); //printing the unsorted array
            }
        }

        public void
            sortArray() // bubble sorting of the array(if two elements are in the wrong order, they swap their positions)
        {
            Car temp;
            for (int i = 0; i < taxiPark.Length - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < taxiPark.Length - i - 1; j++)
                {
                    if (taxiPark[j + 1].Mileage < taxiPark[j].Mileage)
                    {
                        f = true;
                        temp = taxiPark[j + 1];
                        taxiPark[j + 1] = taxiPark[j];
                        taxiPark[j] = temp;
                    }
                }

                if (!f) break;
            }
        }

        public int countRevenue()//counts revenue for the day
        {
            Console.WriteLine("\nEnter range of travel: ");
            rangeOfTravel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter number of hours: ");
            numberOfHours = Convert.ToInt32(Console.ReadLine());

            revenue = rangeOfTravel * passengerTaxi.Cost + (cargoTaxi.Cost + cargoTaxi.Cost * numberOfHours / 2);

            return revenue;
        }

        public string showRevenue()
        {
            return "The revenue for the day is: " + revenue;
        }

        public void printSortedArray()
        {
            Console.WriteLine("***** Sorted array *****");
            foreach (Car c in taxiPark)
            {
                Console.WriteLine(c); //printing the sorted array
            }
        }

        public void writeResultIntoFile()
        {
            string str1 = passengerTaxi.ToString(); //transforming instances of the classes into string
            string str2 = cargoTaxi.ToString();
            string str = str1 + str2 + showRevenue(); //joining everything into the one string

            using (FileStream fstream = new FileStream($"/Users/aliakseihudyma/RiderProjects/TaxiPark/output.txt",
                FileMode.OpenOrCreate)) //starting a stream of writing into a file
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(str); //transforming string into bytes
                fstream.Write(array, 0, array.Length); //writing bytes into the file
                Console.WriteLine("\nText is written into the file");
            }
        }
    }
}