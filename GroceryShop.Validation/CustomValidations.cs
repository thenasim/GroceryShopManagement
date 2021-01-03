namespace GroceryShop.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class CustomValidations
    {
        internal static bool ValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(char.IsLetter);
        }

        internal static bool ValidNumber(string num)
        {
            double d;
            if (double.TryParse(num, out d) && d > 0)
                return true;
            return false;
        }

        internal static bool CheckDate(string date)
        {
            DateTime currentDate = DateTime.Now;

            DateTime converted;
            DateTime.TryParse(date, out converted);

            int diff = currentDate.Year - converted.Year;

            if (diff >= 18 && diff <= 60)
                return true;
            return false;
        }

        internal static bool CheckIfDateIsFuture(string date)
        {
            DateTime currentDate = DateTime.Now;

            DateTime converted;
            DateTime.TryParse(date, out converted);

            int diff = currentDate.Year - converted.Year;
            return diff > 0;
        }
    }
}
