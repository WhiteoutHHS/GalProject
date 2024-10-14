using DeliveryService;
using System;

namespace DeliveryService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeliveryCost.CalculateCost(10)); // Задание 1
            Console.WriteLine(SalesBonus.CalculateBonus(60000, 50000)); // Задание 2
            Console.WriteLine(InvestmentProfit.CalculateProfit(10000)); // Задание 3
            Console.WriteLine(CheckoutItem.CalculateTotal("Товар", 100, 6, true)); // Задание 4
            Console.WriteLine(TableSuggestion.SuggestTable(5)); // Задание 5
            Console.WriteLine(CustomerDiscount.CheckDiscount("Иван", 65, 5, 6000)); // Задание 6
            Console.WriteLine(SmallPackage.IsSmallPackage(30, 40, 50, 5, 7)); // Задание 7
            Console.WriteLine(Exponentiation.Power(2, 3)); // Задание 8
            Console.WriteLine(DivisibleNumbers.GetDivisibleNumbers(3)); // Задание 9
            Console.WriteLine(PositiveIntegers.CountPositiveIntegers(1000)); // Задание 10
            Console.WriteLine(LargestDivisor.FindLargestDivisor(28)); // Задание 11
            Console.WriteLine(SumDivisibleBySeven.CalculateSum(10, 50)); // Задание 12
            Console.WriteLine(GCD.FindGCD(48, 18)); // Задание 13
            Console.WriteLine(OddDigitsCount.CountOddDigits(123456)); // Задание 14
            Console.WriteLine(MirrorNumber.GetMirrorNumber(123)); // Задание 15
        }
    }
}
