﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Order.ascx.cs" Inherits="Order" %>

  
 

<form >

    <table id="MasterTable" border="0" cellspacing="0" width="100%">
    <tr>
      <td id="HeaderCell">
    
      </td>
    </tr>
    </table>
    <br/>
    <asp:Label id="ReturnURL" Visible="False" Runat="Server"/>
    <asp:Label id="Instructions" Runat="Server"
      Text="Enter the requested information to complete your order with "/>
    <asp:Label id="MerchantID" Font-Bold="True" Runat="Server"/>.<br/><br/>
    <table border="0">
    <tr>
      <th> Customer ID: </th>
      <td colspan="5">
          <div id="UserID" runat="server" ></div>
        <asp:Label id="CustomerID" Runat="Server"
          Font-Bold="True"/>
        <asp:Label id="Approved" Runat="Server"
          ForeColor="#FF0000" Font-Bold="True"/>
      </td>
    </tr>
    <tr>
      <th> Order Amount: </th>
      <td colspan="5">
          <div id="OrdAmount" runat="server" ></div>
        <asp:Label id="OrderTotal" Runat="Server"
          Font-Bold="True"/></td>
    </tr>
    <tr>
      <td colspan="6"> </td>
    </tr>
    <tr>
      <th> Credit Card: </th>
      <td colspan="5">
          <asp:DropDownList id="CreditCard" Runat="Server" style="text-align: center">
          <asp:ListItem>Discover</asp:ListItem>
          <asp:ListItem>MasterCard</asp:ListItem>
          <asp:ListItem>Visa</asp:ListItem>
          <asp:ListItem>Discover</asp:ListItem>
        </asp:DropDownList>
        </td>
    </tr>
    <tr>
      <th> Account: </th>
      <td colspan="5">
        <asp:TextBox id="Account" Runat="Server"
          Text="1111 1111 1111 1111" Size="16" MaxLength="19"/>
      </td>
    </tr>
    <tr>
      <th> Expiration Date: </th>
      <td colspan="5">
        Month: 
        <asp:DropDownList id="ExpMonth" Runat="Server">
          <asp:ListItem>01</asp:ListItem>
          <asp:ListItem>02</asp:ListItem>
          <asp:ListItem>03</asp:ListItem>
          <asp:ListItem>04</asp:ListItem>
          <asp:ListItem>05</asp:ListItem>
          <asp:ListItem>06</asp:ListItem>
          <asp:ListItem>07</asp:ListItem>
          <asp:ListItem>08</asp:ListItem>
          <asp:ListItem>09</asp:ListItem>
          <asp:ListItem>10</asp:ListItem>
          <asp:ListItem>11</asp:ListItem>
          <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
        Year: 
        <asp:DropDownList id="ExpYear" Runat="Server">
          <asp:ListItem>2003</asp:ListItem>
          <asp:ListItem>2004</asp:ListItem>
          <asp:ListItem>2005</asp:ListItem>
          <asp:ListItem>2006</asp:ListItem>
          <asp:ListItem>2007</asp:ListItem>
        </asp:DropDownList>
      </td>
    </tr>
    <tr>
      <td colspan="6"> </td>
      
    </tr>
    <tr>
      <th> Name: </th>
      <td colspan="5">
        <asp:TextBox id="Name" Runat="Server" 
          Text="Your Name" Size="30" MaxLength="50"/></td>
          <td>           &nbsp;</td>
    </tr>
    <tr>
      <th> Address: </th>
      <td colspan="5">
        <asp:TextBox id="Address" Runat="Server" 
          Text="Your Address" Size="30" MaxLength="50"/></td>
      
    </tr>
    <tr>
      <th> City: </th>
      <td><asp:TextBox id="City" Runat="Server"
        Text="Your City" Size="30" MaxLength="30"/></td>
      <th> State: </th>
      <td><asp:TextBox id="State" Runat="Server"
        Text="ST" Size="2" MaxLength="2"/></td>
      <th> Zip: </th>
      <td><asp:TextBox id="Zip" Runat="Server"
        Text="55555" Size="10" MaxLength="10"/></td>
    </tr>
    <tr>
      <th> Email: </th>
      <td colspan="5">
        <asp:TextBox id="Email" Runat="Server"
          Text="your@email.net" Size="30" MaxLength="50"/></td>
    </tr>
    </table>           <img alt="" src="Credit.png"  /><br/>
    <asp:Panel id="ContinuePanel" Runat="Server">
      <asp:Button id="ContinueButton" Text="Continue Purchase" Runat="Server" cssClass="art-button"
        OnClick="CheckCredit"/>
      <div runat="server" id="Return">
     
        </div>
      <asp:Label id="Message" EnableViewState="False" Runat="Server" 
        style="color:#FF0000"/>
    </asp:Panel>
    <asp:Panel id="CompletePanel" Visible="False" Runat="Server" >
      Click to
      <asp:Button ID="Button1" Text="Complete Order" Runat="Server" cssClass="art-button"
        OnClick="Submit_Order"/>
      or
      <div runat="server" id="Return2">
     
        </div>
    </asp:Panel>

</form>

