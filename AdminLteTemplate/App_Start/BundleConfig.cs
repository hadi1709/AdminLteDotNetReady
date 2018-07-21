using System.Web;
using System.Web.Optimization;

namespace AdminLteTemplate
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //AdminLTE Skins.We have chosen the skin - blue for this starter
            //page.However, you can choose any other skin.Make sure you
            //apply the skin class to the body tag so the changes take effect.
            bundles.Add(new StyleBundle("~/bundles/AdminlteStyle").Include(
                "~/AdminLte/bower_components/bootstrap/dist/css/ionicons.css",
                      "~/AdminLte/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/AdminLte/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/AdminLte/bower_components/Ionicons/css/ionicons.css",
                      "~/AdminLte/dist/css/AdminLTE.min.css",
                      "~/AdminLte/dist/css/skins/skin-blue.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/AdminlteJS").Include(
                "~/AdminLte/bower_components/jquery/dist/jquery.min.js",
                "~/AdminLte/bower_components/bootstrap/dist/js/bootstrap.min.js",
                        "~/AdminLte/dist/js/adminlte.min.js"));
        }
    }
}
