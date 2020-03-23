/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : complete streamreading and writing guide
 * 
 * ############################# */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLoopsAssesment
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_PER_KM = 1.25;
            double km = 0;
            double tax = 0;
            double tax_one = 0;
            const double PRICE_PER_MIN = 0.25;
            double mins;
            double total_income = 0;
            double discount;
            double average = 0;
            const double PRICE_PER_PASSENGER = 1.00;
            int passenger;
            const double PRICE_PER_LUGGGAGE = 0.5;
            double luggage;
            int counter = 0;
            Console.WriteLine("Taxi Fare Calculator");
            Console.WriteLine("Enter distance in kms or -999 to quit: ");
            km = int.Parse(Console.ReadLine());
            while (km != -999)
            {
                Console.WriteLine("Enter minutes taken: ");
                mins = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of passengers: ");
                passenger = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of pieces of luggage: ");
                luggage = int.Parse(Console.ReadLine());
                double costOfTaxi = ((PRICE_PER_KM * km) + (PRICE_PER_MIN * mins) + (PRICE_PER_PASSENGER * passenger) + (PRICE_PER_LUGGGAGE * luggage));
                Console.WriteLine(costOfTaxi);
                if (costOfTaxi > 50)
                {
                    discount = (costOfTaxi * 0.125);

                }
                else if ((costOfTaxi < 50) && (costOfTaxi > 25))
                {
                    discount = (costOfTaxi * 0.08);
                }

                else if ((costOfTaxi < 25) && (costOfTaxi > 15))
                {
                    discount = (costOfTaxi * 0.05);
                }
                else
                {
                    discount = 0;
                    costOfTaxi = costOfTaxi;
                }
                tax = costOfTaxi * 0.135;
                Console.WriteLine("Cost of taxi\t{0}", costOfTaxi);
                Console.WriteLine("Discount\t{0}", discount);
                Console.WriteLine("Tax\t\t{0}", tax);
                double total_cost = costOfTaxi + tax;
                total_income = total_income + costOfTaxi;
                Console.WriteLine("Total Cost\t{0}", total_cost);
                counter = counter+1;
                Console.WriteLine();
                Console.WriteLine("Enter distance in kms or -999 to quit: ");
                km = int.Parse(Console.ReadLine());
                tax_one = tax_one + tax;
                average = total_income / counter;
            }
            Console.WriteLine("The programme has ended");
            Console.WriteLine("The total of total income without tax\t\t{0}", total_income);
            Console.WriteLine("All tax collected\t\t{0}",tax_one);
            Console.WriteLine("The average cost of each delivery\t\t{0}",average );
        }
    }
}