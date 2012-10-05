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
    public string pid = "";
    public int flag = 0;
    string id = "";
    protected void Page_Init(object sender, EventArgs e)
    {
        // this.Article1.Caption = "" + Request.QueryString["cat"];
        pid = Request.QueryString["pid"];
        id = Request.QueryString["id"];
        if (id == null || id == "")
            id = "0";
        load_Product_Description();
        load_Reviews();
    }

    public void load_Product_Description()
    {
        this.connection.ConnectionString =
               "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("SELECT pro_name, pro_descript, p_status, pro_price, ved_name, cat_name from product p join category c on p.cat_id=c.cat_id join vendor v on p.ved_id = v.ved_id where p.pro_id =" + pid, this.connection);
            //Execute query and get results

            this.dataReader = command.ExecuteReader();
            string str = "<table align=center width=\"70%\"><tbody><tr>";
            string str2 = "";
            string title = "";
            string description = "";
            string cart = "";

            while (this.dataReader.Read())
            {
                cart = "<fieldset> <input id=\"Button2\" runat =\"server\" class=\"art-button\" style=\"width: 90px; height: 20px\" type=\"button\" value=\"Add To Cart\" onclick=\"window.location='Cart.aspx?id=" + ((id == "0")?null:id) + "&pid=" + pid + "&qty=1'\"/> </fieldset> <br/>";
                title = "<p></br><u><b>Product: </b>" + this.dataReader[0].ToString() + "</u></p>";
                str2 += "<table width=\"60%\"><tbody><tr>";
                str2 += "<td><b>Price</b></td><td></td><td>" + this.dataReader[3].ToString() + "</td>";
                str2 += "<tr><td><b>Availability</b></td><td></td><td>" + this.dataReader[2].ToString() + "</td></tr>";
                str2 += "<tr><td><b>Model</b></td><td></td><td>New</td></tr>";
                str2 += "<tr><td><b>Vendor</b></td><td></td><td>" + this.dataReader[4].ToString() + "</td></tr>";
                str2 += "<tr><td><b>Category</b></td><td></td><td>" + this.dataReader[5].ToString() + "</td></tr>";
                str2 += "</tbody></table>";

                str += "<tr><td><IMG SRC=\"Product Images/" + this.dataReader[0].ToString() + ".png\"></td><td>" + str2 + "</td></tr>";

                description = "<p></br><b>Description: </b>" + this.dataReader[1].ToString() + "</p>";
                //<asp:Button ID="Button1" runat="server" Text="Button" />
                //<input id=\"Button1\" class=\"art-button\" style=\"width: 90px; height: 20px\" type=\"button\"        value=\"Add To Cart\" onClick=\"window.location='Cart.aspx?id=4'/>
                //str += this.dataReader[0].ToString() + "</p>";
                //str += "<IMG SRC=\"Product Images/" + this.dataReader[0].ToString() + ".png";

            }

            str += "</tbody></table>";
            
            this.Prod2.InnerHtml = title;
            this.Prod2.InnerHtml += str;
            this.Prod2.InnerHtml += description;
            this.AddToCart.InnerHtml = cart;
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

    public void load_Reviews()
    {
        this.connection.ConnectionString =
                "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("select rev_text, cus_lname, cus_fname from review r join product p on r.pro_id = p.pro_id join customer c on r.cus_id = c.cus_id where p.pro_id =" + pid, this.connection);
            //Execute query and get results
            this.dataReader = command.ExecuteReader();
            String str = "<p><fieldset><legend style=\"color: White\">Reviews</legend>";
            while (this.dataReader.Read())
            {
                str += "<blockquote style=\"width:auto; height:auto;\"><p style=\"height:auto;\">&#8220;" + this.dataReader[0].ToString() + "&#8221;<br />-" + this.dataReader[1].ToString() + " " + this.dataReader[2].ToString() + "</p></blockquote>";

            }
            str += "</fieldset></p>";
            this.Reviews.InnerHtml = str;
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

    public void Insert_Review()
    {

        this.connection.ConnectionString =
                "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            string text = this.TextBox1.Text;
            // Create an SQL command = a Query ze3ma
            string date = DateTime.Now.ToString();
            //this.Label1.Text = date;

            SqlCommand command = new SqlCommand("insert into review values('" + date + "', 5,'Comment', '" + text + "', "+id+"," + pid + ")", this.connection);
            //Execute query and get results
            //this.Label1.Text = "Error try";
            command.ExecuteNonQuery();


        }
        catch (SqlException sqle)
        {
           // this.Label1.Text = "Error catch" + sqle.Message.ToString();
        }
        finally
        {
            if (this.connection != null)
            {
                this.connection.Close();
              
            }

            this.TextBox1.Text = "";
        } Page_Init(null, null);

    }










    protected void Button1_Click(object sender, EventArgs e)
    {
        Insert_Review();
    }






}
