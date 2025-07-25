using System.Globalization;

namespace fa.Helpers
{
    public static class CultureHelper
    {
        public static readonly CultureInfo CongoleseFranc;

        static CultureHelper()
        {
            // We clone a French culture for number formatting (e.g., using a comma for decimals)
            CongoleseFranc = (CultureInfo)new CultureInfo("fr-FR").Clone();
            
            // We set the currency symbol to "FC"
            CongoleseFranc.NumberFormat.CurrencySymbol = "FC";
        }
    }
}
