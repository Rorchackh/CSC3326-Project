using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        string name;
        if (id == null || id == "0" || id == "")
        {
            id = "0";
            name = "Login";
        }
        else
            name = "Logout";
        this.MenuTop.InnerHtml = "<ul class=\"art-menu\"> <li><a href=\"Default.aspx?id=" + id + "\" class=\" active\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">Home</span></a></li> <li><a href=\"Search.aspx?id=" + id + "\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">Search For Product</span></a></li><li><a href=\"Store.aspx?id=" + id + "\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">Store</span></a></li><li><a href=\"Cart.aspx?id=" + id + "\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">Cart</span></a></li><li><a href=\"MyAccount.aspx?id=" + id + "\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">My Account</span></a></li><li><a href=\"Register.aspx?id=" + id + "\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">Register</span></a></li><li><a href=\"Login.aspx?id=" + id + "\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">"+name+"</span></a></li><li><a href=\"About.aspx?id=" + id + "\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">About</span></a></li></ul>";


    }
}
