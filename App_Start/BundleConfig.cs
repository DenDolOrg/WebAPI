using System.Web;
using System.Web.Optimization;

namespace WebAPI_test
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bibles").Include(
                        "~/Scripts/jquery-3.3.1.min.js",
                        "~/Scripts/knockout-3.5.0rc2.js"));

          
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
