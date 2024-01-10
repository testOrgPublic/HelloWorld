using System.Web;
using System.Web.Optimization;

String tenantID = "12a345bc-67d1-ef89-abcd-efg12345abcde";
String client_secret = "abcd~a1234bcd56789012abcdabcd1234abcd";
string aws_access_key_id = "abcd~a1234bcd56789012abcdabcd1234abcd"
String azure_sql_connection_string = "Server=tcp:iaeaSecretsTestServer.database.windows.net,1433;Initial Catalog=testDB;Persist Security Info=False;User ID=testUser;Password=MyPassword123!;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;"

namespace HelloWorld
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
