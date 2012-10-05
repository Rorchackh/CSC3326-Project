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
    public partial class ProductMGT : Form
    {
        private SqlConnection connection;
        private DataSet ProductDataSet = new DataSet();
        private SqlDataAdapter dataAdapter;
        public SqlDataReader dataReader;
        public BindingSource bindingSource = new BindingSource();
        public ProductMGT()
        {
            InitializeComponent();
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            Form1_Load(null, null);

        }

        public Panel getPanel() {
            return this.vendorPanel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product");
            this.groupBox1.Enabled = false;
            this.slidingTitleBar1.Panel.Controls.Add(this.richTextBox1);
           
            
            

        }

        private void vendorPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        public void tableUpdate(String query)
        {

            connection.Close();
            try
            {
                this.connection.Open();
                this.dataAdapter = new SqlDataAdapter(query, this.connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(this.dataAdapter);
                this.dataAdapter.Fill(this.ProductDataSet, "product");

                this.bindingSource.DataSource = this.ProductDataSet;
                this.bindingSource.DataMember = "product";


                this.dataGridView1.DataSource = this.bindingSource;
                //    this.dataGridView1.DataMember = "Vendor";


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
            this.ProductDataSet.Tables[0].Clear();
            tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product where cat_id like '" + textBox5.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.ProductDataSet.Tables[0].Clear();
            tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product where pro_qoh like '" + textBox4.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.ProductDataSet.Tables[0].Clear();
            tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product where pro_price like '" + textBox3.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.ProductDataSet.Tables[0].Clear();
            tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product where pro_id like '"+textBox1.Text+"%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.ProductDataSet.Tables[0].Clear();
            tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product where pro_name like '" + textBox2.Text + "%'");
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
                this.ProductDataSet.Tables[0].Clear();
                tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product");
                this.bindingNavigatorAddNewItem.Enabled = true;
                this.bindingNavigatorDeleteItem.Enabled = true;
                this.toolStripButton1.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataAdapter.Update(this.ProductDataSet, "product");
            MessageBox.Show("Data Updated Successfully");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String pro_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (pro_name != "")
            {
                RichTextBox rtb = new RichTextBox();
                RichTextBox rtb2 = new RichTextBox();
                rtb.ReadOnly = true;
                rtb.BackColor = Color.White;
                rtb2.ReadOnly = true;
                rtb2.BackColor = Color.White;
                VendorInfoUpdate();

                Crownwood.DotNetMagic.Controls.TabPage tp1 = new Crownwood.DotNetMagic.Controls.TabPage(pro_name, rtb);
                Crownwood.DotNetMagic.Controls.TabPage tp2 = new Crownwood.DotNetMagic.Controls.TabPage(pro_name, rtb2);

                ProductDetailsUpdate(rtb);
                ProductReviews(rtb2);

                tabbedGroups1.ActiveLeaf.TabPages.Add(tp1);
                tabbedGroups2.ActiveLeaf.TabPages.Add(tp2);

                tp1.Selected = true;
                tp2.Selected = true;
            }
           // System.Console.Write(this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["add_id"].Value);


        }

        private void VendorInfoUpdate()
        {

            SqlDataReader dataReader;
            SqlConnection connex = new SqlConnection();
            connex.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex.Open();

            int ved_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Vendor"].Value;

            String query = "select ved_id, ved_name, ved_areacode,ved_phone, add_num, add_street, add_city, add_country from vendor v  inner join addresse a on v.add_id = a.add_id where ved_id  = " + ved_id;
            SqlCommand command = new SqlCommand(query, connex);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string row = "\n" +
                 "VENDOR ID - " + dataReader[0] +
                 "\nVENDOR NAME  - " + dataReader[1] +
                  "\nVENDOR AREACODE - " + dataReader[2] +
                  "\nVENDOR PHONE  - " + dataReader[3] +
                  "\nADDRESS  - " + dataReader[4] + " " + dataReader[5] + " " + dataReader[6] + " " + dataReader[7];

                this.richTextBox1.Text = row;
            }
           

            connex.Close();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.statusPanel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void ProductDetailsUpdate(RichTextBox rtb)
        {
            SqlDataReader dataReader;
            SqlConnection connex = new SqlConnection();

            connex.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex.Open();

            int pro_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value;


            String query = "select pro_descript, pro_indate, p.cat_id, cat_name, cat_descript from product p inner join category c on p.cat_id = c.cat_id where pro_id = " + pro_id;

            SqlCommand command = new SqlCommand(query, connex);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string row = "\n\n" +
                "Product Description - " + dataReader[0] +
                "\nInDate  - " + dataReader[1] +
                "\nCategory ID  - " + dataReader[2] +
                 "\nProduct Category Name - " + dataReader[3] +
                 "\nCategory Description  - " + dataReader[4] +

                "\n========================================";

                rtb.Text += row;
            }

            connex.Close();


            
        }



        private void ProductReviews(RichTextBox rtb2)
        {
            SqlDataReader dataReader;
            SqlConnection connex1 = new SqlConnection();
            connex1.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex1.Open();

            String pro_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();

            String query = "select  cus_lname, cus_fname, rev_title, rev_date, rev_rate, rev_text from review r inner join customer c on r.cus_id = c.cus_id inner join product p on r.pro_id = p.pro_id where p.pro_name = '" + pro_name + "'";
            SqlCommand command = new SqlCommand(query, connex1);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string row = "\n\n" +
                "Posted by - " + dataReader[0] + " " + dataReader[1] + "\n" +
                "\nTitle  - " + dataReader[2] +
                "\nDate  - " + dataReader[3] +
                 "\nRating - " + dataReader[4] + "\n" +
                 "\nUser Review:   " + dataReader[5] + "\n" +

                "\n===============================";

                rtb2.Text += row;
            }

            connex1.Close();
        }



        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            String pro_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (pro_name != "")
            {
                VendorInfoUpdate();

            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            String pro_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (pro_name != "")
            {
                VendorInfoUpdate();

            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            String pro_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (pro_name != "")
            {
                VendorInfoUpdate();

            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            String pro_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["Name"].Value.ToString();
            if (pro_name != "")
            {
                VendorInfoUpdate();

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            product_ADD addp = new product_ADD();
            addp.Owner = this;
            addp.Show();
            
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.ProductDataSet.Tables[0].Clear();
            tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.ProductDataSet.Tables[0].Clear();
            tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product where ved_id like '" + textBox7.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.ProductDataSet.Tables[0].Clear();
            tableUpdate("select pro_id as ID, pro_name as Name, pro_price as Price, pro_qoh as Quantity, cat_id as Category, ved_id as Vendor, p_status as Status from product where p_status like '" + textBox6.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }


       

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection();
           
            this.connection.ConnectionString = "server = SSEDB; database = khobalatte_a; user = khobalatte_a; password = newpassword";

            int pro_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value;
            pro_id += 1;
            this.connection.Open();

            String query = "delete from line where pro_id =" + pro_id +"delete from review where pro_id =" + pro_id + " delete from product where pro_id =" + pro_id;
		 
		 	 

            SqlCommand command = new SqlCommand(query, this.connection);

            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("product " + pro_id + " deleted successfully");
        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}