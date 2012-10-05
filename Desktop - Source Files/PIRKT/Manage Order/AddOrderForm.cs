using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIRKT.Manage_Order
{
    public partial class AddOrderForm : Form
    {
        private SqlConnection connection;
        private SqlDataReader dataReader;
        public AddOrderForm()
        {

            InitializeComponent();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Will Reset Everything ?", 
                "Reset Form", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.textBox1.Text = "";
                this.dateTimePicker1.Value = System.DateTime.Now;
                this.dateTimePicker2.Value = System.DateTime.Now;
                this.comboBox1.ResetText();
                this.comboBox2.ResetText();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddOrderForm_Load(object sender, EventArgs e) {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=SSEDB; database = khobalatte_a; user = khobalatte_a; password=newpassword";

            try
            {
                this.connection.Open();

                SqlCommand command = new SqlCommand("SELECT CAR_ID FROM CART", this.connection);
                this.dataReader = command.ExecuteReader();
                while (this.dataReader.Read())
                    this.comboBox2.Items.Add(this.dataReader[0]);

                this.comboBox2.SelectedIndex = 0;
            }
            catch (SqlException sqle) {
                MessageBox.Show(sqle.Message, "SQL Exception Occured");
            }
            finally
            {
                if (this.dataReader != null)
                    this.dataReader.Close();
                if (this.connection != null)
                    this.connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startdate = this.dateTimePicker1.Value.Month + "/" + this.dateTimePicker1.Value.Day + "/" + this.dateTimePicker1.Value.Year;
            string enddate = this.dateTimePicker2.Value.Month + "/" + this.dateTimePicker1.Value.Day + "/" + this.dateTimePicker1.Value.Year;

            this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                this.connection.Open();
                string query = "insert into Ordere values('" +
                                                            this.textBox1.Text // p_code
                                                            + "','" + this.comboBox1.SelectedItem //p_descript
                                                            + "','" + startdate //p_indate
                                                            + "','" + enddate
                                                            + "'," + ((int)this.comboBox2.SelectedItem)//V_code
                                                            + ")";

                SqlCommand command = new SqlCommand(query, this.connection);
                int rows = command.ExecuteNonQuery();
                MessageBox.Show(rows + " Rows affected!", "Insert Completed Successfully!");
                this.Dispose();

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            string startdate = this.dateTimePicker1.Value.Month + "/" + this.dateTimePicker1.Value.Day + "/" + this.dateTimePicker1.Value.Year;
            string enddate = this.dateTimePicker2.Value.Month + "/" + this.dateTimePicker1.Value.Day + "/" + this.dateTimePicker1.Value.Year;


            if (this.textBox1.Text == "" ) {

                MessageBox.Show("Please Make sure you fill in all fields", "Data is missing");
            
            }


            else
            {

                this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
                try
                {
                    this.connection.Open();
                    string query = "insert into Ordere values('" +
                                                                this.textBox1.Text // p_code
                                                                + "','" + this.comboBox1.SelectedItem //p_descript
                                                                + "','" + startdate //p_indate
                                                                + "','" + enddate
                                                                + "'," + ((int)this.comboBox2.SelectedItem)//V_code
                                                                + ")";

                    SqlCommand command = new SqlCommand(query, this.connection);
                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show(rows + " Rows affected!", "Insert Completed Successfully!");
                    this.Dispose();

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

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Will Reset Everything ?",
               "Reset Form", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.textBox1.Text = "";
                this.dateTimePicker1.Value = System.DateTime.Now;
                this.dateTimePicker2.Value = System.DateTime.Now;
                this.comboBox1.ResetText();
                this.comboBox2.ResetText();
            }
        }

        private void buttonWithStyle3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}