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
    string id2 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["err"];
        id2 = Request.QueryString["id"];
        if (id2 != "" && id2 != "0" && id2 != null)
            Response.Redirect("MyAccount.aspx?id="+id2);
        Label7.Text = id;
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
        string userName = this.TextBox1.Text;
        string email = this.TextBox2.Text;
        string password = this.TextBox4.Text;
        string lastName = this.TextBox5.Text;
        string firstName = this.TextBox6.Text;
        if (TextBox4.Text != TextBox3.Text)
        {
            Response.Redirect("Register.aspx?err=The Password and confirmation Password must much");
           
        }
       
        this.connection = new SqlConnection();
        this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        try
        {

            this.connection.Open();
            //id = CreateUserWizard1.UserName.ToString();

            string sql = "INSERT INTO Customer values(" + userName + ",'" + lastName + "', ' " + firstName + " ', '" + email + "', null, null, '" + password + "', " + userName + ", null)";
            SqlCommand cmd = new SqlCommand("insert into addresse values(" + userName + ",0,' ',0,' ',' ')", this.connection);
            //row = cmd.ExecuteNonQuery(); 
            cmd = new SqlCommand(sql, this.connection);
            int row = cmd.ExecuteNonQuery();
            //cmd= new SqlCommand("insert into addresse values("+userName+",,,,,",this.connection);
            //row = cmd.ExecuteNonQuery();
            Response.Redirect("myAccount.aspx?id=" + userName);
        }
        catch (SqlException sql)
        {
            Response.Redirect("Register.aspx?err=This ID already exists");
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
