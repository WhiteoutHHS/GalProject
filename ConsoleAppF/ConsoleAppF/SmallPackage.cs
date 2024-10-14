namespace DeliveryService
{
    public static class SmallPackage
    {
        public static string IsSmallPackage(decimal length, decimal width, decimal height, decimal weight, decimal distance)
        {
            if ((length + width + height <= 150) && (length <= 100 && width <= 100 && height <= 100) && (weight <= 10) && (distance >= 3 && distance <= 10))
                return "Отправление малогабаритное";
            else
                return "Отправление не малогабаритное";
        }
    }
}
