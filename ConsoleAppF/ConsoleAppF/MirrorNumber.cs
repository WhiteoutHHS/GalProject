namespace DeliveryService
{
    public static class MirrorNumber
    {
        public static int GetMirrorNumber(int number)
        {
            int mirror = 0;
            while (number > 0)
            {
                mirror = mirror * 10 + number % 10;
                number /= 10;
            }
            return mirror;
        }
    }
}
