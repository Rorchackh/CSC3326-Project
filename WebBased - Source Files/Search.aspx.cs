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
using System.Windows.Forms;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection connection = new SqlConnection();
    SqlDataReader dataReader;
    protected void Page_Init(object sender, EventArgs e)
    {
        load_Categories();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.Warning.Visible = false;
        if (this.TextBox1.Text == "")
            this.Warning.Visible = true;
        else if (this.DropDownList1.SelectedIndex == 0)
        {
            int counter = 0;
            this.connection.ConnectionString =
                   "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                // Connect to your database
                this.connection.Open();
                // Create an SQL command = a Query ze3ma
                SqlCommand command = new SqlCommand("SELECT pro_name, pro_price, pro_id from product where pro_name like '%" + this.TextBox1.Text + "%'", this.connection);
                //Execute query and get results

                this.dataReader = command.ExecuteReader();
                String str = "<table width=\"100%\"><tbody>";
                str += "<tr>";
                if (this.dataReader.HasRows)
                {
                    while (this.dataReader.Read())
                    {
                        counter++;
                        string product = this.dataReader[0].ToString() + "</br>" + this.dataReader[1].ToString();
                        str += "<td align=\"center\">" + "<IMG SRC=\"Product Images/" + this.dataReader[0].ToString() + ".png" + "\"></br>" + product + "<br><br>" + "<input id=\"Button2\" type=\"button\"class=\"art-button\" value=\"View Product\" onClick=\"window.location='Product.aspx?pid=" + this.dataReader[2].ToString() + "'\"> " + "</td>";
                        if (counter == 3)
                        {
                            str += "</tr><tr>";
                            counter = 0;
                        }

                    }
                    str += "</tr>";
                    str += "</tbody></table>";
                    this.Results.InnerHtml = str;
                }
                else {
                    str = "Your search input didn't yield any results.";
                    this.Results.InnerHtml = str;
                }
            }
            catch (SqlException sqle)
            {
                string error = sqle.Message.ToString();
                this.Results.InnerHtml = error;
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
        else {
            int counter = 0;
            this.connection.ConnectionString =
                   "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                // Connect to your database
                this.connection.Open();
                // Create an SQL command = a Query ze3ma
                string cat = this.DropDownList1.SelectedItem.Text;
                SqlCommand command = new SqlCommand("SELECT p.pro_name, p.pro_price, p.pro_id from product p inner join category c on p.cat_id=c.cat_id where c.cat_name='" + cat + "' and pro_name like '%" + this.TextBox1.Text + "%'", this.connection);
                //Execute query and get results

                this.dataReader = command.ExecuteReader();
                String str = "<table width=\"100%\"><tbody>";
                str += "<tr>";
                if (this.dataReader.HasRows)
                {
                    while (this.dataReader.Read())
                    {
                        counter++;
                        string product = this.dataReader[0].ToString() + "</br>" + this.dataReader[1].ToString();
                        str += "<td align=\"center\">" + "<IMG SRC=\"Product Images/" + this.dataReader[0].ToString() + ".png" + "\"></br>" + product + "<br><br>" + "<input id=\"Button2\" type=\"button\"class=\"art-button\" value=\"View Product\" onClick=\"window.location='Product.aspx?pid=" + this.dataReader[2].ToString() + "'\"> " + "</td>";
                        if (counter == 3)
                        {
                            str += "</tr><tr>";
                            counter = 0;
                        }
                    }
                    str += "</tr>";
                    str += "</tbody></table>";
                    this.Results.InnerHtml = str;
                }
                else
                {
                    str = "Your search input didn't yield any results.";
                    this.Results.InnerHtml = str;
                }
            }
            catch (SqlException sqle)
            {
                string error = sqle.Message.ToString();
                this.Results.InnerHtml = error;
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
    public void load_Categories()
    {

        this.connection.ConnectionString =
                "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("select cat_name from category where sup_id = 0", this.connection);
            //Execute query and get results
            this.dataReader = command.ExecuteReader();
            this.DropDownList1.Items.Add("All categories");
            while (this.dataReader.Read())
            {
                // Menu1.Items.Add(new MenuItem(this.dataReader[0].ToString()));
                this.DropDownList1.Items.Add(this.dataReader[0].ToString());
            }
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
