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
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection connection=new SqlConnection();
    SqlDataReader dataReader;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Article1.Caption = "All Vendors";

        //LoadProducts( Request.QueryString["cat"]);
        
    }
 
}

 
   