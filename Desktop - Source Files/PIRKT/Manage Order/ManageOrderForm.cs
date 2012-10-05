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
    public partial class ManageOrderForm : Form
    {
        private SqlConnection connection;
        private DataSet orderDataSet1 = new DataSet();
        private SqlDataAdapter dataAdapter;

        public ManageOrderForm()
        {
            InitializeComponent();
            this.label12.Text = this.label13.Text = this.label14.Text = "N/A";
            this.linkLabel1.Enabled = false;
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            ManageOrderForm_Load(null, null);
        }

        private void addOrderPanel_Paint(object sender, PaintEventArgs e)
        {
           // ManageOrderForm_Load(null, null);
        }

        public Panel getPanel()
        {
            return this.mainPanel;
        }

        private void ManageOrderForm_Load(object sender, EventArgs e)
        {
                tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere");
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataAdapter.Update(this.orderDataSet1, "ORDERE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = this.textBox4.Text = this.textBox5.Text = "";
            this.saveToolStripButton.Enabled = true;
            this.orderDataSet1.Tables[0].Clear();
            tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere");
        }

        private void tableUpdate(String query)
        {

            try
            {
                this.connection.Open();
                this.dataAdapter = new SqlDataAdapter(query, this.connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(this.dataAdapter);
                this.dataAdapter.Fill(this.orderDataSet1, "ORDERE");

                this.oRDEREBindingSource.DataSource = this.orderDataSet1;
                this.oRDEREBindingSource.DataMember = "ORDERE";


                this.dataGridView1.DataSource = this.oRDEREBindingSource;
                //    this.dataGridView1.DataMember = "PIRKT.Manage_Vendor";


                this.bindingNavigator1.BindingSource = this.oRDEREBindingSource;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.saveToolStripButton.Enabled = false;
            this.orderDataSet1.Tables[0].Clear();
            tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere where ORD_ID like '" + textBox1.Text + "%' and Status like '" + textBox2.Text
                + /* "%' and ORD_STARTTIME = '" + textBox3.Text + "%' and ORD_ENDTIME = '" + textBox4.Text + */  "%' and CAR_ID like '" + 
                textBox5.Text + "%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.saveToolStripButton.Enabled = false;
            this.orderDataSet1.Tables[0].Clear();
            tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere where ORD_ID like '" + textBox1.Text + "%' and Status like '" + textBox2.Text
                + /* "%' and ORD_STARTTIME = '" + textBox3.Text + "%' and ORD_ENDTIME = '" + textBox4.Text + */  "%' and CAR_ID like '" +
                textBox5.Text + "%'");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.saveToolStripButton.Enabled = false;
            this.orderDataSet1.Tables[0].Clear();
            tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere where ORD_ID like '" + textBox1.Text + "%' and Status like '" + textBox2.Text
                + /* "%' and ORD_STARTTIME = '" + textBox3.Text + "%' and ORD_ENDTIME = '" + textBox4.Text + */  "%' and CAR_ID like '" +
                textBox5.Text + "%'");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.saveToolStripButton.Enabled = false;
            this.orderDataSet1.Tables[0].Clear();
            tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere where ORD_ID like '" + textBox1.Text + "%' and Status like '" + textBox2.Text
                + /* "%' and ORD_STARTTIME = '" + textBox3.Text + "%' and ORD_ENDTIME = '" + textBox4.Text + */  "%' and CAR_ID like '" +
                textBox5.Text + "%'");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.saveToolStripButton.Enabled = false;
            this.orderDataSet1.Tables[0].Clear();
            tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere where ORD_ID like '" + textBox1.Text + "%' and Status like '" + textBox2.Text
                + /* "%' and ORD_STARTTIME = '" + textBox3.Text + "%' and ORD_ENDTIME = '" + textBox4.Text + */  "%' and CAR_ID like '" + 
                textBox5.Text + "%'");
        }

        private void AdditionaInfoUpdate()
        {

            SqlDataReader dataReader;
            SqlDataReader dataReader2;
            SqlConnection connex = new SqlConnection();
            connex.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex.Open();

            int ord_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value;
            int car_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Cart"].Value;

            this.label12.Text = " " + car_id;

            String query1 = "select inv_num from invoice where ord_id = " + ord_id;
            
            SqlCommand command = new SqlCommand(query1, connex);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                this.label14.Text = " "  + dataReader[0];
                this.linkLabel1.Enabled = true;
                
            }

            dataReader.Close();

            String query2 = "select cus_id from cart where car_id = " + car_id;
            SqlCommand command2 = new SqlCommand(query2, connex);
            dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read()){
                this.label13.Text = " " +  dataReader2[0];
                connex.Close();
                return;
            }

            connex.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Order = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString();
            if (Order != "")
            {
                AdditionaInfoUpdate();
            }


        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = this.textBox4.Text = this.textBox5.Text = "";
            this.saveToolStripButton.Enabled = true;
            this.orderDataSet1.Tables[0].Clear();
            tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddOrderForm form = new AddOrderForm();
        }

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = this.textBox4.Text = this.textBox5.Text = "";
            this.saveToolStripButton.Enabled = true;
            this.orderDataSet1.Tables[0].Clear();
            tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere");*/

            if (this.groupBox1.Enabled == false)
            {
                this.groupBox1.Enabled = true;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
                //this.toolStripButton1.Enabled = false;
            }
            else
            {
                this.groupBox1.Enabled = false;
                this.orderDataSet1.Tables[0].Clear();
                tableUpdate("select ord_id as ID, STATUS, ord_starttime as StartTime, ord_endtime as EndTime, car_id as Cart from ordere");
                this.bindingNavigatorAddNewItem.Enabled = true;
                this.bindingNavigatorDeleteItem.Enabled = true;
                //this.toolStripButton1.Enabled = true;
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.connection.ConnectionString = "server = SSEDB; database = khobalatte_a; user = khobalatte_a; password = newpassword";

            int cat_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value;

            this.connection.Open();
            

            String query = " delete from ordere where ord_id = " +cat_id;



            SqlCommand command = new SqlCommand(query, this.connection);

            
            
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
               MessageBox.Show(ex.ToString(),"WARNING");
           }
            MessageBox.Show("Delete completed successfully!");

            connection.Close();
        }


    }
}