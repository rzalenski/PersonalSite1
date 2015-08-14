@Code
    ViewData("Title") = "Contact"
End Code

<style type="text/css">
    tr label {
        color: #fff;
    }
    address {
        font: 15px/20px "Roboto", sans-serif;
	    color: #fff;
        padding: 20px 0 0 20px;
    }
</style>
<div class="homeContent" style="width: 100%; min-height: 320px;">
    <div style="max-width: 1140px; margin: 0 auto; color: #fff;">
        <div class="pageSubHeadContain">
            <div class="pageSubHead">
                @ViewData("Title")
            </div>
        </div>

        <address>
            111 Cagney Terrace<br />
            Leesburg, Virginia 20175
            <br /><br />
            E-Mail: <a href="mailto:bob.zalenski@gmail.com">bob.zalenski@gmail.com</a><br />
            Phone: 832-524-9909
            <br /><br />
        </address>

    </div>
</div>

