<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 

<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
<%@ Register TagPrefix="art" TagName="DefaultSidebar2" Src="DefaultSidebar2.ascx" %>
<%@ Register TagPrefix="art" TagName="ProductDescription" Src="ProductDescription.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Pirkt Hardware Store: Product Details
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

<artisteer:Article ID="Article1" Caption="Product Sheet" runat="server" Height="66px" Width="493px">
    <ContentTemplate>
<art:ProductDescription ID="ProductDescription" runat="server" />
           <div id="Div1" runat="server" class="art-content-layout overview-table">
               &nbsp;</div>
            </ContentTemplate>
            </artisteer:Article>
                       <div id="Prod2" runat="server">
    &nbsp;</div>
    <div id="AddToCart" runat="server" >
</div>
<div id="Reviews" runat="server"> 
    &nbsp;</div>
    <fieldset>
    <legend style="color:white">Post a comment</legend>
<div id="PostReview" runat="server" >
    &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="341px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" CssClass="art-button" Height="26px" Width="63px" /><br/>
    </div>
    </fieldset>
</asp:Content>

