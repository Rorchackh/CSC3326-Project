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
        if (id == "" || id == "0")
            id = "0";
        load_Categories();
        load_Vendors();
    }

        public void load_Categories() {

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
            while (this.dataReader.Read())
            {
                // Menu1.Items.Add(new MenuItem(this.dataReader[0].ToString()));
                Categories.InnerHtml += "<li><a href=\"Category.aspx?cat="+this.dataReader[0].ToString()+"&id="+id+"\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">" + this.dataReader[0].ToString() + "</span></a></li>";
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

    public void load_Vendors()
    {

        this.connection.ConnectionString =
                "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("select distinct top 3 ved_name, count(p.pro_id) from vendor v inner join product p on p.ved_id = v.ved_id group by ved_name having count(p.pro_id) >= all (select distinct count(*) from vendor v inner join product p on p.ved_id = v.ved_id group by (p.pro_id) ) order by count(p.pro_id) desc", this.connection);
            //Execute query and get results
            this.dataReader = command.ExecuteReader();
            while (this.dataReader.Read())
            {
                // Menu1.Items.Add(new MenuItem(this.dataReader[0].ToString()));
                Vendors.InnerHtml += "<li><a href=\"Vendor.aspx?vid="+this.dataReader[0].ToString()+"&id="+id+"\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">" + this.dataReader[0].ToString() + "</span></a></li>";
            }
            Vendors.InnerHtml += "<li><a href=\"ViewAll.aspx?id="+id+"\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\"><U>View All...</U></span></a></li>";
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

