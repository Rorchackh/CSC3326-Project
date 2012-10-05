<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultHeader.ascx.cs" Inherits="DefaultHeader" %>
<script type="text/javascript" src="swfobject.js"></script>
<div id="art-flash-area">
<div id="art-flash-container">
<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="900" height="225" id="art-flash-object">
    <param name="movie" value="images/flash.swf" />
    <param name="quality" value="high" />
	<param name="scale" value="exactfit" />
	<param name="wmode" value="transparent" />
	<param name="flashvars" value="color1=0xFFFFFF&amp;alpha1=.30&amp;framerate1=24" />
    <param name="swfliveconnect" value="true" />
    <!--[if !IE]>-->
    <object type="application/x-shockwave-flash" data="images/flash.swf" width="900" height="225">
        <param name="quality" value="high" />
	    <param name="scale" value="exactfit" />
	    <param name="wmode" value="transparent" />
	    <param name="flashvars" value="color1=0xFFFFFF&amp;alpha1=.30&amp;framerate1=24" />
        <param name="swfliveconnect" value="true" />
    <!--<![endif]-->
      	<div class="art-flash-alt"><a href="http://www.adobe.com/go/getflashplayer"><img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" /></a></div>
    <!--[if !IE]>-->
    </object>
    <!--<![endif]-->
</object>
</div>
</div>
<script type="text/javascript">swfobject.switchOffAutoHideShow();swfobject.registerObject("art-flash-object", "9.0.0", "expressInstall.swf");</script>
<div class="art-logo">
    <h1 id="name-text" class="art-logo-name">
        <a href="#">Pirkt Hardware Store</a><p class="MsoNormal"
                style="margin: 0in 0in 10pt">
                <span style="font-size: 11pt; font-family: Calibri"></span>&nbsp;</p>
    </h1>
    <div id="slogan-text" class="art-logo-text">
        Online Sale Platform by CSC 3326 Students</div>
</div>
