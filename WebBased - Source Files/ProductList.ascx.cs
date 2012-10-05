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
    public string id = "";
    protected void Page_Init(object sender, EventArgs e)
    {
       // this.Article1.Caption = "" + Request.QueryString["cat"];
        string test = "";
        id = Request.QueryString["id"];
        if (id == "" || id == "0")
            id = "0";
        if (Request.QueryString["cat"] != null)
        {
            load_Category_Description(Request.QueryString["cat"]);
            load_products(Request.QueryString["cat"]);
        }
        else
        {
            load_Vendor_Description(Request.QueryString["vid"]);
            load_products_vendor(Request.QueryString["vid"]);
        }
        
    }

        public void load_products(string cat) {
            int counter = 0;
        this.connection.ConnectionString =
               "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("SELECT p.pro_name, p.pro_price, p.pro_id from product p inner join category c on p.cat_id=c.cat_id where c.cat_name='"+cat+"'", this.connection);
            //Execute query and get results
            
            this.dataReader = command.ExecuteReader();
            String str = "<table width=\"100%\"><tbody>";
            str += "<tr>";
            while (this.dataReader.Read())
            {
                counter++;
                string product = this.dataReader[0].ToString() + "<br/>" + this.dataReader[1].ToString();
                str += "<td align=\"center\">" + "<IMG SRC=\"Product Images/" + this.dataReader[0].ToString() + ".png" + "\"><br/>" + product + "<br/><br/>" + "<input id=\"Button1\" type=\"button\"class=\"art-button\" value=\"View Product\" onClick=\"window.location='Product.aspx?pid=" + this.dataReader[2].ToString() + "&id=" + id +"'\"> " + "</td>";
                if (counter == 3)
                {
                    str += "</tr><tr>";
                    counter = 0;
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

    public void load_Category_Description(String cat)
    {
        this.connection.ConnectionString =
                "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("select cat_Descript from category where cat_name = '" + cat + "'", this.connection);
            //Execute query and get results
            this.dataReader = command.ExecuteReader();
            String str = "<p>";
            while (this.dataReader.Read())
            {
                str += this.dataReader[0].ToString()+"</p>";

            }
            this.Description.InnerHtml = str;
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
    //=========================================================================

    public void load_Vendor_Description(String vid)
    {
        this.connection.ConnectionString =
                "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("select ved_name,ved_areacode,ved_phone from vendor where ved_name = '" + vid + "'", this.connection);
            //Execute query and get results
            this.dataReader = command.ExecuteReader();
            String str = "<p>";
            while (this.dataReader.Read())
            {
                str += "Vendor Name: "+this.dataReader[0].ToString() + "<br/>Vendor areacode: "+this.dataReader[1].ToString()+"<br/>Vendor Phone: "+this.dataReader[2].ToString()+"</p>" ;

            }
            this.Description.InnerHtml = str;
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


    public void load_products_vendor(string vid)
    {
        int counter = 0;
        this.connection.ConnectionString =
               "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("SELECT p.pro_name, p.pro_price, p.pro_id from product p join vendor v on p.ved_id = v.ved_id where v.ved_name='" +vid + "'", this.connection);
            //Execute query and get results

            this.dataReader = command.ExecuteReader();
            String str = "<table width=\"100%\"><tbody>";
            str += "<tr>";
            //this.Label1.Text = "Error Try";
            while (this.dataReader.Read())
            {
                counter++;
                string product = this.dataReader[0].ToString() + "</br>" + this.dataReader[1].ToString();
                str += "<td align=\"center\">" + "<IMG SRC=\"Product Images/" + this.dataReader[0].ToString() + ".png" + "\"></br>" + product + "<br><br>" + "<input id=\"Button1\" type=\"button\"class=\"art-button\" value=\"View Product\" onClick=\"window.location='Product.aspx?pid=" + this.dataReader[2].ToString() +"&id="+id+ "'\"> " + "</td>";
                if (counter == 3)
                {
                    str += "</tr><tr>";
                    counter = 0;
                }

            }
            str += "</tr>";
            str += "</tbody></table>";
            this.productList.InnerHtml = str;
        }
        catch (SqlException sqle)
        {

           // this.Label1.Text = "Error catch"+sqle.Message.ToString();
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
    
        
    

