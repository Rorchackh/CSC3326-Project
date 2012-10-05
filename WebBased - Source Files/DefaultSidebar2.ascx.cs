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

public partial class Sidebar2 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void ClickEvent()
    {
        Button1_Click(null, null);
    }
    
    public  void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Subscribed?email="+ NewsletterBlock.ID);
    }
}
