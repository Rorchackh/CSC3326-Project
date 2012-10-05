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
    public partial class Category_form : Form
    {
        private SqlConnection connection;
        SqlDataReader dataReader;
        private DataSet CategoryDataSet = new DataSet();
        private SqlDataAdapter dataAdapter;
        public BindingSource bindingSource = new BindingSource();
        public Category_form()
        {
            InitializeComponent();
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            Form1_Load(null, null);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableUpdate("select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from category");
            this.groupBox1.Enabled = false;
            this.slidingTitleBar1.Panel.Controls.Add(this.richTextBox1);  
        }

        private void vendorPanel_Paint(object sender, PaintEventArgs e)
        {
            if (cool == 1)
                tableUpdate("select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from category ");
        }

        public Panel getPanel(){
            return this.vendorPanel;
        }

        public void tableUpdate(String query)
        {


            try
            {
                this.connection.Open();
                this.dataAdapter = new SqlDataAdapter(query, this.connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(this.dataAdapter);
                this.dataAdapter.Fill(this.CategoryDataSet, "category");

                this.bindingSource.DataSource = this.CategoryDataSet;
                this.bindingSource.DataMember = "category";


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

            connection.Close();

        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.CategoryDataSet.Tables[0].Clear();
            tableUpdate("select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from category where sup_id like '" + textBox4.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.CategoryDataSet.Tables[0].Clear();
            tableUpdate("select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from category where cat_descript like '" + textBox3.Text + "%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.CategoryDataSet.Tables[0].Clear();
            tableUpdate("select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from category where cat_id like '"+textBox1.Text+"%'");
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.CategoryDataSet.Tables[0].Clear();
            tableUpdate("select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from category where cat_name like '" + textBox2.Text + "%'");
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

               // this.dataGridView1.RowCount = 0;
                this.groupBox1.Enabled = false;
                this.CategoryDataSet.Tables[0].Clear();
                tableUpdate("select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from category");
                this.bindingNavigatorAddNewItem.Enabled = true;
                this.bindingNavigatorDeleteItem.Enabled = true;
                this.toolStripButton1.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataAdapter.Update(this.CategoryDataSet, "category");
        }

        public int cat_id;
        public String cat_name;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cat_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value;
             cat_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["NAME"].Value.ToString();
            if (cat_name != "")
            {
                RichTextBox rtb = new RichTextBox();
                rtb.ReadOnly = true;
                rtb.BackColor = Color.White;
                SuperCategoryUpdate();
                Crownwood.DotNetMagic.Controls.TabPage tp = new Crownwood.DotNetMagic.Controls.TabPage(cat_name, rtb);
                CategoryProducts(rtb);
                tabbedGroups1.ActiveLeaf.TabPages.Add(tp);
                tp.Selected = true;
            }
           // System.Console.Write(this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["add_id"].Value);


        }

        private void SuperCategoryUpdate()
        {

            SqlDataReader dataReader;
            SqlConnection connex = new SqlConnection();
            connex.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex.Open();

            int sup_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["PARENT"].Value;

            if (sup_id == 0)
            {
                string row = "\n\n\n\n  No Parent Category\n";
                this.richTextBox1.Text = row;
            }
            else
            {
                String query = "select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from category where cat_id = " + sup_id;
                SqlCommand command = new SqlCommand(query, connex);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string row = "\n" + "Parent Category:\n" +
                    "\n  ID  - " + dataReader[0] +
                     "\n  Name  - " + dataReader[1] +
                      "\n  Description  - " + dataReader[2];


                    this.richTextBox1.Text = row;
                }
            }
                connex.Close();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.statusPanel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void CategoryProducts(RichTextBox rtb)
        {
            SqlDataReader dataReader;
            SqlConnection connex = new SqlConnection();
            connex.ConnectionString = "server=SSEDB;database=khobalatte_a;user=khobalatte_a;password=newpassword";
            connex.Open();

            int cat_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value;

            String query = "select pro_id, pro_name, pro_price, pro_qoh, p_status, pro_descript from product where cat_id =  " + cat_id;
            SqlCommand command = new SqlCommand(query, connex);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string row = "\n" +
                 " Product ID - " + dataReader[0] +
                 "\n Name  - " + dataReader[1] +
                 "\n Unit Price - " + dataReader[2] +
                 "\n Quantity  - " + dataReader[3] +
                 "\n Status  - " + dataReader[4] +
                 "\n Description - " + dataReader[5]+
                 
                "\n===========================================";

                rtb.Text += row;
            }

            connex.Close();





        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            String cat_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["NAME"].Value.ToString();
            if (cat_name != "")
            {
                SuperCategoryUpdate();

            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            String cat_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["NAMA"].Value.ToString();
            if (cat_name != "")
            {
                SuperCategoryUpdate();

            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            String cat_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["NAME"].Value.ToString();
            if (cat_name != "")
            {
                SuperCategoryUpdate();

            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            String cat_name = this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["NAME"].Value.ToString();
            if (cat_name != "")
            {
                SuperCategoryUpdate();

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Add_Category f = new Add_Category();
            f.Owner = this;
            f.Show();
            
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.CategoryDataSet.Tables[0].Clear();
            tableUpdate("select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from category");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            this.connection.ConnectionString = "server = SSEDB; database = khobalatte_a; user = khobalatte_a; password = newpassword";

            int cat_id = (int)this.dataGridView1.Rows[(int)this.dataGridView1.CurrentRow.Index].Cells["ID"].Value;

            this.connection.Open();
            cat_id += 1;

            String query = " update category  set sup_id = 0 where sup_id = " + cat_id + " update category set sup_id = 0 where cat_id = " + cat_id +"update product set cat_id = null where cat_id ="+ cat_id+ "delete from category where cat_id = " + cat_id;
		 
		 	 

            SqlCommand command = new SqlCommand(query, this.connection);

            command.ExecuteNonQuery();
            /*
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
               MessageBox.Show("This category has at least one child\nPlease remove the children first","WARNING");
           }
            MessageBox.Show("Delete completed successfully!");*/

            connection.Close();
        }

        private int cool = 0;
        public void setStuff(int cool) {
            this.cool = cool;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            
            tableUpdate("select cat_id as ID, cat_name as NAME, cat_descript as DESCRIPTION, sup_id as PARENT from Category");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modify md = new Modify(cat_id);
            md.Owner = this;
            md.Show();
            
            
                 
            
            
           
        }

        private void buttonWithStyle2_Click_1(object sender, EventArgs e)
        {
            Modify md = new Modify(cat_id);
            md.Owner = this;
            md.Show();
            
        }

    }
}