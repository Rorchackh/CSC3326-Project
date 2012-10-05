using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIRKT
{
    public partial class MainForm : Form
    {
        private HomeForm homeform = new HomeForm();
        private Manage_Order.ManageOrderForm manageOrderForm = new Manage_Order.ManageOrderForm();
        private Manage_Invoice.ManageInvoiceForm manageInvoiceForm = new Manage_Invoice.ManageInvoiceForm();
        private Manage_Vendor.Form1 manageVendorForm = new Manage_Vendor.Form1();
        private Manage_Category.Category_form manageCategoryForm = new Manage_Category.Category_form();
        private Manage_Product.ProductMGT manageProductForm = new Manage_Product.ProductMGT();
        private Manage_Customer.ManageAccounts manageCustomerForm = new Manage_Customer.ManageAccounts();

        public MainForm()
        {
            InitializeComponent();
            this.mainPanel.Controls.Add(homeform.getPanel());
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(manageProductForm.getPanel());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutTheProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new About(this);
        }

        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(manageInvoiceForm.getPanel());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(homeform.getPanel());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void customersReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(manageOrderForm.getPanel());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(manageVendorForm.getPanel());
        }

        private void systemConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            new About(this);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(manageCategoryForm.getPanel());
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(manageProductForm.getPanel());
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.RemoveAt(0);
            this.mainPanel.Controls.Add(manageCustomerForm.getPanel());
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics.DashBoard form = new Statistics.DashBoard();
            form.Show();
        }
    }
}