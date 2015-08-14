@Imports BobApplication.Utilities

<!DOCTYPE html><html class="darkBack">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title</title>
    <link href='http://fonts.googleapis.com/css?family=Roboto:500,900,100,300,700,500italic,300italic,400' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Roboto+Condensed:400,700,300' rel='stylesheet' type='text/css'>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/miscellaneous")
    @RenderSection("scripts", required:=False)
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Application name", "Index", "Home", New With { .area = "" }, New With { .class = "navbar-brand" })
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li class="topLink @Html.IsActive("Home", "About")">@Html.ActionLink("About", "About", "Home")</li>
                    <li class="topLink @Html.IsActive("Home", "Portfolio")">@Html.ActionLink("Portfolio", "Portfolio", "Home")</li>
                    <li class="topLink @Html.IsActive("Home", "CareerHistory")">@Html.ActionLink("Career History", "CareerHistory", "Home")</li>
                    <li class="topLink @Html.IsActive("Home", "Skills")">@Html.ActionLink("Skills", "Skills", "Home")</li>
                    <li class="topLink @Html.IsActive("Home", "Contact")">@Html.ActionLink("Contact", "Contact", "Home")</li>
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
    <div class="body-content">
        @RenderBody()
        <div class="homeSeparator"></div>
        <footer>
            <div style="width: 100%;">
                <div class="row" style="max-width: 1140px;margin: 0 auto; padding: 15px 0 10px 0;">
                    <div class="footerText" style="display: inline-block;">&copy; @DateTime.Now.Year - Robert Zalenski</div>
                    <div style="display: inline-block;float: right;">
                        <a href="http://www.facebook.com/bzalenski" target="_blank" class="facebook"></a>
                        <a href="http://twitter.com/TheOnlyZ" target="_blank" class="twitter"></a>
                        <a href="http://www.linkedin.com/in/bobzalenski" target="_blank" class="linkedin"></a>
                    </div>
                </div>
            </div>
        </footer>
    </div>
</body>
</html>