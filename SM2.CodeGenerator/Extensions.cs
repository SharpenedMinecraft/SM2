using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SM2.CodeGenerator
{
    public static class Extensions
    {
        public static string ToCamelCase(this string s)
        {
            StringBuilder resultBuilder = new StringBuilder();

            foreach (char c in s)
            {
                // Replace anything, but letters and digits, with space
                if (!Char.IsLetterOrDigit(c))
                {
                    resultBuilder.Append(" ");
                }
                else
                {
                    resultBuilder.Append(c);
                }
            }

            string result = resultBuilder.ToString();

            // Make result string all lowercase, because ToTitleCase does not change all uppercase correctly
            result = result.ToLower();

            // Creates a TextInfo based on the "en-US" culture.
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            result = myTI.ToTitleCase(result).Replace(" ", String.Empty);
            return result;
        }
    }
}
