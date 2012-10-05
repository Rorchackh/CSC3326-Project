using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIRKT.Manage_Category
{
    public partial class Add_Category : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlDataReader dataReader;
        public Add_Category()
        {
            InitializeComponent();
        }
        //===================================================

        private void Add_Vendor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khobalatte_aDataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.khobalatte_aDataSet.CATEGORY);
            this.connection.ConnectionString =
                "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                // Connect to your database
                this.connection.Open();
                // Create an SQL command = a Query ze3ma
                SqlCommand command = new SqlCommand("select cat_name from category", this.connection);
                //Execute query and get results
                this.dataReader = command.ExecuteReader();
                //Add the Vendor Codes to the Vendor ComboBox
                while (this.dataReader.Read())
                {
                    //this.comboBox1.Items.Add(this.dataReader[0]);
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



        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            // Format the Date value from the DateTimePicker to month/day/year

            if (this.textBox1.Text == "" || this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "")
            {
                MessageBox.Show("Please Make sure you fill in all fields", "Data is missing");
            }
            else
            {
                this.connection.ConnectionString =
                    "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
                try
                {
                    // Connect to your database
                    this.connection.Open();

                    // Create an SQL command = a Query ze3ma
                    string query = "insert into category values("+
                                                                this.textBox2.Text // cat_id
                                                                + ",'" + this.textBox1.Text //cat_name
                                                                + "','" + this.textBox3.Text//cat_descript                                                     
                                                                + "'," + (this.comboBox1.SelectedValue) //sup_id
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWithStyle3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }






        //=====================================================
    }
}