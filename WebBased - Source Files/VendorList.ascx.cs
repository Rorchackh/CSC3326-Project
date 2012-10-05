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

public partial class VMenu : System.Web.UI.UserControl
{
    public SqlConnection connection = new SqlConnection();
    public SqlDataReader dataReader;
    string id = "";
    protected void Page_Init(object sender, EventArgs e)
    {
        id = Request.QueryString["id"];
        if (id == null || id == "")
            id = "0";
            load_vendors();
    }

        public void load_vendors() {
            int counter = 0;
        this.connection.ConnectionString =
               "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("SELECT ved_name, ved_areacode, ved_phone from vendor", this.connection);
            //Execute query and get results
            
            this.dataReader = command.ExecuteReader();
            String str = "<table width=\"100%\"><tbody>";
            str += "<tr>";
            while (this.dataReader.Read())
            {
                counter++;
                string product = this.dataReader[0].ToString() + "</br>" + this.dataReader[1].ToString() + "</br>" + this.dataReader[2].ToString();
                str += "<td align=\"center\">" + "<IMG SRC=\"Vendor Images/" + this.dataReader[0].ToString() + ".png" + "\"></br>" + product + "<br><br>" + "<input id=\"Button1\" type=\"button\"class=\"art-button\" value=\"View Products\" onClick=\"window.location='Vendor.aspx?vid=" + this.dataReader[0].ToString()+"&id="+ id+"'\"> " + "</td>";
                if (counter == 3)
                {
                    str += "</tr><tr>"; counter = 0;
                }
              
            }
            str += "</tr>";
            str+="</tbody></table>";
            this.productList.InnerHtml = str;
        }
        catch (SqlException sqle)
        {
               
            //Label3.Text = "SQL Exception Occured!";
        }
        finally
        {
            if (this.dataReader != null)
            {
                this.dataReader.Close();
            }
            if (this.connection != null)
            {
                this.connection.Close();
            }

        }
    }

  

}
    
        
    

