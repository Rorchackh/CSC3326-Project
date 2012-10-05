using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIRKT.Manage_Customer
{
    public partial class AddAccount : Form
   {
        private SqlConnection connection;
        private SqlDataReader dataReader;
    
        public AddAccount()
        {
            InitializeComponent();
            this.connection = new SqlConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                // Connect to your database
                this.connection.Open();

                //Check if input is valid, here that means if boxes are filled! 

                if (
                    this.textBox10.Text == "" ||this.textBox11.Text == "" ||this.textBox12.Text == "" ||
                    this.textBox13.Text == "" ||this.textBox14.Text == "" ||this.textBox15.Text == "" ||this.textBox16.Text == "" ||
                    this.textBox17.Text == "" ||this.textBox18.Text == "" ||this.textBox19.Text == "" ||this.textBox20.Text == ""){

                        MessageBox.Show("Please fill all the forms!", "Invalid input");
                }
                
                // Create an SQL command = a Query ze3ma
                else if (this.textBox14.Text != this.textBox15.Text) {
                    MessageBox.Show("Passwords don't match, please try gain!", "Invalid input!");
                }

                else
                {
 
                    try
                    {
                        string query1 = "insert into ADDRESSE (add_id, add_num, add_street, add_zipcode, add_city, add_country) values("+
                                                                 this.numericUpDown1.Value
                                                                 + "," + this.textBox21.Text
                                                                 + ",'" + this.textBox17.Text // p_code
                                                                 + "','" + this.textBox18.Text
                                                                 + "','" + this.textBox19.Text
                                                                 + "','" + this.textBox20.Text
                                                                 + "')";
                        SqlCommand command1 = new SqlCommand(query1, this.connection);

                        //Execute query and get number of rows affected
                        int rows1 = command1.ExecuteNonQuery();
                        MessageBox.Show(rows1 + " rows affected!", "Insert in ADDRESSE completed successfully!");
                     
                        string query2 = "select GRO_discount from groupe where gro_name = '" + this.comboBox1.SelectedItem.ToString()+"'";
                        SqlCommand command2 = new SqlCommand(query2, this.connection);
                        this.dataReader = command2.ExecuteReader();

                        
                            string query3 = "insert into Customer (cus_id, cus_lname, cus_fname, cus_email, cus_areacode,cus_phone, cus_password, gro_discount, add_id) values(" +
                                                                        this.numericUpDown1.Value
                                                                        + ",'" + this.textBox11.Text // p_code
                                                                        + "','" + this.textBox16.Text
                                                                        + "','" + this.textBox12.Text
                                                                        + "','" + this.textBox13.Text
                                                                        + "','" + this.textBox10.Text
                                                                        + "','" + this.textBox15.Text;
                                                                        

                            while (this.dataReader.Read())
                            {
                            query3 +=  "'," + this.dataReader[0]+ "," + this.numericUpDown1.Value + ")";
                            }
                            this.dataReader.Close();
                            SqlCommand command3 = new SqlCommand(query3, this.connection);
                            //Execute query and get number of rows affected
                            int rows3 = command3.ExecuteNonQuery();
                            MessageBox.Show(rows3 + " rows affected!", "Insert CUSTOMER completed successfully!");
                        }
                    catch (SqlException sqle)
                    {
                        MessageBox.Show(sqle.Message, "SQL Exception Occured!");
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
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message, "SQL Exception Occured!");
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

        private void AddAccount_Load(object sender, EventArgs e)
        {
            this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                // Connect to your database
                this.connection.Open();
                // Create an SQL command = a Query ze3ma
                SqlCommand command = new SqlCommand("select distinct GRO_NAME from GROUPE", this.connection);
                //Execute query and get results
                this.dataReader = command.ExecuteReader();
                //Add the Vendor Codes to the Vendor ComboBox
                while (this.dataReader.Read())
                {
                    this.comboBox1.Items.Add(this.dataReader[0]);
                }
                    //Set Vendor ComboBox to the 1st value in the DropDown List
                    this.comboBox1.SelectedIndex = 0;
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message, "SQL Exception Occured!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            /*this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";*/
            this.textBox10.Text = "";
            this.textBox11.Text = "";
            this.textBox12.Text = "";
            this.textBox13.Text = "";
            this.textBox14.Text = "";
            this.textBox15.Text = "";
            this.textBox16.Text = "";
            this.textBox17.Text = "";
            this.textBox18.Text = "";
            this.textBox19.Text = "";
            this.textBox20.Text = "";
            this.textBox21.Text = "";
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {

            this.connection.ConnectionString = "server=192.168.3.3;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                // Connect to your database
                this.connection.Open();

                //Check if input is valid, here that means if boxes are filled! 

                if (
                    this.textBox10.Text == "" || this.textBox11.Text == "" || this.textBox12.Text == "" ||
                    this.textBox13.Text == "" || this.textBox14.Text == "" || this.textBox15.Text == "" || this.textBox16.Text == "" ||
                    this.textBox17.Text == "" || this.textBox18.Text == "" || this.textBox19.Text == "" || this.textBox20.Text == "")
                {

                    MessageBox.Show("Please fill all the forms!", "Invalid input");
                }

            // Create an SQL command = a Query ze3ma
                else if (this.textBox14.Text != this.textBox15.Text)
                {
                    MessageBox.Show("Passwords don't match, please try gain!", "Invalid input!");
                }

                else
                {

                    try
                    {
                        string query1 = "insert into ADDRESSE (add_id, add_num, add_street, add_zipcode, add_city, add_country) values(" +
                                                                 this.numericUpDown1.Value
                                                                 + "," + this.textBox21.Text
                                                                 + ",'" + this.textBox17.Text // p_code
                                                                 + "','" + this.textBox18.Text
                                                                 + "','" + this.textBox19.Text
                                                                 + "','" + this.textBox20.Text
                                                                 + "')";
                        SqlCommand command1 = new SqlCommand(query1, this.connection);

                        //Execute query and get number of rows affected
                        int rows1 = command1.ExecuteNonQuery();
                        MessageBox.Show(rows1 + " rows affected!", "Insert in ADDRESSE completed successfully!");

                        string query2 = "select GRO_discount from groupe where gro_name = '" + this.comboBox1.SelectedItem.ToString() + "'";
                        SqlCommand command2 = new SqlCommand(query2, this.connection);
                        this.dataReader = command2.ExecuteReader();


                        string query3 = "insert into Customer (cus_id, cus_lname, cus_fname, cus_email, cus_areacode,cus_phone, cus_password, gro_discount, add_id) values(" +
                                                                    this.numericUpDown1.Value
                                                                    + ",'" + this.textBox11.Text // p_code
                                                                    + "','" + this.textBox16.Text
                                                                    + "','" + this.textBox12.Text
                                                                    + "','" + this.textBox13.Text
                                                                    + "','" + this.textBox10.Text
                                                                    + "','" + this.textBox15.Text;


                        while (this.dataReader.Read())
                        {
                            query3 += "'," + this.dataReader[0] + "," + this.numericUpDown1.Value + ")";
                        }
                        this.dataReader.Close();
                        SqlCommand command3 = new SqlCommand(query3, this.connection);
                        //Execute query and get number of rows affected
                        int rows3 = command3.ExecuteNonQuery();
                        MessageBox.Show(rows3 + " rows affected!", "Insert CUSTOMER completed successfully!");
                    }
                    catch (SqlException sqle)
                    {
                        MessageBox.Show(sqle.Message, "SQL Exception Occured!");
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
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message, "SQL Exception Occured!");
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

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            /*this.textBox1.Text = "";
           this.textBox2.Text = "";
           this.textBox3.Text = "";
           this.textBox4.Text = "";
           this.textBox5.Text = "";
           this.textBox6.Text = "";
           this.textBox7.Text = "";
           this.textBox8.Text = "";*/
            this.textBox10.Text = "";
            this.textBox11.Text = "";
            this.textBox12.Text = "";
            this.textBox13.Text = "";
            this.textBox14.Text = "";
            this.textBox15.Text = "";
            this.textBox16.Text = "";
            this.textBox17.Text = "";
            this.textBox18.Text = "";
            this.textBox19.Text = "";
            this.textBox20.Text = "";
            this.textBox21.Text = "";
        }

        private void buttonWithStyle3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}