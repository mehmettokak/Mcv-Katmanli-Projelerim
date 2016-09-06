using System.Web;
using System.Web.Optimization;

namespace CompanyWeb.Web
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JavaScript").Include(
                        "~/Content/includes/js/jquery/jquery.js-ver=1.12.4.js",
                        "~/Content/includes/js/jquery/jquery-migrate.min.js-ver=1.4.1.js",
                        "~/Content/pirate-forms/js/pirateformsobject.js",
                        "~/Content/js/jquery-1.8.2.min.js",
                        "~/Content/pirate-forms/js/scripts-general.js",
                        "~/Content/assets/js/frontend/add-to-cart.min.js-ver=2.5.5.js",
                        "~/Content/assets/js/jquery-blockui/jquery.blockUI.min.js-ver=2.70.js",
                        "~/Content/assets/js/frontend/woocommerce.min.js-ver=2.5.5.js",
                        "~/Content/assets/js/jquery-cookie/jquery.cookie.min.js-ver=1.4.1.js",
                        "~/Content/assets/js/frontend/cart-fragments.min.js-ver=2.5.5.js",
                        "~/Content/lite/js/bootstrap.min.js-ver=20120206.js",
                        "~/Content/lite/js/jquery.knob.js-ver=20120206.js",
                        "~/Content/lite/js/smoothscroll.js-ver=20120206.js",
                        "~/Content/lite/js/scrollReveal.js-ver=20120206.js",
                        "~/Content/lite/js/zerif.js-ver=20120206.js",
                        "~/Content/includes/js/hoverIntent.min.js-ver=1.8.1.js",
                        "~/Content/megamenu/js/megamenu.js",
                        "~/Content/megamenu/js/maxmegamenu.js-ver=2.1.5.js",
                        "~/Content/includes/js/wp-embed.min.js"

                       
                       ));

          

            bundles.Add(new StyleBundle("~/Css").Include(
                      "~/Content/pirate-forms/css/front.css",
                      "~/Content/assets/css/woocommerce-layout.css-ver=2.5.5.css",
                      "~/Content/assets/css/woocommerce-smallscreen.css-ver=2.5.5.css",
                      "~/Content/assets/css/woocommerce.css-ver=2.5.5.css",
                      "~/Content/maxmegamenu/style.css-ver=c5b68e.css",
                      "~/Content/includes/css/dashicons.min.css",
                      "~/Content/lite/css/bootstrap.css",
                      "~/css/font-awesome.min.css",
                      "~/Content/lite/style.css-ver=v1.css",
                      "~/Content/lite/css/responsive.css-ver=v1.css",
                      "~/Content/zerif-lite-sccss=1.css",
                      "~/Content/css/slider.css",
                      "~/Content/testimonial/css/screen.css"

                                ));
        }
    }
}
