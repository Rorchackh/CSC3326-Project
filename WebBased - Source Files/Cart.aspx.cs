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
    string id = "";
    string pid = "";
    string qty = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        qty = Request.QueryString["qty"];
        if (qty == "" || qty == null)
            qty = "1";
        id = Request.QueryString["id"];
        if (id == "" || id == null || id == "0")
        {
            Response.Redirect("Login.aspx?id=0");
        }
        pid = Request.QueryString["pid"];
        insertInLine();
        
    }

    void insertInLine() {
        this.connection.ConnectionString =
                "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {
            // Connect to your database
            this.connection.Open();
            // Create an SQL command = a Query ze3ma
            SqlCommand command = new SqlCommand("select * from line where car_id = " + id + " and pro_id = " + pid, this.connection);
            SqlDataReader dataReader1 = command.ExecuteReader();
            while (dataReader1.Read())
            {
                if (dataReader1[2].ToString() == pid && dataReader1[1].ToString() == id)
                {
                    dataReader1.Close();
                    SqlCommand cm = new SqlCommand("update line set line_units = line_units + " + qty + " where car_id = " + id + " and pro_id = " + pid, this.connection);
                    cm.ExecuteNonQuery();
                    return;
                }
            }
            dataReader1.Close();
            SqlCommand comm = new SqlCommand("select pro_price from product where pro_id = " + pid, this.connection);
            SqlDataReader dt = comm.ExecuteReader();
            string kaka = "0";
            while(dt.Read()){
                kaka = dt[0].ToString(); ;
            }
            dt.Close();
            SqlCommand command2 = new SqlCommand("insert into line values("+pid+","+id+","+pid+","+kaka+","+ qty+")", this.connection);
            command2.ExecuteNonQuery();
           
            
        }
        catch (SqlException sqle)
        {
            //Response.Redirect(sqle.Message);
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Order.aspx?id=" + id);
    }

    protected void Cart_Load(object sender, EventArgs e)
    {
        
    }
}
