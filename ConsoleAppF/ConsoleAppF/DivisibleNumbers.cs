namespace DeliveryService
{
    public static class DivisibleNumbers
    {
        public static string GetDivisibleNumbers(int a)
        {
            var result = new System.Text.StringBuilder();
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    result.Append(i + " ");
                }
            }
            return result.ToString().Trim();
        }
    }
}
