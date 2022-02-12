using System.Text.RegularExpressions;

namespace System
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
        }

        public static string InsertSpaces(this string value)
        {
            if (!value.IsEmpty())
            {
                return Regex.Replace(value, "([A-Z])", " $1", RegexOptions.Compiled).Trim();
            }
            return value;
        }
    }
}
