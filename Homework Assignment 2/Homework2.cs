using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Assignment_2
{
    class Homework2
    {
        static void Main(string[] args)
        {
            // Variables declared here
            int numberofCasesSold;
            decimal pricePerBar;
            decimal profits;
            decimal govTaxes;
            decimal totalProfits;

            // Algorithms
            numberofCasesSold = GetnumberOfCasesSold();
            pricePerBar = GetPricePerCase();
            profits = GetProfit(numberofCasesSold, pricePerBar);
            govTaxes = GetgovTaxes(profits);
            totalProfits = FinalOutcome(govTaxes, profits);

            Console.WriteLine("The amount of cases sold was: " + numberofCasesSold);
            Console.WriteLine("The price of each bar sold was: {0:c}", + pricePerBar);
            Console.WriteLine("The total revenue was: {0:c}", profits);
            Console.WriteLine("The ammount given to the Student Government was: {0:c}", govTaxes);
            Console.WriteLine("Total ammount the Computer Club earned was: {0:c}", totalProfits);
            Console.ReadKey();
        }

        // Gets the number of cases sold from the user "GetnumberOfCasesSold"
        public static int GetnumberOfCasesSold()
        {
            int numberofCasesSold;
            Console.WriteLine("Enter the number of cases sold: ");
            numberofCasesSold = int.Parse(Console.ReadLine()); //convert to int.parse reference pg 155 in book
            return numberofCasesSold;
        }

        // Gets the price per bar from the user "GetPricePerCase"
        public static decimal GetPricePerCase()
        {
            decimal perBar;
            Console.WriteLine("Enter the price per bar: ");
            perBar = decimal.Parse(Console.ReadLine());
            return perBar;
        }
        
        // Calculates the class's profits from granola sales "GetProfit"
        public static decimal GetProfit(int numberofCasesSold, decimal pricePerBar)
        {
            decimal pricePerCase = 5.00m;
            decimal profit;
            profit = ((pricePerBar * 12) - pricePerCase) * numberofCasesSold;
            return profit;
        }

        // Calculates the amount the student government recieves from taxes 0.1% "GetgovTaxes"
        public static decimal GetgovTaxes(decimal profits)
        {
            decimal govFee = 0.1m;
            return (profits * govFee);
        }

        // Calculates the final earnings of the computer club after the gov cut
        public static decimal FinalOutcome(decimal govTaxes, decimal profits)
        {
            return (profits - govTaxes);
        }
    }
}
