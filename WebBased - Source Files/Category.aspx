<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
<%@ Register TagPrefix="art" TagName="ProductsContent" Src="ProductList.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Pirkt Hardware Store: Category Details
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


<asp:Content ID="SheetContent" ContentPlaceHolderID="SheetContentPlaceHolder" Runat="Server">

<artisteer:Article ID="Article1" Caption="Category" runat="server"><ContentTemplate>
    <art:ProductsContent ID="ProductsContent" runat="server" />
    &nbsp;&nbsp;&nbsp;
    <div runat="server" class="art-content-layout overview-table">
        <table style="width: 100%;" id="TableProducts">
            <tr>
                <td>
                    
                </td>
             </tr>
            
        </table>
        <br />
        <!-- end row --></div>
    <!-- end table -->
           </ContentTemplate></artisteer:Article>
        

</asp:Content>
