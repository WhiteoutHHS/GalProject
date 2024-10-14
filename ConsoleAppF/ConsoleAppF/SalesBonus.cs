namespace DeliveryService
{
    public static class SalesBonus
    {
        public static decimal CalculateBonus(decimal sales, decimal plan)
        {
            return sales > plan ? (sales - plan) * 0.1m : 0;
        }
    }
}
