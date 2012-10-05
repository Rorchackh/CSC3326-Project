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

  
    public partial class ManageInvoiceForm : Form
    {
        private SqlConnection connection;
        private DataSet invoiceDataSet = new DataSet();
        private SqlDataAdapter dataAdapter;
        int kaka = 0;
        public ManageInvoiceForm()
        {
            InitializeComponent();
            this.label12.Text = this.label13.Text = this.label14.Text = "N/A";
            this.linkLabel1.Enabled = false;
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            ManageInvoiceForm_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = this.textBox4.Text = "";
            this.saveToolStripButton.Enabled = true;
            this.invoiceDataSet.Tables[0].Clear();
            tableUpdate("select * from invoice");
        }

        public Panel getPanel() {
            return mainPanel;
        }

        private void ManageInvoiceForm_Load(object sender, EventArgs e)
        {
            tableUpdate("select * from invoice");
                        
        }

        private void tableUpdate(String query)
        {

            try
            {
                this.connection.Open();
                this.dataAdapter = new SqlDataAdapter(query, this.connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(this.dataAdapter);
                this.dataAdapter.Fill(this.invoiceDataSet, "INVOICE");

                this.iNVOICEBindingSource.DataSource = this.invoiceDataSet;
                this.iNVOICEBindingSource.DataMember = "INVOICE";


                this.dataGridView1.DataSource = this.iNVOICEBindingSource;
                //    this.dataGridView1.DataMember = "PIRKT.Manage_Vendor";


                this.bindingNavigator1.BindingSource = this.iNVOICEBindingSource;

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

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataAdapter.Update(this.invoiceDataSet, "Invoice");
        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = this.textBox4.Text = "";
            this.saveToolStripButton.Enabled = true;
            this.invoiceDataSet.Tables[0].Clear();
            tableUpdate("select * from invoice");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String inv = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["number"].Value.ToString();
                if (inv != "")
                {
                    AdditionaInfoUpdate();
                }
            } catch(ArgumentException ex){}
        }

        private void AdditionaInfoUpdate()
        {

            SqlDataReader dataReader;
            SqlDataReader dataReader2;
            SqlConnection connex = new SqlConnection();
            connex.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex.Open();

            int ord_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["orderId"].Value;
            int inv_num = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["number"].Value;

            this.label14.Text = " " + ord_id;
            String query1 = "select car_id from ordere where ord_id = " + ord_id;
            SqlCommand command = new SqlCommand(query1, connex);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                this.label12.Text = " " + dataReader[0];
                this.linkLabel1.Enabled = true;
            }
            dataReader.Close();
            String query2 = "select cus_id from Ordere join invoice using (ord_id) join cart using (car_id) where ord_id = " + ord_id;
            SqlCommand command2 = new SqlCommand(query2, connex);
            dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                this.label13.Text = " " + dataReader2[0];
            }
            connex.Close();
            this.linkLabel1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.saveToolStripButton.Enabled = false;
            this.invoiceDataSet.Tables[0].Clear();
            tableUpdate("select * from invoice where INV_NUM like '" + textBox1.Text + "%' and inv_amount like '" + textBox3.Text
                +  /*"%' and inv_date = '" + textBox2.Text + */ "%' and ord_ID like '" + textBox4.Text + "%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.saveToolStripButton.Enabled = false;
            this.invoiceDataSet.Tables[0].Clear();
            tableUpdate("select * from invoice where INV_NUM like '" + textBox1.Text + "%' and inv_amount like '" + textBox3.Text
                +  /*"%' and inv_date = '" + textBox2.Text + */ "%' and ord_ID like '" + textBox4.Text + "%'");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.saveToolStripButton.Enabled = false;
            this.invoiceDataSet.Tables[0].Clear();
            tableUpdate("select * from invoice where INV_NUM like '" + textBox1.Text + "%' and inv_amount like '" + textBox3.Text
                + /*"%' and inv_date = '" + textBox2.Text */ "%' and ord_ID like '" + textBox4.Text + "%'");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.saveToolStripButton.Enabled = false;
            this.invoiceDataSet.Tables[0].Clear();
            tableUpdate("select * from invoice where INV_NUM like '" + textBox1.Text + "%' and inv_amount like '" + textBox3.Text
                + /* "%' and inv_date = '" + textBox2.Text + */ "%' and ord_ID like '" + textBox4.Text + "%'");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new AddInvoiceForm();
        }

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.groupBox1.Enabled == false)
            {
                this.groupBox1.Enabled = true;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
             
                this.saveToolStripButton.Enabled = false;
                
            }
            else
            {
                this.groupBox1.Enabled = false;


                this.invoiceDataSet.Tables[0].Clear();

                this.invoiceDataSet.Tables[0].Clear();
                tableUpdate("select * from invoice ");
                this.bindingNavigatorAddNewItem.Enabled = true;
                this.bindingNavigatorDeleteItem.Enabled = true;
                this.saveToolStripButton.Enabled = false;
               
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.connection.ConnectionString = "server = SSEDB; database = khobalatte_a; user = khobalatte_a; password = newpassword";
            int inv_num = 20;
            
            //int inv_num = (int)(this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["inv_num"].Value);
          

            this.connection.Open();


            String query = " delete from invoice where inv_num = " + inv_num;



            SqlCommand command = new SqlCommand(query, this.connection);



            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "WARNING");
            }
            MessageBox.Show("Delete completed successfully!");

            connection.Close();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}