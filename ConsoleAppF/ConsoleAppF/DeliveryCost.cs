namespace DeliveryService
{
    public static class DeliveryCost
    {
        public static decimal CalculateCost(decimal distance)
        {
            return 150 + (70 * distance);
        }
    }
}
