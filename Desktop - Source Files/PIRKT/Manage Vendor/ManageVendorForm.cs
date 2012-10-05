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
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private DataSet vendDataSet = new DataSet();
        private SqlDataAdapter dataAdapter;
        public BindingSource bindingSource = new BindingSource();
        int kaka = 0;

        public Form1()
        {
            InitializeComponent();
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            Form1_Load(null, null);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableUpdate("select ved_id as ID, ved_name as Name, ved_areacode as Areacode, ved_phone as phone, add_id as Addresse from vendor");
            this.groupBox1.Enabled = false;
            this.slidingTitleBar1.Panel.Controls.Add(this.richTextBox1);
           
            
            

        }

        private void vendorPanel_Paint(object sender, PaintEventArgs e)
        {
                    

        }

        public void tableUpdate(String query)
        {


            try
            {
                this.connection.Open();
                this.dataAdapter = new SqlDataAdapter(query, this.connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(this.dataAdapter);
                this.dataAdapter.Fill(this.vendDataSet, "Vendor");

                this.bindingSource.DataSource = this.vendDataSet;
                this.bindingSource.DataMember = "Vendor";


                this.dataGridView1.DataSource = this.bindingSource;
                //    this.dataGridView1.DataMember = "PIRKT.Manage_Vendor";


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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.vendDataSet.Tables[0].Clear();
            tableUpdate("select ved_id as ID, ved_name as Name, ved_areacode as Areacode, ved_phone as phone, add_id as Addresse from vendor where add_id like '" + textBox5.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.vendDataSet.Tables[0].Clear();
            tableUpdate("select ved_id as ID, ved_name as Name, ved_areacode as Areacode, ved_phone as phone, add_id as Addresse from vendor where ved_phone like '" + textBox4.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.vendDataSet.Tables[0].Clear();
            tableUpdate("select ved_id as ID, ved_name as Name, ved_areacode as Areacode, ved_phone as phone, add_id as Addresse from vendor where ved_areacode like '" + textBox3.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.vendDataSet.Tables[0].Clear();
            tableUpdate("select ved_id as ID, ved_name as Name, ved_areacode as Areacode, ved_phone as phone, add_id as Addresse from vendor where ved_id like '"+textBox1.Text+"%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.vendDataSet.Tables[0].Clear();
            tableUpdate("select ved_id as ID, ved_name as Name, ved_areacode as Areacode, ved_phone as phone, add_id as Addresse from vendor where ved_name like '" + textBox2.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.groupBox1.Enabled == false)
            {
                this.groupBox1.Enabled = true;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
                this.toolStripButton1.Enabled = false;
            }
            else
            {
                this.groupBox1.Enabled = false;
                this.vendDataSet.Tables[0].Clear();
                tableUpdate("select ved_id as ID, ved_name as Name, ved_areacode as Areacode, ved_phone as phone, add_id as Addresse from vendor");
                this.bindingNavigatorAddNewItem.Enabled = true;
                this.bindingNavigatorDeleteItem.Enabled = true;
                this.toolStripButton1.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataAdapter.Update(this.vendDataSet, "vendor");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String ved_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (ved_name != "")
            {
                RichTextBox rtb = new RichTextBox();
                rtb.ReadOnly = true;
                rtb.BackColor = Color.White;
                addressInfoUpdate();
                Crownwood.DotNetMagic.Controls.TabPage tp = new Crownwood.DotNetMagic.Controls.TabPage(ved_name, rtb);
                productsPerVendor(rtb);
                tabbedGroups1.ActiveLeaf.TabPages.Add(tp);
                tp.Selected = true;
            }
           // System.Console.Write(this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["add_id"].Value);


        }

        private void addressInfoUpdate()
        {

            SqlDataReader dataReader;
            SqlConnection connex = new SqlConnection();
            connex.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex.Open();

            int add_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.statusPanel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void productsPerVendor(RichTextBox rtb)
        {
            SqlDataReader dataReader;
            SqlConnection connex = new SqlConnection();
            connex.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex.Open();

            int ved_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value;

            String query = "select pro_id,pro_descript, pro_name, pro_qoh, cat_name from product p join category c on p.cat_id = c.cat_id where ved_id = " + ved_id;
            SqlCommand command = new SqlCommand(query, connex);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string row = "\n\n" +
                "Product ID - " + dataReader[0] +
                "\nProduct Description  - " + dataReader[1] +
                 "\nProduct Name - " + dataReader[2] +
                 "\nProduct QOH  - " + dataReader[3] +
                "\nProduct Category  - " + dataReader[4] +
                "\n===========================================";

                rtb.Text += row;
            }

            connex.Close();





        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            String ved_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (ved_name != "")
            {
                addressInfoUpdate();

            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            String ved_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (ved_name != "")
            {
                addressInfoUpdate();

            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            String ved_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (ved_name != "")
            {
                addressInfoUpdate();

            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            String ved_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (ved_name != "")
            {
                addressInfoUpdate();

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddVendorForm f = new AddVendorForm();
            f.Owner = this;
            f.Show();
            
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.vendDataSet.Tables[0].Clear();
            tableUpdate("select ved_id as ID, ved_name as Name, ved_areacode as Areacode, ved_phone as phone, add_id as Addresse from vendor");
        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataAdapter.Update(this.vendDataSet, "vendor");
        }




    }
}