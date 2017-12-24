﻿using System.Web;
using System.Web.Optimization;

namespace ATS.WCF.UI
{
    public class BundleConfig
    {
    
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
                     "~/Content/kendo/2017.1.223/kendo.common-material.min.css",
                     "~/Content/kendo/2017.1.223/kendo.mobile.all.min.css",
                     "~/Content/kendo/2017.1.223/kendo.material.min.css",
                     "~/Content/Site.css"));
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                      "~/Scripts/kendo/2017.1.223/kendo.all.min.js",
                      "~/Scripts/kendo/2017.1.223/jszip.min.js"));

            
        }
    }
}