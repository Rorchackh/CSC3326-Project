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
    public partial class Modify : Form
    {
        SqlConnection connection = new SqlConnection();
        public int param;

        SqlDataReader dataReader;
        
        public Modify(int cat_id)
        {
            InitializeComponent();
            this.param = cat_id;
        }
        

        private void Modify_Load(object sender, EventArgs e)
        {

            
            
            connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            
            connection.Open();

            SqlCommand command1 = new SqlCommand("select cat_id from category", this.connection);

            this.dataReader = command1.ExecuteReader();

            while (this.dataReader.Read())
            {
                this.comboBox1.Items.Add(this.dataReader[0]);
            }

            this.comboBox1.SelectedIndex = 0;

            dataReader.Close();



            String query = "select * from category where cat_id =" + param;
                SqlCommand command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {

                    int emp = int.Parse(dataReader[0].ToString());
                    this.textBox1.Text = emp.ToString();                    
                    
                    this.textBox2.Text = dataReader[1].ToString();
                    this.textBox3.Text = dataReader[2].ToString();

                    emp = int.Parse(dataReader[3].ToString());
                    this.comboBox1.SelectedValue = emp.ToString();

                    
                }


               
                
            


                connection.Close();
                dataReader.Close();



        }

        private void buttonWithStyle3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.comboBox1.SelectedValue = 0;
        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            if (this.textBox2.Text == "" || this.textBox3.Text == "")
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
                    string query = "update category " +
                                               " set cat_name = '" + this.textBox2.Text // cat_id
                                             + "' ,  cat_descript ='" + this.textBox3.Text //cat_name
                                             + "' ,  sup_id = " + this.comboBox1.SelectedItem //sup_id
                                             + " where cat_id = "    + param;     
                                                   
                    SqlCommand command = new SqlCommand(query, this.connection);

                    //Execute query and get number of rows affected
                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show(rows + " Update Successfull", "Update");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}