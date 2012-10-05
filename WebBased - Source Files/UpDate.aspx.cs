using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Default2 : System.Web.UI.Page
{
    public SqlConnection connection = new SqlConnection();
    public SqlDataReader dataReader;
    string ErrorList = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.Form["id"];
        
        ErrorList += "User ID is: " + id;
        int cnt = 0;
        string result="";
        this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
        for (cnt = 0; cnt < 100; cnt++)
        {   //removes the line
            
           ErrorList += result;
            if (result == null || result == "")
            {
                
                //updates the quantity
                result = Request.Form["remove_name[" + cnt + "]"];
                if (result != null && result != "")
                {
                    if (result != null)
                    {
                        ErrorList += "<b>"+result+"</b>";
                        update_line(cnt, Int32.Parse(result));
                    }
                }
            }
            else
            {
                
                remove_line(cnt);
            }
        }

        ErrorList+="<br><input type=\"button\" value=\"continue\" onclick=\"window.location='Cart.aspx?id="+id+"'\"/>";
        Debugger.InnerHtml = ErrorList;
    }
    protected void update_line(int cnt,int Qty)
    {   
        string sql = "update line set line_unit=" + Qty + " Where line_num=" + cnt;
        try
        {
            SqlCommand command = new SqlCommand(sql, this.connection);
            command.ExecuteNonQuery();
        }
        catch (SqlException exe)
        {
            ErrorList += "<br>SQL Error in UPDATE LINE</br>";
        }
          
    }
    protected void remove_line(int cnt)
    {
        string sql = "delete from line where line_num=" + cnt;
        try
        {
            SqlCommand command = new SqlCommand(sql, this.connection);
            command.ExecuteNonQuery();
        }
        catch (SqlException exe)
        {
            ErrorList += "<br>SQL Error in REMOVE LINE</br>";
        }
    }
}