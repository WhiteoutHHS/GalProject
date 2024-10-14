namespace DeliveryService
{
    public static class TableSuggestion
    {
        public static string SuggestTable(int guests)
        {
            if (guests <= 2) return "Маленький стол";
            if (guests <= 4) return "Средний стол";
            if (guests <= 8) return "Большой стол";
            return "Компания слишком большая для нашего ресторана";
        }
    }
}
