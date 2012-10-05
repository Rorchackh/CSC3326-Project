using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIRKT.Manage_Vendor
{
    public partial class AddVendorForm : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlDataReader dataReader;
        public AddVendorForm()
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
                SqlCommand command = new SqlCommand("select add_id from addresse", this.connection);
                //Execute query and get results
                this.dataReader = command.ExecuteReader();
                //Add the PIRKT.Manage_Vendor Codes to the PIRKT.Manage_Vendor ComboBox
                while (this.dataReader.Read())
                {
                    this.comboBox1.Items.Add(this.dataReader[0]);
                }
                //Set PIRKT.Manage_Vendor ComboBox to the 1st value in the DropDown List
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



        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            // Format the Date value from the DateTimePicker to month/day/year

            if (this.textBox1.Text == "" || this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox4.Text == "")
            {
                MessageBox.Show("Data is missing", "Please Make sure you fill in all fields");
            }
            this.connection.ConnectionString =
                "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                // Connect to your database
                this.connection.Open();

                // Create an SQL command = a Query ze3ma
                string query = "insert into Vendor values(" +
                                                            this.textBox1.Text // p_code
                                                            + ",'" + this.textBox2.Text //p_descript
                                                            + "'," + this.textBox3.Text
                                                            + "," + this.textBox3.Text + this.textBox4.Text
                                                            + "," + ((int)this.comboBox1.SelectedItem)//add_id
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

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonWithStyle3_Click(object sender, EventArgs e)
        {

            
            
        }






        //=====================================================
    }
}