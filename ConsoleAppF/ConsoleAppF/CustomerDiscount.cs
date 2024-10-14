namespace DeliveryService
{
    public static class CustomerDiscount
    {
        public static string CheckDiscount(string name, int age, int ordersCount, decimal totalSpent)
        {
            bool isRegularCustomer = ordersCount >= 4 && totalSpent >= 5000;
            bool isSenior = age > 60;

            return isRegularCustomer || isSenior ? $"{name} получает скидку" : $"{name} не получает скидку";
        }
    }
}
