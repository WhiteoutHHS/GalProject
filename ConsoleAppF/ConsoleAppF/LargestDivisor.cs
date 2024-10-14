namespace DeliveryService
{
    public static class LargestDivisor
    {
        public static int FindLargestDivisor(int a)
        {
            for (int i = a / 2; i >= 1; i--)
            {
                if (a % i == 0) return i;
            }
            return 1;
        }
    }
}
