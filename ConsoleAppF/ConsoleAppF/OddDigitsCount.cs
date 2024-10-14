namespace DeliveryService
{
    public static class OddDigitsCount
    {
        public static int CountOddDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                if ((number % 10) % 2 != 0) count++;
                number /= 10;
            }
            return count;
        }
    }
}
