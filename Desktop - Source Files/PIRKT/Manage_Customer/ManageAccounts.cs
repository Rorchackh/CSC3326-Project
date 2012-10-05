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
    public partial class ManageAccounts : Form {
        private SqlConnection connection;
        private DataSet accDataSet = new DataSet();
        private SqlDataAdapter dataAdapter;
        public BindingSource bindingSource = new BindingSource();
        public ManageAccounts()
        {
            InitializeComponent();
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            ManageAccounts_Load(null, null);
        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khobalatte_aDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer");
            addressInfoUpdate();
            this.groupBox1.Enabled = false;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.Owner = this;
            addAccount.Show();
        }
        private void tableUpdate(String query)
        {
            try
            {
                this.connection.Open();
                this.dataAdapter = new SqlDataAdapter(query, this.connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(this.dataAdapter);
                this.dataAdapter.Fill(this.accDataSet, "Customer");

                this.bindingSource.DataSource = this.accDataSet;
                this.bindingSource.DataMember = "Customer";


                this.dataGridView1.DataSource = this.bindingSource;
                //    this.dataGridView1.DataMember = "Customer";


                this.bindingNavigator1.BindingSource = this.bindingSource;

            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message, "Sql Exception Occured");
            }
            finally
            {
                if (this.connection != null)
                    this.connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.groupBox1.Enabled == false)
            {
                this.groupBox1.Enabled = true;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
            }
            else
            {
                this.groupBox1.Enabled = false;
                this.accDataSet.Tables[0].Clear();
                tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer");
                this.bindingNavigatorAddNewItem.Enabled = true;
                this.bindingNavigatorDeleteItem.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.accDataSet.Tables[0].Clear();
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer where cus_id like '" + textBox3.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.accDataSet.Tables[0].Clear();
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer where cus_lname like '" + textBox2.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            this.accDataSet.Tables[0].Clear();
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer where cus_fname like '" + textBox16.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            this.accDataSet.Tables[0].Clear();
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer where cus_email like '" + textBox15.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            this.accDataSet.Tables[0].Clear();
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer where cus_areacode like '" + textBox14.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.accDataSet.Tables[0].Clear();
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer where cus_phone like '" + textBox5.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.accDataSet.Tables[0].Clear();
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer where cus_password like '" + textBox4.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            this.accDataSet.Tables[0].Clear();
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer where gro_discount like '" + textBox17.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            this.accDataSet.Tables[0].Clear();
            tableUpdate("select cus_id as ID, cus_lname as LastName, cus_fname as FirstName, cus_email as Email, cus_areacode as Areacode, cus_phone as Phone, cus_password as Password, gro_discount as Discount, add_id as Address from customer where add_id like '" + textBox18.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }
        private void addressInfoUpdate()
        {

            SqlDataReader dataReader;
            SqlConnection connex = new SqlConnection();
            connex.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex.Open();
            int add_id = 0;
            try
            {
                add_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Address"].Value;
            }
            catch (NullReferenceException ex) {
                System.Console.WriteLine(ex.ToString());
            }
            String query = "select * from addresse where add_id = " + add_id;
            SqlCommand command = new SqlCommand(query, connex);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string row = "\n\n" +
                "Address Number - " + dataReader[1] +
                "\nAddress Street  - " + dataReader[2] +
                 "\nAddress ZipCode - " + dataReader[3] +
                 "\nAddress City  - " + dataReader[4] +
                "\nAddress Country  - " + dataReader[5];

                this.richTextBox1.Text = row;
            }

            connex.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.Owner = this;
            addAccount.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataAdapter.Update(this.accDataSet, "Customer");
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addressInfoUpdate();
        }

        public Panel getPanel() {
            return this.panel1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //this.dataAdapter.Update(this.accDataSet, "Customer");
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataAdapter.Update(this.accDataSet, "Customer");
        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
     }
}
