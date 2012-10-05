using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIRKT.Manage_Product
{
    public partial class product_ADD : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlDataReader dataReader;
        SqlDataReader dataReader2;
        SqlDataReader dataReader3;
        public product_ADD()
        {
            InitializeComponent();
        }
        //===================================================

        private void Add_Vendor_Load(object sender, EventArgs e)
        {
            this.connection.ConnectionString =
                "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                // Connect to your database
                this.connection.Open();
                // Create an SQL command = a Query ze3ma
                SqlCommand command1 = new SqlCommand("select * from category", this.connection);
                SqlCommand command2 = new SqlCommand("select * from vendor", this.connection);
                SqlCommand command3 = new SqlCommand("select distinct p_status from product", this.connection);
                //Execute query and get results
                this.dataReader = command1.ExecuteReader();
                //Add the Vendor Codes to the Vendor ComboBox
                while (this.dataReader.Read())
                {
                    this.comboBox1.Items.Add(this.dataReader[0]);
                }
                /***************************************/

                //Set Vendor ComboBox to the 1st value in the DropDown List
                this.comboBox1.SelectedIndex = 0;
                dataReader.Close();

                this.dataReader = command2.ExecuteReader();
                //Add the Vendor Codes to the Vendor ComboBox
                while (this.dataReader.Read())
                {
                    this.comboBox2.Items.Add(this.dataReader[0]);
                }
                //Set Vendor ComboBox to the 1st value in the DropDown List
                this.comboBox2.SelectedIndex = 0;

                dataReader.Close();
                /************************************************/

                this.dataReader = command3.ExecuteReader();
                //Add the Vendor Codes to the Vendor ComboBox
                while (this.dataReader.Read())
                {
                    this.comboBox3.Items.Add(this.dataReader[0]);
                }
                //Set Vendor ComboBox to the 1st value in the DropDown List
                this.comboBox3.SelectedIndex = 0;


               
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

        



        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            // Format the Date value from the DateTimePicker to month/day/year

            
           


            if (this.textBox1.Text == "" || this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "")
            {
                MessageBox.Show("Please Make sure you fill in all fields","Data is missing" );
            }


            else
            {
                this.connection.ConnectionString =
                    "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
                try
                {
                    // Connect to your database
                    this.connection.Open();

                    string date = this.dateTimePicker1.Value.Month + "/" + this.dateTimePicker1.Value.Day + "/" + this.dateTimePicker1.Value.Year;

                    // Create an SQL command = a Query ze3ma
                    string query = "insert into product values(" +
                                                                this.textBox1.Text // pro_id
                                                                + ",'" + this.textBox3.Text //pro_descript

                                                                + "','" + this.textBox2.Text //pro_name

                                                                + "'," + (this.numericUpDown2.Value)//pro_QOH

                                                                + "," + (this.numericUpDown1.Value)//pro_price

                                                                + "," + (this.comboBox2.SelectedItem)//ved_id

                                                                + "," + (this.comboBox1.SelectedItem)//cat_id

                                                                + ",'" + (this.comboBox3.SelectedItem)//p_status

                                                                + "','" + date // pro_indate 

                                                                + "'," + (this.numericUpDown3.Value) //pro_min
                                                                + ")";
                    
                    

                    SqlCommand command = new SqlCommand(query, this.connection);

                    //Execute query and get number of rows affected
                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show(rows + " rows affected!", "Insert completed successfully!");

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
                this.Close();
            }
        }

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWithStyle4_Click(object sender, EventArgs e)
        {
            PIRKT.Manage_Vendor.AddVendorForm v = new PIRKT.Manage_Vendor.AddVendorForm();
            this.Visible = false;
            v.Owner = this;
            v.Show();
        }

        private void buttonWithStyle3_Click(object sender, EventArgs e)
        {
            
            PIRKT.Manage_Category.Add_Category c = new PIRKT.Manage_Category.Add_Category();
            this.Visible = false ;
            c.Owner = this;
            c.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }






        //=====================================================
    }
}