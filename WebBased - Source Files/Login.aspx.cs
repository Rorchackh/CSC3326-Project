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
    private SqlConnection connection;
    private SqlDataReader dataReader;

    string[] list = { "", "", "", "", "", "", "", "", "", "", "", "" };
    protected void Page_Load(object sender, EventArgs e){
        string kaka = Request.QueryString["err"];
        string id = "";
        id = Request.QueryString["id"];
        if (id == null || id == "" || !id.Equals("0"))
        {
            Response.Redirect("Default.aspx?id=0");
        }
        if(kaka == "1"){
            Label1.Text = "Please Enter a valid Email or Password";
        }
        else if (kaka == "2") {
            Label1.Text = "The Verification patcha code is not valid. Please Retry";
        }
    }
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
    }
   
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        if (capchaIsValid())
        {
            
            this.connection = new SqlConnection();
            this.dataReader = null;
            string ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            this.connection.ConnectionString = ConnectionString;
            /*try
             {

                 this.connection.Open();
                 string sql = "INSERT INTO Customers values(123,'" +
                     + CreateUserWizard1. + "', '' ,'" 
                     + CreateUserWizard1.Email.ToString() + "','','" + CreateUserWizard1  "')";
                 SqlCommand cmd = new SqlCommand(sql, this.connection);
                 this.dataReader = cmd.ExecuteReader();
                 while (this.dataReader.Read())
                 {

                     ListItem items = new ListItem(this.dataReader[0].ToString());
                     Control ctrl = new Control();
                    // this.BulletedList1.Items.Add(this.dataReader[0].ToString());
                 }
             }
             catch (SqlException sql)
             {
             }*/
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
    }


    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        if (capchaIsValid())
        {
            this.connection = new SqlConnection();
            string login = this.Login1.UserName;
            string password = this.Login1.Password;

            this.connection.ConnectionString =
                   "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                // Connect to your database
                this.connection.Open();
                // Create an SQL command = a Query ze3ma
                SqlCommand command = new SqlCommand("SELECT cus_id from customer where cus_id='" + login + "' and cus_password='" + password + "'", this.connection);
                //Execute query and get results
                this.dataReader = command.ExecuteReader();
                if (this.dataReader.Read())
                {
                    Response.Redirect("MyAccount.aspx?id=" + dataReader[0].ToString());
                }
                else
                {
                    Response.Redirect("Login.aspx?err=1&id=0");

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
        } else {
            Response.Redirect("Login.aspx?err=2");
        }
    }
}
