using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.UserControl
{
    string id; int Amount=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["id"];
        if (id == null || id == "")
            Response.Redirect("Default.aspx?id=0");
        UserID.InnerHtml = id;
        OrdAmount.InnerHtml=""+Amount;
        this.Return.InnerHtml = " <input type=\"button\" value=\"Return to Shopping\" class=\"art-button\"onclick=\"window.location='Store.aspx?id=" + id + "'\">";
        this.Return2.InnerHtml = " <input type=\"button\" value=\"Cancel\" class=\"art-button\"onclick=\"window.location='Store.aspx?id=" + id + "'\">";
   
    }
    protected void CheckCredit(object sender, EventArgs e)
    {
        Response.Redirect("http://PayPal.com");
    }

    protected void Submit_Order(object sender, EventArgs e)
    {
        Response.Redirect("Store.aspx");
    }
}