using System.Web;
using System.Web.Optimization;
using System.Web.Optimization.Resources;
//using dotless;
//using dotless.Core;
//using Web.Optimization.Bundles.Less;





namespace bootstrap_admin
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Content/sb_admin/Foot1/*.js"));
 
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Content/sb_admin/Head1/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            //var css = new Bundle("~/Content/css").Include("~/Content/site.less");
            //css.Transforms.Add(new LessMinify());
            //bundles.Add(css);
            
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                                    "~/Scripts/knockout-{version}.js",
                        "~/Scripts/knockout.validation.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap/*.less", "~/Content/*.css"));
        }
    }
}