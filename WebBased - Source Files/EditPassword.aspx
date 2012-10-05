<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="EditPassword.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
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
    PIRKT Hardware Store: Edit Your Password
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

    <style type="text/css">
    .style1
    {
        width: 137px;
        text-align: left;
    }
    #Text2
    {
        width: 211px;
    }
    #Text1
    {
        width: 207px;
    }
    #Text3
    {
        width: 211px;
    }
    #Text4
    {
        width: 210px;
    }
    #Text5
    {
        width: 206px;
    }
    #Text6
    {
        width: 213px;
        height: 22px;
    }
        .style2
        {
            width: 151px;
        }
    </style>
<b><h2>Edit Your Password</h2></b>
    
     <table style="width:100%;">
         <tr>
             <td class="style2">
    
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style2">
                 <asp:Label ID="Label2" runat="server" Text="Old Password: "></asp:Label></td>
             <td>
                 <asp:TextBox TextMode="Password" ID="TextBox2" runat="server" Width="158px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td class="style2">
                 <asp:Label ID="Label3" runat="server" Text="New Password: "></asp:Label></td>
             <td>
                 <asp:TextBox  TextMode="Password" ID="TextBox3" runat="server" Width="158px" ></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td class="style2">
                 <asp:Label ID="Label4" runat="server" Text="Confirm Password: "></asp:Label></td>
             <td>
                 <asp:TextBox TextMode="Password"  ID="TextBox4" runat="server" Width="158px" OnTextChanged="CheckPassword" ></asp:TextBox>
             </td>
         </tr>
       
         
         <tr>
         <td> &nbsp;</td><td><recaptcha:RecaptchaControl 
                            ID="recaptcha"
                            runat="server"
                            PublicKey="6Lf_4rkSAAAAAJ8mQFdI8SQgQSwDGLHirEXLaW_-"
                            PrivateKey="6Lf_4rkSAAAAAEtWiFnbv2p-DjJMxFb3J2DQOhjT"
                            /></td>
         </tr>
         <tr>
         <td>
             <asp:Button ID="Button2" runat="server" Text="Change Passord" 
                 CssClass="art-button" onclick="Button2_Click" />
         </td>
         <td>
             <asp:Label ID="Label7" runat="server" style="color: #FF0000; font-weight: 700" 
                 Text=""></asp:Label>
             </td>
         </tr>
    </table>
    
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    
   
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      

</asp:Content>
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ScriptIncludePlaceHolder">
    <script type="text/javascript" src="<%= ResolveUrl("~/script.js") %>"></script>
    <style type="text/css">
        .style1
        {
            font-size: small;
            text-align: left;
        }
        </style>
</asp:Content>

