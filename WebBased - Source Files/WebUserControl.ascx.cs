using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class WebUserControl : System.Web.UI.UserControl
{
    public SqlConnection connection = new SqlConnection();
    public SqlDataReader dataReader;
    string id;
    int SubTotal;
    protected void Page_Load(object sender, EventArgs e)
    {
        SubTotal = 0; 
        id=Request.QueryString["id"];
        if (id == "" || id==null)
        {
            Response.Redirect("Register.aspx");
        }
        load_Cart();
    }
    protected void load_Cart()
    {
        string chart = "";
        string sql = "";
       // chart+="<form   method=\"POST\" action=\"Update.aspx?id=" +id+" \">" ;
        chart += "<form name=\"input\" method=\"post\" action= \"UpDate.aspx\"><table style=\"width:100%;\" class=\"art-article\"><tbody>";
        chart += "<b><tr><td> Name </td><td>	Quantity  </td><td>	Unit Price  </td><td>	Total </td></tr></b>";
        this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            
            
            // The attributes of the line
            string linID, prodID, linQty, UnitPrice;
            int Total;
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma

            sql+="SELECT  LINE.LINE_NUM,  LINE.UNIT_PRICE, LINE.PRO_ID, LINE.LINE_UNIT,PRODUCT.PRO_NAME";
            sql+=" FROM  LINE INNER JOIN";
            sql+=" CART ON LINE.CAR_ID = CART.CAR_ID INNER JOIN";
            sql += " CUSTOMER ON CART.CUS_ID = CUSTOMER.CUS_ID  INNER JOIN PRODUCT ON LINE.PRO_ID = PRODUCT.PRO_ID";
            sql += " where customer.CUS_ID=" + id;
            SqlCommand command = new SqlCommand(sql, this.connection);
            //Execute query and get results

            this.dataReader = command.ExecuteReader();
           //chart += "<tr><input type=\"radio\" value=\"" + id + "\" name=\"id\"/></tr>";
            while (this.dataReader.Read())
            {
                linID = this.dataReader[0].ToString();
                UnitPrice = this.dataReader[1].ToString();
                prodID = this.dataReader[2].ToString();
                linQty = this.dataReader[3].ToString();
                Total=Int32.Parse(linQty)*Int32.Parse(UnitPrice);
                SubTotal += Total;
                
                chart +="<tr>";
                //chart+="<td><input type=\"checkbox\" name=\"remove["+linID+"]\"></td>";//CheckBox
                //chart+="<td>"+/*<img src='Product Images/"+productReader[0].ToString()+".png' \>*/"</td>";//IMage
                chart+="<td><a href=\"Product?pid="+prodID+"\" >"+dataReader[4].ToString()+"</a></td>";//NAME with link
                chart += "<td><input name=\"remove_name[" + linID +"]\" type=\"Label\" value=\"" + linQty + "\"></td>";//CheckBox
                // Menu1.Items.Add(new MenuItem(this.dataReader[0].ToString()));
              //  chart += "<li><a href=\"Category.aspx?cat=" + this.dataReader[0].ToString() + "\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">" + this.dataReader[0].ToString() + "</span></a></li>";
                chart+="<td>"+UnitPrice+"</td>";//CheckBox
                chart+="<td>"+Total+"</td>";//CheckBox
                chart += "</tr>";
                
                
            }
            chart += "<tr><td>    </td><td>    </td><td><b><u><br>SubTotal</u></b>:</td><td><i><br><b>" + SubTotal + "<b></i></td></tr>";
            chart += "</table></tbody>";
           // chart += "<input type=\"submit\" value=\"Update\" class=\"art-button\"\">";
            //chart+="<input type=\"button\" value =\"stupide\" >";
            chart += "</form>";
            chart += "<input type=\"Button\" value=\"Order\" class=\"art-button\" onclick = \"window.location = 'Order.aspx?id=" + id + "'\">"; this.Cart.InnerHtml = chart; 
            this.Cart.InnerHtml = chart;

        }
        catch (SqlException sqle)
        {
            this.Cart.InnerHtml = "Could not Load the Page <br>For Debugging Purposes the QUERY is:<br> "+sql;
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