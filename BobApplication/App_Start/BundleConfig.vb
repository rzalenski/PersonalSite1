Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/respond.js"))

        bundles.Add(New ScriptBundle("~/bundles/miscellaneous").Include(
                  "~/Scripts/jquery.easing.1.3.js",
                  "~/Scripts/jquery.mCustomScrollbar.js",
                  "~/Scripts/jquery.timeline.js",
                  "~/Scripts/homeMenu.js",
                  "~/Scripts/lightbox.js",
                  "~/Scripts/janimate.js",
                  "~/Scripts/bobGA.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/site.css",
                  "~/Content/homeMenu.css",
                  "~/Content/card.css",
                  "~/Content/dark.css",
                  "~/Content/flat.css",
                  "~/Content/ie8fix.css",
                  "~/Content/jquery.mCustomScrollbar.css",
                  "~/Content/light.css",
                  "~/Content/lightbox.css",
                  "~/Content/animate.css",
                  "~/Content/font-awesome.css",
                  "~/Content/component.css",
                  "~/Content/elastic_grid.css"))

        ' Set EnableOptimizations to false for debugging. For more information,
        ' visit http://go.microsoft.com/fwlink/?LinkId=301862
        BundleTable.EnableOptimizations = True
    End Sub
End Module

