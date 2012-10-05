using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIRKT.Manage_Invoice
{
    public partial class AddInvoiceForm : Form
    {
        private SqlConnection connection;
        private SqlDataReader dataReader;
        public AddInvoiceForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void AddInvoiceForm_Load(object sender, EventArgs e)
        {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=SSEDB; database = khobalatte_a; user = khobalatte_a; password=newpassword";

            try
            {
                this.connection.Open();

                SqlCommand command = new SqlCommand("SELECT ord_id FROM ordere where status = 0", this.connection);
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
        SqlDataReader dt;
        private void button1_Click_1(object sender, EventArgs e)
        {
            string date = this.dateTimePicker1.Value.Month + "/" + this.dateTimePicker1.Value.Day + "/" + this.dateTimePicker1.Value.Year;

            this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                this.connection.Open();
               
                SqlCommand cm = new SqlCommand("select sum(unit_price* line_unit) from line l join ordere o on o.car_id = l.car_id where ord_id = " + this.comboBox2.SelectedItem , this.connection);
                this.dt = cm.ExecuteReader();
                string amount = "";
                while (dt.Read())
                    amount += this.dt[0];
                this.connection.Close();
                this.connection.Open();
                string query;
                if (amount == "")
                {
                    amount = " 0 ";
                    query = "insert into INVOICE values('" +
                                                            this.textBox1.Text // p_code
                                                            + "','" + date //p_indate
                                                            + "'," + amount
                                                            + "," + ((int)this.comboBox2.SelectedItem)//V_code
                                                            + ")";
                }
                else
                {
                    query = "insert into INVOICE values('" +
                                                            this.textBox1.Text // p_code
                                                            + "','" + date //p_indate
                                                            + "'," + amount
                                                            + "," + ((int)this.comboBox2.SelectedItem)//V_code
                                                            + ")";
                }

                SqlCommand command2 = new SqlCommand(query, this.connection);
                int rows = command2.ExecuteNonQuery();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Will Reset Everything ?",
                "Reset Form", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.textBox1.Text = "";
                this.dateTimePicker1.Value = System.DateTime.Now;
                this.comboBox2.ResetText();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            string date = this.dateTimePicker1.Value.Month + "/" + this.dateTimePicker1.Value.Day + "/" + this.dateTimePicker1.Value.Year;

            this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            try
            {
                this.connection.Open();

                SqlCommand cm = new SqlCommand("select sum(unit_price* line_unit) from line l join ordere o on o.car_id = l.car_id where ord_id = " + this.comboBox2.SelectedItem, this.connection);
                this.dt = cm.ExecuteReader();
                string amount = "";
                while (dt.Read())
                    amount += this.dt[0];
                this.connection.Close();
                this.connection.Open();
                string query;
                if (amount == "")
                {
                    amount = " 0 ";
                    query = "insert into INVOICE values('" +
                                                            this.textBox1.Text // p_code
                                                            + "','" + date //p_indate
                                                            + "'," + amount
                                                            + "," + ((int)this.comboBox2.SelectedItem)//V_code
                                                            + ")";
                }
                else
                {
                    query = "insert into INVOICE values('" +
                                                            this.textBox1.Text // p_code
                                                            + "','" + date //p_indate
                                                            + "'," + amount
                                                            + "," + ((int)this.comboBox2.SelectedItem)//V_code
                                                            + ")";
                }

                SqlCommand command2 = new SqlCommand(query, this.connection);
                int rows = command2.ExecuteNonQuery();
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

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonWithStyle3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.dateTimePicker1.Value = System.DateTime.Now;
            this.comboBox2.ResetText();
        }
    }
}