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
    string id,err;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["id"];
        err= Request.QueryString["err"];
        if (id == "" || id == null)
        {
            Response.Redirect("Login.aspx");
        }
        recaptcha.Enabled = false;
        recaptcha.Visible = false;
        if (err == "1")
        {
            Label7.Text = "The Password and confirmation Password must much";
        }
        if(err=="2")
        {
            Label7.Text = "You've typed an incorrect Old Passwors";
            recaptcha.Visible = true;
            recaptcha.Enabled = true;
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
       
        string oldPassword = this.TextBox2.Text;
        string NewPassword = this.TextBox4.Text;
        if (TextBox4.Text != TextBox3.Text)
        {
            Response.Redirect("EditPassword.aspx?id="+id+"&err=1");
           
        }
       
        this.connection = new SqlConnection();
        this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {

            this.connection.Open();
            //id = CreateUserWizard1.UserName.ToString();

            string sql = "select cus_password from customer where cus_id="+id;
            SqlCommand cmd =new SqlCommand(sql, this.connection);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            if ((read[0].ToString()) != oldPassword)
            {
                Response.Redirect("EditPassword.aspx?id=" + id + "&err=2");


            }
            else
            {
                read.Close();
                cmd = new SqlCommand("update customer set cus_password='"+NewPassword+"' where cus_id="+id, this.connection);
                cmd.ExecuteNonQuery();
                
            }
            //cmd= new SqlCommand("insert into addresse values("+userName+",,,,,",this.connection);
            //row = cmd.ExecuteNonQuery();
            Response.Redirect("myAccount.aspx?id=" + id);
        }
        catch (SqlException sql)
        {
            Response.Redirect("" + sql.Errors.ToString());
        }
        finally
        {
            if (connection != null)
                connection.Close();
        }

    }
    protected void CheckPassword(object sender, EventArgs e)
    {
       

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
