using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIRKT.Statistics
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unpaid1.payReport' table. You can move, or remove it, as needed.
            this.payReportTableAdapter.Fill(this.unpaid1.payReport);
            // TODO: This line of code loads data into the 'unpaid1.paidPayment' table. You can move, or remove it, as needed.
            this.paidPaymentTableAdapter.Fill(this.unpaid1.paidPayment);
            // TODO: This line of code loads data into the 'unpaid1.unpaidOrders' table. You can move, or remove it, as needed.
            this.unpaidOrdersTableAdapter.Fill(this.unpaid1.unpaidOrders);
            // TODO: This line of code loads data into the 'unpaid1.BestSellers' table. You can move, or remove it, as needed.
            this.bestSellersTableAdapter.Fill(this.unpaid1.BestSellers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}