using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class myAccount : System.Web.UI.UserControl
{
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id=Request.QueryString["id"];
        if (id == null || id == "0" || id == "")
            id = "0";
        FillAccountInfo();

    }
    protected void FillAccountInfo()
    {

        SqlConnection connect = new SqlConnection();
        SqlDataReader values;
        connect.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        connect.Open();
        SqlCommand sql = new SqlCommand("select cus_lname,cus_fname,cus_email,cus_areacode,cus_phone from customer where cus_id=" + id, connect);
        values=sql.ExecuteReader();
        while (values.Read())
        {
            this.userId.InnerHtml = id;
            this.lastName.InnerHtml = values[0].ToString();
            this.firstName.InnerHtml = values[1].ToString();
            this.email.InnerHtml = values[2].ToString();
            this.creditCard.InnerHtml = values[3].ToString();
            this.Phone.InnerHtml = values[4].ToString();
        }

        this.dynamic.InnerHtml = "<i><b><a href=\"EditPassword.aspx?id=" + id + "\">Edit Password </a><b><i><br>";
        this.dynamicAdresse.InnerHtml = "<i><b><a href=\"EditAddresse.aspx?id=" + id + "\">Edit Adresse </a><b><i>";
        values.Close();
       
        sql = new SqlCommand("select add_num,add_street,add_zipcode,add_city,add_country from addresse where add_id=" + id, connect);
        values = sql.ExecuteReader();
        while (values.Read())
        {

            this.userId0.InnerHtml = values[0].ToString();//NUM
            this.lastName0.InnerHtml = values[1].ToString();//STREET
            this.firstName0.InnerHtml = values[2].ToString();//ZIPCODE
            this.email0.InnerHtml = values[3].ToString();//CITY
            this.creditCard0.InnerHtml = values[4].ToString();//COUNTRY
        }
    }
}