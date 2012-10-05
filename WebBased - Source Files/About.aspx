<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@  Register Assembly="MSCaptcha"  Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          <%@ Register TagPrefix="art" TagName="DefaultSidebar2" Src="DefaultSidebar2.ascx" %>
          
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Charting" tagprefix="telerik" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    PIRKT Hardware Store: About This Project
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

    <br />
    <br />
    <p style="font-size: 22px">
        <strong>About the project</strong></p>
    <br />
    <p>
    <b>PIRKT Hardware Store</b>, which means &quot;buy&quot; in Letton, is an online selling platform vending computer components, electronic products, and domestic appliances managed by PIRKT Inc. created by Khobalatte Ayoub, Benhallam Wassim, Khrifi Med Redouane and Khobalatted Med Wael.
    <br/>The majority of the sales take place through a segment of listings in the "Buy It Now" category. <br />
    In addition to its original Moroccan website, Pirkt is considering establishing localized websites in many other countries including U.S, England and Australia.
    </p>
    <h2>
        <strong>Contact Information</strong></h2>
    <h3>
        Phone Numbers and E-mails:</h3>
    <p class="style3">
        <span class="style4">Ayoub Khobalatte&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; : (212) 535 386 3113 | ayoub.khobalatte@gmail.com <br />
        Wassim Benhallam&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; : (212) 535 386 2632 | w.benhallam@aui.com <br />
        Ali Elouafiq&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : (212) 535 386 2581 | a.elouafiq@aui.com <br />
        Med Redouane Khrifi&nbsp;&nbsp; : (212) 535 386 3079 | r.khrifi@gmail.com <br />
        Med Wael Khobalatte&nbsp;&nbsp; : (212) 535 386 3113 | wael.khobalatte@gmail.com </span> <br />
        
        </p>

<h3>
        Aknowledgement:</h3>
     <blockquote>
        We would like to thank Dr. Nasser Assem for providing us with the necessary tools to implement this project.
         </blockquote>
        
        </p>
</asp:Content>
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ScriptIncludePlaceHolder">
    <script type="text/javascript" src="<%= ResolveUrl("~/script.js") %>"></script>
    <style type="text/css">
        .style3
        {
            font-size: small;
        }
        .style4
        {
            font-family: "Lucida Bright";
            font-size: small;
        }
    </style>
    </asp:Content>

