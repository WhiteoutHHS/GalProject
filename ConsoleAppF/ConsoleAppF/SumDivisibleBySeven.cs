namespace DeliveryService
{
    public static class SumDivisibleBySeven
    {
        public static int CalculateSum(int a, int b)
        {
            if (a > b) (a, b) = (b, a);
            int sum = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0) sum += i;
            }

            return sum;
        }
    }
}
