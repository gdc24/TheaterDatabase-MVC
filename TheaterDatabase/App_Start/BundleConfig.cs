using System.Web;
using System.Web.Optimization;

namespace TheaterDatabase
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/global-scripts").Include(
                   "~/Plugins/jquery-3.4.1.js",
                   "~/Plugins/popper.js",
                   "~/Plugins/bootstrap.js",
                   "~/Scripts/global.js"
                   ));

            bundles.Add(new StyleBundle("~/bundles/global-styles").Include(
                "~/Styles/global.css"
                ));
        }
    }
}
