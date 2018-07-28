using System.Reflection;
using System.Globalization;
using System.Resources;
using TooSeePCL.Resources;

namespace TooSeePCL
{
    public static class TranslationHelper
    {
        public static string GetString(string key, CultureInfo ci)
        {
            ResourceManager temp = new ResourceManager(
                "TooSeePCL.Resources.AppResources",
                typeof(AppResources).GetTypeInfo().Assembly);
            string result = temp.GetString(key, ci);
            return result;
        }
    }
}
