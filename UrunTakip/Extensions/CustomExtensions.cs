namespace UrunTakip.Extentions
{
    public static class CustomExtensions
    {
        public static string ToStringForDatabase(this decimal value)
        {
            return value.ToString().Replace(",", ".");
        }
    }
}
