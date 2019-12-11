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
                   "~/Scripts/casts.js",
                   "~/Scripts/exec.js",
                   "~/Scripts/members.js",
                   "~/Scripts/pits.js",
                   "~/Scripts/shows.js",
                   "~/Scripts/staff.js",
                   "~/Scripts/analytics.js"
                   ));

            bundles.Add(new StyleBundle("~/bundles/global-styles").Include(
                "~/Styles/new-global.css"
                ));
        }
    }
}
