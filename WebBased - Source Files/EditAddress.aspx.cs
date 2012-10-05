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
        
        id=Request.QueryString["id"];
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
            this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
             {

                 this.connection.Open();

                 string sql = "INSERT INTO ADDRESSE values("+id+",'"+ CreateUserWizard1.UserName.ToString() + "','" + CreateUserWizard1.Email.ToString() + "', '00000', '" + CreateUserWizard1.Email.ToString() + "', '" + CreateUserWizard1.Question.ToString() + "','" + CreateUserWizard1.Answer.ToString() + "')";
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
    }

    protected void ContinueButton_Click(object sender, EventArgs e)
    {
        CreateUserWizard1_CreatedUser(null, null);
        Response.Redirect("MyAccount?id=" + id);
    }
}
