<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Store.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
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
    PIRKT Hardware Store: The List Of All Products
</asp:Content>

<asp:Content ID="MenuContent" ContentPlaceHolderID="MenuContentPlaceHolder" Runat="Server">
    <art:DefaultMenu id="DefaultMenuContent" runat="server" />
</asp:Content>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContentPlaceHolder" Runat="Server">
    <art:DefaultHeader id="DefaultHeader" runat="server" />
</asp:Content>
<asp:Content ID="SideBar1" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" Runat="Server">
    <art:DefaultSidebar1 id="DefaultSidebar1Content" runat="server" />
</asp:Content>
<asp:Content ID="SideBar2" ContentPlaceHolderID="Sidebar2ContentPlaceHolder" Runat="Server">
    <art:DefaultSidebar2 id="DefaultSidebar2Content" runat="server" />
</asp:Content>

<asp:Content ID="SheetContent" ContentPlaceHolderID="SheetContentPlaceHolder" Runat="Server">
    <br/>
    <br/>
    PIRKT Hardware Store: All The Products In The Store 
    <br/>
    <br/>
    <br/>
    
    <div id = "Store">
    <asp:GridView ID="GridView1" runat="server" style="position: absolute; margin-left: 50px" AllowPaging="True" AutoGenerateColumns="False" BorderColor="#C0FFC0" DataSourceID="SqlDataSource1" PageSize="4" AllowSorting="True" Width="450px" EnableSortingAndPagingCallbacks="True">
        <Columns>
            <asp:BoundField DataField="PRO_NAME" HeaderText="Product Name" SortExpression="PRO_NAME" />
            <asp:BoundField DataField="PRO_DESCRIPT" HeaderText="Product Description" SortExpression="PRO_DESCRIPT" />
            <asp:BoundField DataField="PRO_PRICE" HeaderText="Product Price" SortExpression="PRO_PRICE" />
            <asp:ImageField DataImageUrlField="PRO_NAME" DataImageUrlFormatString="~\Product Images\{0}.png"
                HeaderText="Product Image" >
            </asp:ImageField>
        </Columns>
        <SelectedRowStyle BackColor="#FF8080" />
    </asp:GridView>
    <br />
        <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:khobalatte_aConnectionString2 %>"
        SelectCommand="SELECT [PRO_NAME], [PRO_DESCRIPT], [PRO_PRICE] FROM [PRODUCT]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
   </div>

</asp:Content>
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ScriptIncludePlaceHolder">
    <script type="text/javascript" src="<%= ResolveUrl("~/script.js") %>"></script>
    </asp:Content>

