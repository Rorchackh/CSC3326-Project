<%@ Control Language="C#" AutoEventWireup="true" CodeFile="myAccount.ascx.cs" Inherits="myAccount" %>


<style type="text/css">
    .style1
    {
        width: 477px;
        
    }
    .style2
    {
        width: 143px;
        font-weight: bold;
        
    }
</style>


<table style="width:100%;" runat="server" id="Table">
    <tr>
        <td class="style2">
            User ID:</td>
        <td  class="style2">
        <div runat="server" id="userId" >
        </div>
            </td>
       
    </tr>
    <tr>
        <td class="style2">
            Lastname:</td>
        <td  class="style2">
        <div runat="server" id="lastName">
        </div>
            </td>

    </tr>
    <tr>
        <td class="style2">
            Firstname:</td>
        <td  class="style2">
        <div runat="server" id="firstName">
        </div>
            </td>
       
    </tr>
    <tr>
        <td class="style2">
            Email:</td>
        <td  class="style2">
        <div runat="server" id="email">
        </div>
        </td>
    </tr>
        <tr>
        <td class="style2">
            Credit Card Num:</td>
        <td  class="style2">
        <div runat="server" id="creditCard"></div>
        </td>
    </tr>
        <tr>
        <td class="style2">
            Phone:</td>
        <td   class="style2">
        <div runat="server" id="Phone" >
        </div>
        </td>
    </tr>
</table>
<div runat="server" id="dynamic">
    &nbsp;</div>

<div runat="server" id="dynamicAdresse">

</div>


<table style="width:100%;" runat="server" id="Table0">
    <tr>
        <td class="style2">
            Number:</td>
        <td  class="style2">
        <div runat="server" id="userId0" >
        </div>
            </td>
       
    </tr>
    <tr>
        <td class="style2">
            Street:</td>
        <td  class="style2">
        <div runat="server" id="lastName0">
        </div>
            </td>

    </tr>
    <tr>
        <td class="style2">
            ZipCode:</td>
        <td  class="style2">
        <div runat="server" id="firstName0">
        </div>
            </td>
       
    </tr>
    <tr>
        <td class="style2">
            City:</td>
        <td  class="style2">
        <div runat="server" id="email0">
        </div>
        </td>
    </tr>
        <tr>
        <td class="style2">
            Country </td>
        <td  class="style2">
        <div runat="server" id="creditCard0"></div>
        </td>
    </tr>
        <tr>
        <td class="style2">
            &nbsp;</td>
        <td   class="style2">
            &nbsp;</td>
    </tr>
</table>



