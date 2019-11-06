using System;

namespace TaxiPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Services services = new Services();
            services.readFromFile();
            services.createArrayOfCars();
            services.printUnsortedArray();
            services.sortArray();
            services.printSortedArray();
            services.countRevenue();
            Console.WriteLine(services.showRevenue());
            services.writeResultIntoFile();
        }
    }
}