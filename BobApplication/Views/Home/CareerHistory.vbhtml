@Code
    ViewData("Title") = "Career History"
End Code

<script type="text/javascript" src="../Scripts/jquery.timeline.js"></script>
<script type="text/javascript">
    $(window).load(function () {
        $('.tl1').timeline({
            'openTriggerClass': '.view_role',
            'categories': ['1988', '1989', '1990', '1991', '1992', '1993', '1994', '1995', '1996', '1997', '1998', '1999', '2000', '2001', '2002', '2003', '2004', '2005', '2006', '2007', '2008', '2009', '2010', '2011', '2012', '2013', '2014', '2015'],
            'nuberOfSegments': [12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12],
            'startItem': 'first',
            'itemMargin': 16,
            'closeText': 'X'
        });
    });

</script>
<div class="homeContent" style="width: 100%;">
    <div style="max-width: 1140px; margin: 0 auto; padding-bottom: 40px;">
        <div class="pageSubHeadContain">
            <div class="pageSubHead">
                @ViewData("Title")
            </div>
        </div>
        <div class="timelineLoader">
            <img src="../images/Timeline/timeline/loadingAnimation.gif" />
        </div>

        <div class="timelineFlat tl1">
            <div class="item" style="height: 430px" data-id="01/1988" data-name="" data-description="AIH">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/aihPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">The Art Institute of Houston</span>
                        <span class="location" style="margin: 2px 0 10px 0 !important;">Houston, Texas</span>
                        <span style="float: left; width: 100%;padding-top: 30px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">June 1988 - June 1990</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="01/1988">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="01/1988">
                <div class="item_open_content">
                    <div class="innerContent">
                        <span class="detailsSubhead">A.A., Visual Communications - 1990</span>
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="01/1991" data-name="" data-description="Adgraph">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/adgraphPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">Adgraph Design Group</span>
                        <span class="position">Assistant Art Director</span>
                        <span class="location">Houston, Texas</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">June 1991 - June 1993</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="01/1991">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="01/1991">
                <div class="item_open_content">
                    <div class="innerContent">
                        Responsibilities included the design and production of corporate brochures, adslicks, advertisements, magazine layouts and package designs.
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="09/1993" data-name="" data-description="DTC">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/dtcPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">Design Technics Corporation</span>
                        <span class="position">Graphic Designer/Web Designer</span>
                        <span class="location">Houston, Texas</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">September 1993 - April 1999</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="09/1993">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="09/1993">
                <div class="item_open_content">
                    <div class="innerContent">
                        <div class="detailsSubhead">Role</div>
                        <ul style="list-style: square;">
                            <li>Designed and produced websites, corporate brochures, corporate identities, custom invitations, outdoor media, advertisements, courtroom graphics and assorted print collateral.</li>
                            <li>Assisted a sister company, DTC Cartographic Services, in the enhancement of cartographic pipeline data for print.</li>
                            <li>Work within a team environment. Responsible for all design.</li>
                        </ul>
                        <div class="detailsSubhead">Technologies</div>
                        Photoshop, Illustrator, CSS, HTML, Acrobat Professional, Javascript, Powerpoint
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="04/1999" data-name="" data-description="iVita">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/ivitaPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">iVita Corporation</span>
                        <span class="position">Web Designer/User Interface Designer </span>
                        <span class="location">Houston, Texas</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">April 1999 - July 2000</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="04/1999">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="04/1999">
                <div class="item_open_content">
                    <div class="innerContent">
                        <div class="detailsSubhead">Role</div>
                        <ul style="list-style: square;">
                            <li>Designed and developed (front-end) websites/web applications using HTML, CSS, Allaire HomeSite (Dreamweaver) and Flash.</li>
                            <li>Designed and developed (front-end) the corporate intranet.</li>
                            <li>Produced icons for the primary online application.</li>
                            <li>Designed and developed (front-end) the primary online application – Thin client and desktop.</li>
                            <li>Designed Flash interactives for the corporate website.</li>
                            <li>Designed assorted illustrations for documents and corporate collateral.</li>
                            <li>Work within a team environment. Responsible for all design.</li>
                        </ul>
                        <div class="detailsSubhead">Technologies</div>
                        Photoshop, Illustrator, Allaire HomeSite (Dreamweaver), Flash, CSS, DHTML, HTML, Acrobat Professional, Javascript, Powerpoint
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="07/2000" data-name="" data-description="Interloc">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/interlocPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">Interloc Creative Solutions</span>
                        <span class="position">Director of Creative Services</span>
                        <span class="location">Houston, Texas</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">July 2000 - June 2004</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="07/2000">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="07/2000">
                <div class="item_open_content">
                    <div class="innerContent">
                        <div class="detailsSubhead">Role</div>
                        <ul style="list-style: square;">
                            <li>Designed and developed (front-end) websites/web applications using HTML, CSS, Allaire HomeSite (Dreamweaver) and Flash.</li>
                            <li>Designed high-end print collateral such as brochures, corporate identities (logos), corporate collateral, presentations, tradeshow graphics.</li>
                            <li>Responsible for all design.</li>
                        </ul>
                        <div class="detailsSubhead">Technologies</div>
                        Photoshop, Illustrator, Allaire HomeSite (Dreamweaver), Flash, CSS, DHTML, HTML, Acrobat Professional, Javascript, Powerpoint
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="06/2004" data-name="" data-description="URI">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/uriPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">Unified Resources, Inc.</span>
                        <span class="position">Art Director</span>
                        <span class="location">Houston, Texas</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">June 2004 - July 2006</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="06/2004">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="06/2004">
                <div class="item_open_content">
                    <div class="innerContent">
                        Acted as team lead for website and user interface design as well as print design. Front-end development.
                        <br /><br />
                        <div class="detailsSubhead">Role</div>
                        <ul style="list-style: square;">
                            <li>Designed and developed (front-end) websites and web applications using HTML, DHTML, CSS, Allaire HomeSite (Dreamweaver), Image Ready and Flash.</li>
                            <li>Designed high-end print collateral such as brochures, corporate identities (logos), corporate collateral, presentations, tradeshow graphics using Adobe Photoshop, Adobe Illustrator and Flash.</li>
                            <li>Designed and developed custom e-mail templates in HTML, DHTML and CSS.</li>
                            <li>Designed custom Power Point presentations using embedded Flash.</li>
                            <li>Work within an agency environment.</li>
                            <li>Within two weeks of employment developed a complete presentation identity with flash-enabled Powerpoint presentation pitching the Continental OnePass account.</li>
                        </ul>
                        <div class="detailsSubhead">Technologies</div>
                        Photoshop, Illustrator, Dreamweaver, Flash, CSS, DHTML, HTML, Acrobat Professional
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="07/2006" data-name="" data-description="iREIT">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/ireitPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">iREIT</span>
                        <span class="position">Senior Web Designer</span>
                        <span class="location">Houston, Texas</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">July 2006 - July 2007</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="07/2006">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="07/2006">
                <div class="item_open_content">
                    <div class="innerContent">
                        Designed and developed (front-end) highly targeted websites - large scale sites with premium domain names, therefore increasing the value of the
                        domain for marketability. Designed many other smaller sites that were a key role to increasing the monetization of iREITs outstanding portfolio
                        of domains as well as the corporate web presence. Designed the look and feel and identity of internal applications as well as the front-end development.
                        <br /><br />
                        <div class="detailsSubhead">Role</div>
                        <ul style="list-style: square;">
                            <li>Designed and developed (front-end) different web pages using HTML, DHTML and CSS.</li>
                            <li>Developed web pages/internal applications using the Dreamweaver.</li>
                            <li>Designed web pages/internal applications using Photoshop, Image Ready, Illustrator and Flash.</li>
                            <li>Worked closely with application development leads to create the look and feel of the internal applications, performed the front-end development in DHTML. Templates were transferred to PHP by the development team.</li>
                            <li>Developed custom Wordpress templates.</li>
                            <li>Designed infographics that illustrated the growth and vision of iREIT for the board of directors and investors.</li>
                            <li>Created numerous identities (logos) for internal applications as well as websites using Adobe Photoshop and Adobe Illustrator.</li>
                            <li>Designed corporate presentations, advertisements, white papers and other corporate collateral using Adobe Photoshop and Adobe Illustrator.</li>
                            <li>Worked within a team environment. Responsible for all design.</li>
                        </ul>
                        <div class="detailsSubhead">Technologies</div>
                        Photoshop, Illustrator, Dreamweaver, Flash, CSS, DHTML, HTML, PHP, Acrobat Professional, Javascript Libraries (JQuery, Prototype), Powerpoint, Wordpress
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="07/2007" data-name="" data-description="Gexa">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/gexaPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">Gexa Energy</span>
                        <span class="position">Web Content Design Analyst</span>
                        <span class="location">Houston, Texas</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">July 2007 - May 2012</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="07/2007">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="07/2007">
                <div class="item_open_content">
                    <div class="innerContent">
                        Worked with the development team to create usability enhancements, perform the front-end development and create brand identity of the internal applications.
                        Extensive work designing, developing (front-end) and supporting the corporate websites (Gexa Energy and NextEra Energy Services), intranet, landing pages,
                        the residential online enrollment form as well as online customer care, designing sales presentations as well as internal and external marketing promotions.
                        <br /><br />
                        <div class="detailsSubhead">Role</div>
                        <ul style="list-style: square;">
                            <li>Created band awareness and usability enhancement features of internal and public applications.</li>
                            <li>Performed innovative and creative design, front-end development and support of corporate Website and Intranet in HTML, DHTML, ASP.Net, CSS and Flash.</li>
                            <li>Designed numerous identities for applications developed using Adobe Photoshop and  Adobe Illustrator.</li>
                            <li>Designed and developed custom e-mail templates in HTML, DHTML and CSS.</li>
                            <li>Developed compelling sales presentations, landing pages and internal/external marketing promotions that captured client interests and imagination.</li>
                            <li>Strategically tracked and promoted the company’s online presence and reach to residential and commercial customers via Google Adsense.</li>
                            <li>Worked on application screens and developed professional and dynamic user interfaces using Adobe Photoshop, CSS and HTML within ASP.Net.</li>
                            <li>Worked extensively on creating cross-browser complaint screens supporting different browsers and designing stylesheets, ids and classes as needed.</li>
                            <li>Responsible for creation of prototypes, page templates, using Photoshop, Illustrator, Flash, Visual Studio and CSS.</li>
                            <li>Worked closely with application developers and business analysts to come up with user- friendly web interface, flow of application (wireframes), detailed mocks then front-end development.</li>
                            <li>Converting wireframes to layouts, using HTML, CSS, DHTML, JavaScript and JS libraries to enhance user experience without using Flash.</li>
                            <li>Designed high-end print collateral such as brochures, corporate collateral, presentations and tradeshow graphics.</li>
                            <li>Initially hired by the Business Technology group to tie together the multiple internal applications with usability as well as look & feel. Maintained this role although classified under Marketing.</li>
                            <li>Created tableless CSS formatted sites.</li>
                            <li>Introduction to Cross-browser implementation (writing CSS exceptions).</li>
                            <li>Worked within a team environment. Responsible for all design.</li>
                        </ul>
                        <div class="detailsSubhead">Technologies</div>
                        Photoshop, Illustrator, Dreamweaver, Flash, CSS, DHTML, HTML, .Net, Acrobat Professional, Visual Studio, VSS, Javascript Libraries (jQuery, Prototype),
                        Powerpoint; Cross-browser Implementation (CSS exception)
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="06/2011" data-name="" data-description="Schlumberger">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/schlumbergerPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">Schlumberger Oilfield Services, Inc.</span>
                        <span class="position">Sitecore Contractor (Consultant)</span>
                        <span class="location">Sugar Land, Texas</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">June 2011 - January 2012</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="06/2011">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="06/2011">
                <div class="item_open_content">
                    <div class="innerContent">
                        Primary task was to create online product information through the Sitecore CMS system due to major acquisitions by Schlumberger. Was utilized
                        to design of the homepage of the U.S. career website.
                        <br /><br />
                        <div class="detailsSubhead">Role</div>
                        <ul style="list-style: square;">
                            <li>Administered internal and external Website content and Website templates within Sitecore.</li>
                            <li>Design and front-end development of webpages within the look and feel of the Schlumberger color scheme.</li>
                        </ul>
                        <div class="detailsSubhead">Technologies</div>
                        Photoshop, Illustrator, Dreamweaver, CSS, DHTML, HTML, Sitecore
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="03/2012" data-name="" data-description="Gannett">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/gannettPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">Gannett</span>
                        <span class="position">Front End Development (Consultant)</span>
                        <span class="location">McLean, Virginia</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">March 2012 - November 2012</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="03/2012">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="03/2012">
                <div class="item_open_content">
                    <div class="innerContent">
                        <div class="detailsSubhead">Role</div>
                        <ul style="list-style: square;">
                            <li>Worked on application screens/modules and developed professional and dynamic user interfaces using CSS, HTML, JavaScript and jQuery.</li>
                            <li>Worked extensively on creating cross-browser complaint screens supporting different browsers and designing stylesheets, ids and selectors as needed.</li>
                            <li>Responsible for creation of prototypes, page templates, using Photoshop, Illustrator, Visual Studio, stylesheets and coding conventions. Solid tableless solutions and advanced CSS to speed up content delivery leading to a decrease in bandwidth usage and cross-browser/cross-platform functionality.</li>
                            <li>Customized Telerik user controls (.Net) with extensive CSS customization, also creating custom Telerik user control skins.</li>
                            <li>Worked within DotNetNuke, creating custom skins and implementing them.</li>
                            <li>Worked closely with application developers and business analysts to come up with user- friendly web interface, performance oriented code.</li>
                            <li>Converting wireframes to tableless layouts, using HTML, CSS, DHTML, Unobtrusive JavaScript.</li>
                            <li>Utilized jQuery to substitute classes and alter the presentation of dynamic data.</li>
                            <li>Worked to support and restore stylesheets, ids and selectors that were consequently overwritten by the team during product development.</li>
                        </ul>
                        <div class="detailsSubhead">Technologies</div>
                        Photoshop, Illustrator, CSS, DHTML, HTML, .Net, Visual Studio, Git, Javascript (jQuery); Cross-browser Implementation (CSS); DotNetNuke; Telerik User Controls
                    </div>
                </div>
            </div>

            <div class="item" style="height: 430px" data-id="11/2012" data-name="" data-description="TTC">
                <div class="imageContain">
                    <img src="../images/Timeline/timeline/ttcPhoto.jpg" height="286">
                </div>
                <div class="imageContainDecription">
                    <span class="imageContainSpan">
                        <span class="institution">The Teaching Company</span>
                        <span class="position">Front End Development</span>
                        <span class="location">Chantilly, Virginia</span>
                        <span style="float: left; width: 100%;padding-top: 16px;">
                            <span style="float: left; width: 67%;">
                                <span class="workDateSeparator"></span>
                                <span class="workDate">November 2012 - Present</span>
                            </span>
                            <span style="float: right;" class="view_role" data-id="11/2012">View Details</span>
                        </span>
                    </span>
                </div>
            </div>
            <div class="item_open" data-id="11/2012">
                <div class="item_open_content">
                    <div class="innerContent">
                        <div class="detailsSubhead">Role</div>
                        <ul style="list-style: square;">
                            <li>Worked on page screens and developed professional and dynamic user interfaces using CSS, HTML, JavaScript and jQuery.</li>
                            <li>Worked extensively on creating cross-browser complaint screens supporting different browsers and designing stylesheets, ids and selectors as needed.</li>
                            <li>Responsible for the conversion of supplied artwork to tableless solutions along with advanced CSS, HTML, DHTML and JavaScript. to speed up content delivery leading to a decrease in bandwidth usage and cross-browser/cross-platform functionality.</li>
                            <li>Worked closely with the web development team to come up with well-organized performance oriented code.</li>
                            <li>Utilized jQuery to substitute classes and alter the presentation of dynamic data.</li>
                            <li>Worked toward a conversion of the existing website framework to a HTML5/CSS3 responsive solution.</li>
                            <li>Utilized multi-platform (mobile/tablet) compatability through CSS/jQuery media queries.</li>
                        </ul>
                        <div class="detailsSubhead">Technologies</div>
                        Photoshop, CSS, DHTML, HTML5, CSS3, .Net (VB), Visual Studio, Javascript (jQuery); Cross-browser Implementation (CSS/jQuery)
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>
