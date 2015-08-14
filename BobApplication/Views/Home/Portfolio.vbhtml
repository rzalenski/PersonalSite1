@Code
    ViewData("Title") = "Portfolio"
End Code

<style type="text/css">
    .nav-tabs {
      border-bottom: none;
    }
</style>

<div class="homeContent" style="width: 100%;">
    <div style="max-width: 1140px; margin: 0 auto;">
        <div class="pageSubHeadContain">
            <div class="pageSubHead">
                @ViewData("Title")
            </div>
        </div>
        <div id="elastic_grid"></div>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
        <script src="../Scripts/modernizr.custom.js"></script>
        <script src="../Scripts/classie.js"></script>
        <script type="text/javascript" src="../Scripts/elastic_grid.min.js"></script>
        <script type="text/javascript">
            $(function () {
                $("#elastic_grid").elastic_grid({
                    'showAllText': 'All',
                    'filterEffect': 'moveup', // moveup, scaleup, fallperspective, fly, flip, helix , popup
                    'hoverDirection': true,
                    'hoverDelay': 0,
                    'hoverInverse': false,
                    'expandingSpeed': 500,
                    'expandingHeight': 500,
                    'items':
                    [
                        {
                            'title': 'Bands.com<br /><span class="portClass">Website</span>',
                            'description': 'Bands.com was a property that was designed and developed at iREIT for all musicians to build profiles, showcase there music, etc.',
                            'thumbnail': ['../images/Portfolio/small/webBands_small.jpg', '../images/Portfolio/small/webBands2_small.jpg', '../images/Portfolio/small/webBands3_small.jpg', '../images/Portfolio/small/webBands4_small.jpg', '../images/Portfolio/small/webBands5_small.jpg', '../images/Portfolio/small/webBands6_small.jpg'],
                            'large': ['../images/Portfolio/large/webBands1_large.jpg', '../images/Portfolio/large/webBands2_large.jpg', '../images/Portfolio/large/webBands3_large.jpg', '../images/Portfolio/large/webBands4_large.jpg', '../images/Portfolio/large/webBands5_large.jpg', '../images/Portfolio/large/webBands6_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Advantis<br /><span class="portClass">Website</span>',
                            'description': 'A staffing agency in the healthcare sector.',
                            'thumbnail': ['../images/Portfolio/small/webAdvantis1_small.jpg', '../images/Portfolio/small/webAdvantis2_small.jpg'],
                            'large': ['../images/Portfolio/large/webAdvantis1_large.jpg', '../images/Portfolio/large/webAdvantis2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'David Powers Homes<br /><span class="portClass">Website</span>',
                            'description': 'A builder of fine homes located in the Houston area.',
                            'thumbnail': ['../images/Portfolio/small/webDp1_small.jpg'],
                            'large': ['../images/Portfolio/large/webDp1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'David Powers Motorsports<br /><span class="portClass">Website</span>',
                            'description': "NHRA top fuel racing team.",
                            'thumbnail': ['../images/Portfolio/small/webDpm1_small.jpg', '../images/Portfolio/small/webDpm2_small.jpg'],
                            'large': ['../images/Portfolio/large/webDpm1_large.jpg', '../images/Portfolio/large/webDpm2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Design Technics Corporation<br /><span class="portClass">Website</span>',
                            'description': "A petrochemical pipeline mapping company specializing in the Gulf Coast of the United States.",
                            'thumbnail': ['../images/Portfolio/small/webDtc1_small.jpg'],
                            'large': ['../images/Portfolio/large/webDtc1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Eagle Broadband Security<br /><span class="portClass">Website</span>',
                            'description': "Residential and commercial security monitoring.",
                            'thumbnail': ['../images/Portfolio/small/webEagle1_small.jpg'],
                            'large': ['../images/Portfolio/large/webEagle1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Excel Show Cattle<br /><span class="portClass">Website</span>',
                            'description': "Livestock producer located in Needville, Texas.",
                            'thumbnail': ['../images/Portfolio/small/webExcel1_small.jpg'],
                            'large': ['../images/Portfolio/large/webExcel1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Favorite.com<br /><span class="portClass">Website</span>',
                            'description': "One of the many premiere properties owned by iREIT, Favorite.com was built for news syndication.",
                            'thumbnail': ['../images/Portfolio/small/webFav1_small.jpg'],
                            'large': ['../images/Portfolio/large/webFav1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Gexa Energy (Residential)<br /><span class="portClass">Website</span>',
                            'description': "Electricity retailer in the state of Texas.",
                            'thumbnail': ['../images/Portfolio/small/webGexaResi1_small.jpg', '../images/Portfolio/small/webGexaResi2_small.jpg', '../images/Portfolio/small/webGexaResi3_small.jpg', '../images/Portfolio/small/webGexaResiLander1_small.jpg', '../images/Portfolio/small/webGexaResiLander2_small.jpg', '../images/Portfolio/small/webGexaResiOld1_small.jpg', '../images/Portfolio/small/webGexaBravo1_small.jpg'],
                            'large': ['../images/Portfolio/large/webGexaResi1_large.jpg', '../images/Portfolio/large/webGexaResi2_large.jpg', '../images/Portfolio/large/webGexaResi3_large.jpg', '../images/Portfolio/large/webGexaResiLander1_large.jpg', '../images/Portfolio/large/webGexaResiLander2_large.jpg', '../images/Portfolio/large/webGexaResiOld1_large.jpg', '../images/Portfolio/large/webGexaBravo1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Gexa Energy (Commercial)<br /><span class="portClass">Website</span>',
                            'description': "Electricity retailer in the state of Texas.",
                            'thumbnail': ['../images/Portfolio/small/webGexaComm1_small.jpg', '../images/Portfolio/small/webGexaComm2_small.jpg'],
                            'large': ['../images/Portfolio/large/webGexaComm1_large.jpg', '../images/Portfolio/large/webGexaComm2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Heartland Wildlife Ranches<br /><span class="portClass">Website</span>',
                            'description': 'An outfitter in Ethel, Missouri that facilitates hunts for whitetail deer, red stag, elk and turkey.',
                            'thumbnail': ['../images/Portfolio/small/webHeartland1_small.jpg', '../images/Portfolio/small/webHeartland2_small.jpg'],
                            'large': ['../images/Portfolio/large/webHeartland1_large.jpg', '../images/Portfolio/large/webHeartland2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Houston Fuel Oil Terminal Company<br /><span class="portClass">Website</span>',
                            'description': "Houston Fuel Oil Terminal Company is a leading marine terminal for storage of residual fuel oil and crude oil.",
                            'thumbnail': ['../images/Portfolio/small/webHfotco1_small.jpg'],
                            'large': ['../images/Portfolio/large/webHfotco1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Homeland International<br /><span class="portClass">Website</span>',
                            'description': "Homeland International's goal is to bring hope to Saharawi refugees through education and other long term sustainable development projects.",
                            'thumbnail': ['../images/Portfolio/small/webHomeland1_small.jpg', '../images/Portfolio/small/webHomeland2_small.jpg'],
                            'large': ['../images/Portfolio/large/webHomeland1_large.jpg', '../images/Portfolio/large/webHomeland2_large.jpg'],
                            'button_list':
                            [
                                { 'title': 'Website', 'url': 'http://homelandonline.org/', 'new_window': true }
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Internet Commerce Association<br /><span class="portClass">Website</span>',
                            'description': "A business organization made up of individuals and companies that own, buy, sell, resell, host and manage internet traffic which comes from search engines, domain names and internet links.",
                            'thumbnail': ['../images/Portfolio/small/webIca1_small.jpg'],
                            'large': ['../images/Portfolio/large/webIca1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Interloc Creative Solutions<br /><span class="portClass">Website</span>',
                            'description': "A firm dedicated to excellence in website design, development and corporate branding.",
                            'thumbnail': ['../images/Portfolio/small/webInterloc1_small.jpg'],
                            'large': ['../images/Portfolio/large/webInterloc1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Internet REIT<br /><span class="portClass">Website</span>',
                            'description': "An internet media company owning and managing high-quality highly-visited domain names.",
                            'thumbnail': ['../images/Portfolio/small/webIreit1_small.jpg'],
                            'large': ['../images/Portfolio/large/webIreit1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Logic Capital Management<br /><span class="portClass">Website</span>',
                            'description': 'Logic Capital Management, LLC is a comprehensive financial services firm committed to helping their clients improve their long-term financial success.',
                            'thumbnail': ['../images/Portfolio/small/webLogic1_small.jpg'],
                            'large': ['../images/Portfolio/large/webLogic1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'TrackSoftware.net<br /><span class="portClass">Website</span>',
                            'description': "Web-based software controls 100% of contractor charges for labor, equipment and materials.",
                            'thumbnail': ['../images/Portfolio/small/webMci1_small.jpg'],
                            'large': ['../images/Portfolio/large/webMci1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'NextEra Energy Services (Residential)<br /><span class="portClass">Website</span>',
                            'description': "Electricity retailer in the northeastern United States (Parent company of Gexa Energy).",
                            'thumbnail': ['../images/Portfolio/small/webNextResi1_small.jpg', '../images/Portfolio/small/webNextResi2_small.jpg', '../images/Portfolio/small/webNextResi3_small.jpg'],
                            'large': ['../images/Portfolio/large/webNextResi1_large.jpg', '../images/Portfolio/large/webNextResi2_large.jpg', '../images/Portfolio/large/webNextResi3_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'NextEra Energy Services (Commercial)<br /><span class="portClass">Website</span>',
                            'description': "Electricity retailer in the northeastern United States (Parent company of Gexa Energy).",
                            'thumbnail': ['../images/Portfolio/small/webNextComm1_small.jpg', '../images/Portfolio/small/webNextComm2_small.jpg'],
                            'large': ['../images/Portfolio/large/webNextComm1_large.jpg', '../images/Portfolio/large/webNextComm2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Operas.com<br /><span class="portClass">Website</span>',
                            'description': "One of the many premiere properties owned by iREIT. This was a Wordpress template that I designed.",
                            'thumbnail': ['../images/Portfolio/small/webOperas1_small.jpg'],
                            'large': ['../images/Portfolio/large/webOperas1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'AmericanRevolution.com<br /><span class="portClass">Website</span>',
                            'description': "One of the many premiere properties owned by iREIT.",
                            'thumbnail': ['../images/Portfolio/small/webRevolution1_small.jpg'],
                            'large': ['../images/Portfolio/large/webRevolution1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Darrell Russell<br /><span class="portClass">Website</span>',
                            'description': "A website dedicated to NHRA top fuel racer, Darrell Russell, by his family.",
                            'thumbnail': ['../images/Portfolio/small/webRussell1_small.jpg', '../images/Portfolio/small/webRussell2_small.jpg'],
                            'large': ['../images/Portfolio/large/webRussell1_large.jpg', '../images/Portfolio/large/webRussell2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Unified Resources, Inc.<br /><span class="portClass">Website</span>',
                            'description': "A marketing firm specializing in marketing strategies for products and services that go to market through channel partners.",
                            'thumbnail': ['../images/Portfolio/small/webUr1_small.jpg', '../images/Portfolio/small/webUr2_small.jpg'],
                            'large': ['../images/Portfolio/large/webUr1_large.jpg', '../images/Portfolio/large/webUr2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'UR International<br /><span class="portClass">Website</span>',
                            'description': "A Texas-based software development and IT consulting group.",
                            'thumbnail': ['../images/Portfolio/small/webUri1_small.jpg'],
                            'large': ['../images/Portfolio/large/webUri1_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'URI Technology Solutions<br /><span class="portClass">Website</span>',
                            'description': "A software development and IT consulting group (A subsidiary of Unified Resources, Inc.).",
                            'thumbnail': ['../images/Portfolio/small/webUriTech1_small.jpg', '../images/Portfolio/small/webUriTech2_small.jpg'],
                            'large': ['../images/Portfolio/large/webUriTech1_large.jpg', '../images/Portfolio/large/webUriTech2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Websites']
                        },
                        {
                            'title': 'Peridot (Gexa Energy)<br /><span class="portClass">User Interface</span>',
                            'description': "Gexa Energy's internal application used for customer document administration.",
                            'thumbnail': ['../images/Portfolio/small/uiGexaPeridot_small.jpg', '../images/Portfolio/small/uiGexaPeridotLogin_small.jpg'],
                            'large': ['../images/Portfolio/large/uiGexaPeridot_large.jpg', '../images/Portfolio/large/uiGexaPeridotLogin_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['User Interface']
                        },
                        {
                            'title': 'Gexa Energy<br /><span class="portClass">User Interface</span>',
                            'description': "This application was the precursor to Peridot.",
                            'thumbnail': ['../images/Portfolio/small/uiGexaCME_small.jpg', '../images/Portfolio/small/uiGexaCMELogin_small.jpg'],
                            'large': ['../images/Portfolio/large/uiGexaCME_large.jpg', '../images/Portfolio/large/uiGexaCMELogin_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['User Interface']
                        },
                        {
                            'title': 'Gexa Energy (Promo Wizard)<br /><span class="portClass">User Interface</span>',
                            'description': "This application was used by the marketing department to create promotions associated with power plans.",
                            'thumbnail': ['../images/Portfolio/small/uiGexaPromo1_small.jpg', '../images/Portfolio/small/uiGexaPromo2_small.jpg'],
                            'large': ['../images/Portfolio/large/uiGexaPromo1_large.jpg', '../images/Portfolio/large/uiGexaPromo2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['User Interface']
                        },
                        {
                            'title': 'Axiom (iREIT)<br /><span class="portClass">User Interface</span>',
                            'description': "This application was used to manage the company's 400,000 domains.",
                            'thumbnail': ['../images/Portfolio/small/uiAxiom1_small.jpg', '../images/Portfolio/small/uiAxiom2_small.jpg', '../images/Portfolio/small/uiAxiomDash_small.jpg', '../images/Portfolio/small/uiAxiomLogin1_small.jpg', '../images/Portfolio/small/uiAxiomLogin2_small.jpg'],
                            'large': ['../images/Portfolio/large/uiAxiom1_large.jpg', '../images/Portfolio/large/uiAxiom2_large.jpg', '../images/Portfolio/large/uiAxiomDash_large.jpg', '../images/Portfolio/large/uiAxiomLogin1_large.jpg', '../images/Portfolio/large/uiAxiomLogin2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['User Interface']
                        },
                        {
                            'title': 'David Powers Homes<br /><span class="portClass">User Interface</span>',
                            'description': "This application was designed and built for use on a tablet. It was used by the Design Center staff to assist homebuyers in choosing interior decor.",
                            'thumbnail': ['../images/Portfolio/small/uiDP_small.jpg', '../images/Portfolio/small/uiDPLogin_small.jpg'],
                            'large': ['../images/Portfolio/large/uiDP_large.jpg', '../images/Portfolio/large/uiDPLogin_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['User Interface']
                        },
                        {
                            'title': 'Commander (iVita)<br /><span class="portClass">User Interface</span>',
                            'description': "This application was iVita's flagship, web-based application. The business model was to track a company's assets to determine whether their existence was profitable. Larger industries were targeted and the idea was a good one, just at a bad time. This was in 2000 when technology-related venture capital funding was being eliminated nationwide.",
                            'thumbnail': ['../images/Portfolio/small/uiCommander1_small.jpg', '../images/Portfolio/small/uiCommanderLogin_small.jpg', '../images/Portfolio/small/uiCommanderThin_small.jpg'],
                            'large': ['../images/Portfolio/large/uiCommander1_large.jpg', '../images/Portfolio/large/uiCommanderLogin_large.jpg', '../images/Portfolio/large/uiCommanderThin_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['User Interface']
                        },
                        {
                            'title': 'Magellan K-12 (A.P.P.L.E.)<br /><span class="portClass">User Interface</span>',
                            'description': "'Assessment Program for Performance Learning Environments' was used to track and assess assets related to schools. Details included: equipment, buildings, deficiencies, etc.",
                            'thumbnail': ['../images/Portfolio/small/uiApple_small.jpg', '../images/Portfolio/small/uiAppleStartup_small.jpg'],
                            'large': ['../images/Portfolio/large/uiApple_large.jpg', '../images/Portfolio/large/uiAppleStartup_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['User Interface']
                        },
                        {
                            'title': 'Web Control (Interloc)<br /><span class="portClass">User Interface</span>',
                            'description': "This was Interloc's content management system that was offered as an upsell to clients.",
                            'thumbnail': ['../images/Portfolio/small/uiWC1_small.jpg', '../images/Portfolio/small/uiWC2_small.jpg'],
                            'large': ['../images/Portfolio/large/uiWC1_large.jpg', '../images/Portfolio/large/uiWC2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['User Interface']
                        },
                        {
                            'title': '12 Oaks Hospital<br /><span class="portClass">Graphic Design</span>',
                            'description': "Posters and invitations for events. A nostaglic theme was selected.",
                            'thumbnail': ['../images/Portfolio/small/graphicTwelve1_small.jpg', '../images/Portfolio/small/graphicTwelve2_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicTwelve1_large.jpg', '../images/Portfolio/large/graphicTwelve2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'BJ Services<br /><span class="portClass">Graphic Design</span>',
                            'description': "An agenda booklet for VIPs that was printed on the finest coverstock. It was sized appropriately to be inserted into the invitation package which was a wooden box of cigars that contained other goodies including airfare to the conference in Stressa, Italy. What more can you expect from an oil and gas giant?",
                            'thumbnail': ['../images/Portfolio/small/graphicBJ_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicBJ_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Burr Wolff & Associates<br /><span class="portClass">Graphic Design</span>',
                            'description': "Brochure for a property tax consultancy based in Houston, Texas.",
                            'thumbnail': ['../images/Portfolio/small/graphicBurr_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicBurr_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Design Technics Corporation<br /><span class="portClass">Graphic Design</span>',
                            'description': "The cover for DTC's popular Gulf Coast Industrial Handbook. The handbook features detailed information about pipeline contents, routes, facility information as well as details of industrial hubs along the gulf coast.",
                            'thumbnail': ['../images/Portfolio/small/graphicDTCHand1_small.jpg', '../images/Portfolio/small/graphicDTCHand2_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicDTCHand1_large.jpg', '../images/Portfolio/large/graphicDTCHand2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Gexa Energy<br /><span class="portClass">Graphic Design</span>',
                            'description': "Many projects came my way during my time with Gexa Energy. My initial and primary role with the company was to work with the development team to consolidate the many internal applications into a branded, usable platform. The second was to do the same for the corporate websites. There were other projects needed by the company in which I offered my expertise. Projects such as: bill inserts, various posters for human resources, trade show graphics, newsletters, t-shirt designs, etc.",
                            'thumbnail': ['../images/Portfolio/small/graphicGexaBill1_small.jpg', '../images/Portfolio/small/graphicGexaBill2_small.jpg', '../images/Portfolio/small/graphicGexaNews1_small.jpg', '../images/Portfolio/small/graphicGexaNews2_small.jpg', '../images/Portfolio/small/graphicGexaPosters1_small.jpg', '../images/Portfolio/small/graphicGexaPosters2_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicGexaBill1_large.jpg', '../images/Portfolio/large/graphicGexaBill2_large.jpg', '../images/Portfolio/large/graphicGexaNews1_large.jpg', '../images/Portfolio/large/graphicGexaNews2_large.jpg', '../images/Portfolio/large/graphicGexaPosters1_large.jpg', '../images/Portfolio/large/graphicGexaPosters2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Memorial Hermann Healthcare System<br /><span class="portClass">Graphic Design</span>',
                            'description': "Physician's Advance: A quarterly, internal publication showcasing the technological advances of the Memorial Hermann Healthcare System.",
                            'thumbnail': ['../images/Portfolio/small/graphicHermann1_small.jpg', '../images/Portfolio/small/graphicHermann2_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicHermann1_large.jpg', '../images/Portfolio/large/graphicHermann2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Apollo<br /><span class="portClass">Graphic Design</span>',
                            'description': "An inforgraphic (partial shown) that illustrates the functionality of Apollo's revolutionary IDS Decision Engine.",
                            'thumbnail': ['../images/Portfolio/small/graphicApollo_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicApollo_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'David Powers Motorsports<br /><span class="portClass">Graphic Design</span>',
                            'description': "David Powers Motorsports was an NHRA Top Fuel team featuring 'Hot' Rod Fuller as their driver. These designs were proposed to potential cheif sponsors: U.S. Navy, Remax, Valvoline and 84 Lumber.",
                            'thumbnail': ['../images/Portfolio/small/graphicDPM1_small.jpg', '../images/Portfolio/small/graphicDPM2_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicDPM1_large.jpg', '../images/Portfolio/large/graphicDPM2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Delo (Chevron)<br /><span class="portClass">Graphic Design</span>',
                            'description': "Chevron was a longtime client of Unified Resources, Delo specifically. Many products were created for their marketing department. These were among many.",
                            'thumbnail': ['../images/Portfolio/small/graphicDeloBro_small.jpg', '../images/Portfolio/small/graphicDeloSalesKit_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicDeloBro_large.jpg', '../images/Portfolio/large/graphicDeloSalesKit_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Enersoft<br /><span class="portClass">Graphic Design</span>',
                            'description': "An invitation to the premiere of Enersoft Corporation's Channel 4. Channel 4 was an electronic bulletin board (EBB) that allowed companies to trade natural gas and pipeline capacity in the United States and Canada via a single system. Revolutionary for the time.",
                            'thumbnail': ['../images/Portfolio/small/graphicEnersoft_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicEnersoft_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'iREIT<br /><span class="portClass">Graphic Design</span>',
                            'description': "An internal inforgraphic (partial views shown) for investors to describe the relational concept between iREIT's internet properties and the potential click traffic.",
                            'thumbnail': ['../images/Portfolio/small/graphicIREITInfographic1_small.jpg', '../images/Portfolio/small/graphicIREITInfographic2_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicIREITInfographic1_large.jpg', '../images/Portfolio/large/graphicIREITInfographic2_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Wisenbaker<br /><span class="portClass">Graphic Design</span>',
                            'description': "A brochure for a supplier of building materials in Houston, Texas.",
                            'thumbnail': ['../images/Portfolio/small/graphicWisenbaker_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicWisenbaker_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Continental Airlines<br /><span class="portClass">Graphic Design</span>',
                            'description': "The March of Dimes Walk America event has lots of sponsors. I did this design for Continental Airlines, a client of Unified Resources. This was voted the number one sponsor t-shirt.",
                            'thumbnail': ['../images/Portfolio/small/graphicWalkAmerica_small.jpg'],
                            'large': ['../images/Portfolio/large/graphicWalkAmerica_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Graphic Design']
                        },
                        {
                            'title': 'Homeland International<br /><span class="portClass">Corporate Identity</span>',
                            'description': "Homeland International's goal is to bring hope to Saharawi refugees through education and other long term sustainable development projects.",
                            'thumbnail': ['../images/Portfolio/small/homeland_small.jpg'],
                            'large': ['../images/Portfolio/large/homeland_large.jpg'],
                            'button_list':
                            [
                                { 'title': 'Website', 'url': 'http://homelandonline.org/', 'new_window': true }
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Logic Capital Management<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'Logic Capital Management, LLC is a comprehensive financial services firm committed to helping their clients improve their long-term financial success.',
                            'thumbnail': ['../images/Portfolio/small/logic_small.jpg'],
                            'large': ['../images/Portfolio/large/logic_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Interloc Creative Solutions<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'A firm dedicated to excellence in website design, development and corporate branding.',
                            'thumbnail': ['../images/Portfolio/small/interloc_small.jpg'],
                            'large': ['../images/Portfolio/large/interloc_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Texas Country Music Association<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'An organization established to celebrate country music in Texas.',
                            'thumbnail': ['../images/Portfolio/small/txcma_small.jpg'],
                            'large': ['../images/Portfolio/large/txcma_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'URI Now<br /><span class="portClass">Corporate Identity</span>',
                            'description': "An identity created as the cornerstone of a Unified Resources' pitch to Continental Airlines to acquire the 'OnePass' account. The design was to resemble that of an airline.",
                            'thumbnail': ['../images/Portfolio/small/urinow_small.jpg'],
                            'large': ['../images/Portfolio/large/urinow_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Enerlutions<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'An energy management firm.',
                            'thumbnail': ['../images/Portfolio/small/ener_small.jpg'],
                            'large': ['../images/Portfolio/large/ener_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Brawner Paper Company<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'Brawner Paper had been in business for several decades when they decided to strengthen their identity. Their primary business is the distribution of products related to commercial bathrooms. This project was very interesting. I was handed 12 thermographed business cards from them that were all straight from 1973... and all completely different. The only thing they had in common was a Frederick Remington-esque bronco as the focal point, more of a blob of ink. I decided to use the bronco to maintain the heritage and give it a true western feel.',
                            'thumbnail': ['../images/Portfolio/small/brawner_small.jpg'],
                            'large': ['../images/Portfolio/large/brawner_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'SRO Sports Bar and Cafe<br /><span class="portClass">Corporate Identity</span>',
                            'description': "SRO was opening a new location in an old movie theater in Houston's Westchase district that featured multiple bars, cigar bar, coffee bar, televisions in each booth... you name it. They wanted a colorful graphic logo that resembled the existing logo and that would translate well to neon signage.",
                            'thumbnail': ['../images/Portfolio/small/sro_small.jpg'],
                            'large': ['../images/Portfolio/large/sro_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Lake Conroe Lions Club<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'This logo was created for their 4th Annual Team Bass Tournament. Being a very well-known lake in the state of Texas, Lake Conroe, a Texan theme was used.',
                            'thumbnail': ['../images/Portfolio/small/lions_small.jpg'],
                            'large': ['../images/Portfolio/large/lions_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Bands.com<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'A website identity for Bands.com.',
                            'thumbnail': ['../images/Portfolio/small/bands_small.jpg'],
                            'large': ['../images/Portfolio/large/bands_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'iDeaStarter<br /><span class="portClass">Corporate Identity</span>',
                            'description': "A firm that focused on bringing clients' ideas to fruition.",
                            'thumbnail': ['../images/Portfolio/small/idea_small.jpg'],
                            'large': ['../images/Portfolio/large/idea_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Heartland Wildlife Ranches<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'An outfitter in Ethel, Missouri that facilitates hunts for whitetail deer, red stag, elk and turkey.',
                            'thumbnail': ['../images/Portfolio/small/heartland_small.jpg'],
                            'large': ['../images/Portfolio/large/heartland_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Axiom<br /><span class="portClass">Corporate Identity</span>',
                            'description': "Identity for iREIT's internal application used for tracking the company's domain portfolio.",
                            'thumbnail': ['../images/Portfolio/small/axiom_small.jpg'],
                            'large': ['../images/Portfolio/large/axiom_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Peridot<br /><span class="portClass">Corporate Identity</span>',
                            'description': "Identity for Gexa Energy's internal application used for customer document administration.",
                            'thumbnail': ['../images/Portfolio/small/peri_small.jpg'],
                            'large': ['../images/Portfolio/large/peri_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Sapphire<br /><span class="portClass">Corporate Identity</span>',
                            'description': "Identity for Gexa Energy's internal application used for energy pricing.",
                            'thumbnail': ['../images/Portfolio/small/sapp_small.jpg'],
                            'large': ['../images/Portfolio/large/sapp_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'SyMet<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'A website identity for an online medical reference directory.',
                            'thumbnail': ['../images/Portfolio/small/symet_small.jpg'],
                            'large': ['../images/Portfolio/large/symet_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'WebControl<br /><span class="portClass">Corporate Identity</span>',
                            'description': "An identity for Interloc Creative's content management system.",
                            'thumbnail': ['../images/Portfolio/small/webcontrol_small.jpg'],
                            'large': ['../images/Portfolio/large/webcontrol_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'YourHeartScore.com<br /><span class="portClass">Corporate Identity</span>',
                            'description': 'Identity for an online property.',
                            'thumbnail': ['../images/Portfolio/small/heart_small.jpg'],
                            'large': ['../images/Portfolio/large/heart_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'InterAct<br /><span class="portClass">Corporate Identity</span>',
                            'description': "This company was a project of Interloc Creative Solutions that was a rewards program for restaurants in the Houston area.",
                            'thumbnail': ['../images/Portfolio/small/interact_small.jpg'],
                            'large': ['../images/Portfolio/large/interact_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Advantis<br /><span class="portClass">Corporate Identity</span>',
                            'description': "A staffing agency in the healthcare sector.",
                            'thumbnail': ['../images/Portfolio/small/advan_small.jpg'],
                            'large': ['../images/Portfolio/large/advan_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        },
                        {
                            'title': 'Excel Show Cattle<br /><span class="portClass">Corporate Identity</span>',
                            'description': "Identity for a livestock producer in Needville, Texas.",
                            'thumbnail': ['../images/Portfolio/small/excel_small.jpg'],
                            'large': ['../images/Portfolio/large/excel_large.jpg'],
                            'button_list':
                            [
                            ],
                            'tags': ['Corporate Identity']
                        }

                    ]
                });
            });
        </script>
    </div>
</div>
