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
    private SqlConnection connection;
    private SqlDataReader dataReader;
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["id"];
      
        if (id == "" || id == null)
        {
            Response.Redirect("Login.aspx");
        }
    }/*
    public bool capchaIsValid()
    {

        return true;
        /*
        ccJoin.ValidateCaptcha(this.TexteBox1.Text);
        if (!ccJoin.UserValidated)
        {
            //Inform user that his input was wrong ...
            return;
        }*/
    protected void Button2_Click(object sender, EventArgs e)
    {
        string NUm = this.TextBox1.Text;
        string Street = this.TextBox2.Text;
        string ZipCode = this.TextBox3.Text;
        string City = this.TextBox4.Text;
        string countries = this.Answer.Text;
       
         this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
             {

                 this.connection.Open();

                 string sql = "update addresse set add_num='"+ NUm + "',add_street='" +Street + "',add_zipcode="+ZipCode+", add_city='" + City + "', add_country='" + countries+ "' where add_id="+id;
                 SqlCommand cmd = new SqlCommand(sql, this.connection);
                 int row = cmd.ExecuteNonQuery();
                 Response.Redirect("MyAccount.aspx?id="+id);
             }
             catch (SqlException sql)
             {
                 Response.Redirect(sql.Errors.ToString());
             } finally{
                if (connection != null)
                    connection.Close();
            }
        }

    }

   /*
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        if (capchaIsValid())
        {   
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
             {

                 this.connection.Open();
                 id = CreateUserWizard1.UserName.ToString();
                 string sql = "INSERT INTO Customer values("+CreateUserWizard1.UserName.ToString()+",'" + CreateUserWizard1.Question.ToString() +"', ' " + CreateUserWizard1.Answer.ToString()+" ', '" + CreateUserWizard1.Email.ToString() + "', null, null, '"+CreateUserWizard1.Password.ToString()+ "', 1, null)";
                 SqlCommand cmd = new SqlCommand(sql, this.connection);
                 int row = cmd.ExecuteNonQuery();
             }
             catch (SqlException sql)
             {
             } finally{
                if (connection != null)
                    connection.Close();
            }
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        /*ccJoin.ValidateCaptcha();
        if (!ccJoin.UserValidated)
        {
            //Inform user that his input was wrong ...
            return;
        }*/
/*
}

protected void ContinueButton_Click(object sender, EventArgs e)
{
CreateUserWizard1_CreatedUser(null, null);
Response.Redirect("MyAccount?id=" + id);
}
}*/
