using System.Web;
using System.Web.Optimization;

namespace Customer.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/css/Style1.css","~/Content/css/animate.css", "~/Content/css/flexslider.css", "~/Content/css/icomoon.css", "~/Content/css/magnific-popup.css", "~/Content/css/bootstrap.css", "~/Content/css/style.css"));

            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //           "~/Content/js/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Content/js/modernizr-2.6.2.min.js",
                "~/Content/js/bootstrap.min.js",
                "~/Content/js/jquery.waypoints.min.js",
                "~/Content/js/magnific-popup-options.js",
                "~/Content/js/jquery.style.switcher.js",
                "~/Content/js/main.js",
                "~/Content/js/modernizr-2.6.2.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Content/js/jquery.min.js", "~/Content/js/jquery.easing.1.3.js", "~/Content/js/jquery.flexslider-min.js", "~/Content/js/jquery.magnific-popup.min.js", "~/Content/js/jquery.cookie.js", "~/Content/js/Js1.js", "~/Content/js/Js2.js"));
        }
    }
}