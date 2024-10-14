namespace DeliveryService
{
    public static class CheckoutItem
    {
        public static decimal CalculateTotal(string name, decimal price, int quantity, bool isOnSale)
        {
            decimal discount = 0;
            if (quantity >= 5) discount += 0.1m;
            if (isOnSale) discount += 0.15m;

            decimal total = price * quantity;
            total -= total * discount;

            return total;
        }
    }
}
