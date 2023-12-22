using System.Web;
using System.Web.Mvc;

String tenantID = "12a345bc-67d1-ef89-abcd-efg12345abcde";
String client_secret = "abcd~a1234bcd56789012abcdabcd1234abcd";

namespace HelloWorld
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
