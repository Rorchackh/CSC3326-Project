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


    public SqlConnection connection = new SqlConnection();
    public SqlDataReader dataReader;

    protected void Page_Init(object sender, EventArgs e)
    {
        load_vendors();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }



    public void load_vendors()
    {
        int counter = 0;
        this.connection.ConnectionString =
               "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("SELECT ved_name, ved_phone, ved_areacode from vendor", this.connection);
            //Execute query and get results

            this.dataReader = command.ExecuteReader();
            String str = "<table width=\"100%\"><tbody>";
            str += "<tr>";
            while (this.dataReader.Read())
            {
                counter++;
                string vendor = this.dataReader[0].ToString() + "</br>" + this.dataReader[1].ToString();
                str += "<td align=\"center\">" + "<IMG SRC=\"Vendors Images/" + this.dataReader[0].ToString() + ".png" + "\"></br>" + vendor + "<br><br>" + "<input id=\"Button1\" type=\"button\"class=\"art-button\" value=\"View Products\" onClick=\"window.location='Vendors.aspx?pid=" + this.dataReader[2].ToString() + "'\"> " + "</td>";
                if (counter == 3)
                {
                    str += "</tr><tr>";
                }

            }
            str += "</tr>";
            str += "</tbody></table>";
        }
        catch (SqlException sqle)
        {

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
