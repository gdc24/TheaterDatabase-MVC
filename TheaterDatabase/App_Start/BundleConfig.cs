using System.Web;
using System.Web.Optimization;

namespace TheaterDatabase
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/global-scripts").Include(
                   "~/Scripts/global.js",
                   "~/Scripts/shows.js",
                   "~/Scripts/casts.js"
                   ));

            bundles.Add(new StyleBundle("~/bundles/global-styles").Include(
                "~/Styles/new-global.css"
                ));
        }
    }
}
