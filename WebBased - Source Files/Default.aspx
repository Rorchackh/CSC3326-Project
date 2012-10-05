<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 

<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          <%@ Register TagPrefix="art" TagName="DefaultSidebar2" Src="DefaultSidebar2.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Pirkt Hardware Store By CsC3326 Student
</asp:Content>

<asp:Content ID="MenuContent" ContentPlaceHolderID="MenuContentPlaceHolder" Runat="Server">
    <art:DefaultMenu ID="DefaultMenuContent" runat="server" />
</asp:Content>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContentPlaceHolder" Runat="Server">
    <art:DefaultHeader ID="DefaultHeader" runat="server" />
</asp:Content>
<asp:Content ID="SideBar1" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" Runat="Server">
    <art:DefaultSidebar1 ID="DefaultSidebar1Content" runat="server" />
</asp:Content>
<asp:Content ID="SideBar2" ContentPlaceHolderID="Sidebar2ContentPlaceHolder" Runat="Server">
    <art:DefaultSidebar2 ID="DefaultSidebar2Content" runat="server" />
</asp:Content>

<asp:Content ID="SheetContent" ContentPlaceHolderID="SheetContentPlaceHolder" Runat="Server">

<artisteer:Article ID="Article1" Caption="Welcome" runat="server"><ContentTemplate>
    
    <img class="art-article" src="images/VS.png" alt="an image" style="float:left;border:0;margin: 1em 1em 0 0;" />
    <p class="style1">
        PIRKT Hardware Store</b>, which means &quot;buy&quot; in Letton, is an online selling platform vending computer components, electronic products, and domestic appliances managed by PIRKT Inc. created by Khobalatte Ayoub, Benhallam Wassim, Eloufiq Ali, Khrifi Med Redouane and Khobalatted Med Wael.
    <br/>The majority of the sales take place through a segment of listings in the "Buy It Now" category. <br />
    In addition to its original Moroccan website, Pirkt is considering establishing localized websites in many other countries including U.S, England and Australia.</p>
    <p>
        <input id="Button2" type="button" value="Contact Us!" onclick="window.location='About.aspx'" class="art-button"/ >
    	
    	<span class="art-button-wrapper">
    		<span class="l"> </span>
    		<span class="r"> </span>
    		
    	</span>
    </p>
    <div class="cleared"></div>
    <div class="art-content-layout overview-table">
    	<div class="art-content-layout-row">
    		
    	      <h2 ID="Article1">Support</h4>
    						  <img src="images/01.png" width="55px" height="55px" alt="an image" class="image" />
    						  <p><span class="style1">If you have any questions about this website,<br/>
                                  Please refere to the about panel and contact us</span>.</p>

    		  <h2 ID="Article1">Development Process</h4>
    						  <img src="images/02.png" width="55px" height="55px" alt="an image" class="image" />
    						  <p class="style1" >PIRKT hardware store along with the administation <br/>panel was developpedat Al 
                                  Akhawayn Universityin Ifrane <br/>from Jan 20<sup>th</sup>, 2010 to May 7<sup>th</sup> 2010.</p>

    		
    	</div><!-- end row -->
    </div><!-- end table -->
           </ContentTemplate></artisteer:Article><ContentTemplate>
        <h2>
        Testimonies:
        </h2>
        <blockquote>
            <p>
                "Damn ! You put the bar very high !"
                <br />
                - Meryem Ettouhami
            </p>
            </blockquote>
      <blockquote>
            <p>
                " Very Good Design !"
                <br />
                - Abdessalam Ouaazki
            </p>
      </blockquote>
      <blockquote>
            <p>
                " This website is really beautiful !"
                <br />
                - Mourad Ghanem
                </p>
        
     </blockquote>
        <br />
    
        <table class="art-article" border="0" cellspacing="0" cellpadding="0">
      <tbody>
      </tbody></table>
    
    	<p>
    		<span class="art-button-wrapper">
    			<span class="l"> </span>
    			<span class="r"> </span>
    			<a class="art-button" onclick="window.location='Register.aspx'">Click To Join Us !</a>
    		</span>
    	</p>
           </ContentTemplate>
    

</asp:Content>
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ScriptIncludePlaceHolder">
    <script type="text/javascript" src="<%= ResolveUrl("~/script.js") %>"></script>
    <style type="text/css">
        .style1
        {
            color: #BCCCD2;
        }
    </style>
</asp:Content>

