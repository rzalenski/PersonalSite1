@Code
    ViewData("Title") = "Robert Zalenski"
End Code

<script type="text/javascript">
    $(function () {
        if ($('body').width() > 767) {
            $("ul.navbar-nav").addClass("collapse");
        } else {
            $("ul.navbar-nav").removeClass("collapse");
        }
    });
</script>

<div class="homeBack" style="width: 100%;">
    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel" style="max-width: 1140px; margin: 0 auto;">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
            <li data-target="#carousel-example-generic" data-slide-to="1"></li>
            <li data-target="#carousel-example-generic" data-slide-to="2"></li>
        </ol>
        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <div class="billboardContain">
                    <div class="graphicBillboard">Front-End Development. User Interface Design.</div>
                </div>
                <img src="../images/slideApps.jpg" alt="...">
            </div>
            <div class="item">
                <div class="billboardContain">
                    <div class="graphicBillboard">Website Design.</div>
                </div>
                <img src="../images/slideWebsites.jpg" alt="...">
            </div>
            <div class="item">
                <div class="billboardContain">
                    <div class="graphicBillboard">Graphic Design. Corporate Identity. Brand.</div>
                </div>
                <img src="../images/slideGraphic.jpg" alt="...">
            </div>
        </div>
        <!-- Controls -->
        <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
            <span class="iconContain">
                <i class="directionalIcons fa fa-angle-left"></i>
            </span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
            <span class="iconContain">
                <i class="directionalIcons fa fa-angle-right"></i>
            </span>
            <span class="sr-only">Next</span>
</a>
    </div>
</div>
<div class="menuBar" style="width: 100%;">
    <div class="row" style="max-width: 1140px;margin: 0 auto;">
        <ul id="sdt_menu" class="sdt_menu">
            <li>
                <a href="../Home/About">
                    <div class="menuImageContain aboutMenu"></div>
                    <span class="sdt_active"></span>
                    <span class="sdt_wrap">
                        <span class="sdt_link">About me</span>
                        <span class="sdt_descr"></span>
                    </span>
                </a>
            </li>
            <li>
                <a href="../Home/Portfolio">
                    <div class="menuImageContain portMenu"></div>
                    <span class="sdt_active"></span>
                    <span class="sdt_wrap">
                        <span class="sdt_link">Portfolio</span>
                        <span class="sdt_descr"></span>
                    </span>
                </a>
                @*<div class="sdt_box" style="position: relative;">
                    <span class="secondaryLinkArrow"></span><a class="secondaryLink" href="#">Website Design</a>
                    <span class="secondaryLinkArrow"></span><a class="secondaryLink " href="#">Application Design</a>
                    <span class="secondaryLinkArrow"></span><a class="secondaryLink" href="#">Print Design</a>
                    <span class="secondaryLinkArrow"></span><a class="secondaryLink" href="#">Corporate Identity</a>
                </div>*@
            </li>
            <li>
                <a href="../Home/CareerHistory">
                    <div class="menuImageContain workMenu"></div>
                    <span class="sdt_active"></span>
                    <span class="sdt_wrap">
                        <span class="sdt_link">Career History</span>
                        <span class="sdt_descr"></span>
                    </span>
                </a>
            </li>
            <li>
                <a href="../Home/Skills">
                    <div class="menuImageContain skillsMenu"></div>
                    <span class="sdt_active"></span>
                    <span class="sdt_wrap">
                        <span class="sdt_link">Skills</span>
                        <span class="sdt_descr"></span>
                    </span>
                </a>
            </li>
            <li>
                <a href="../Home/Contact">
                    <div class="menuImageContain contactMenu"></div>
                    <span class="sdt_active"></span>
                    <span class="sdt_wrap">
                        <span class="sdt_link">Contact</span>
                        <span class="sdt_descr"></span>
                    </span>
                </a>
            </li>
        </ul>
    </div>
</div>
<div class="homeContent" style="width: 100%;">
    <div class="row" style="max-width: 1140px;margin: 0 auto;">
        <div class="homeText">
            <p>
                Innovative, experienced and well-heeled Web/UI Designer and Front-end Developer, with proven track record of collaborative efforts with 
                marketing and business technology environments, and strong knowledge of current technology, design tools, and usability trends. Proven 
                expertise in the Front-end Development of websites and web-based applications from design (created or following) through the final cross-browser 
                experience. Possess a solid print portfolio, capable of designing innovative and compelling online market branding initiatives that can 
                move a company to the forefront of its market share. Seek a position as a Web Design/Front-end Development/User Interface role with a 
                company poised for extraordinary growth. 
            </p>
        </div>
    </div>
</div>
