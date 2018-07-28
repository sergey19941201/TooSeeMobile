using System;
using Foundation;

namespace TooSeeIOS.NativeClasses
{
    public class GetCurrentCulture
    {
		public static System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var netLanguage = "en";
            if (NSLocale.PreferredLanguages.Length > 0)
            {
                var pref = NSLocale.PreferredLanguages[0];
                netLanguage = pref.Replace("_", "-");
                netLanguage = pref.Substring(0, 2);
            }
            return new System.Globalization.CultureInfo(netLanguage);
        }
    }
}
