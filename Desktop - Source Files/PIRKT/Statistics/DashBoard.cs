using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIRKT.Statistics
{
    public partial class DashBoard : Form
    {
        
        public DashBoard(){
            InitializeComponent();    
    }
        private void button5_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Visible = false;
            this.panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Visible = true; ;
            this.panel2.Visible = false;
            this.webBrowser1.Url = new System.Uri("http://SSEDB/", System.UriKind.Absolute);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Visible = true; ;
            this.panel2.Visible = false;
            this.webBrowser1.Url = new System.Uri("http://SSEDB/", System.UriKind.Absolute);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Visible = true; ;
            this.panel2.Visible = false;
            this.webBrowser1.Url = new System.Uri("http://SSEDB/", System.UriKind.Absolute);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Visible = true; ;
            this.panel2.Visible = false;
            this.webBrowser1.Url = new System.Uri("http://SSEDB/", System.UriKind.Absolute);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unpaid.payReport' table. You can move, or remove it, as needed.
            this.payReportTableAdapter.Fill(this.unpaid.payReport);
            // TODO: This line of code loads data into the 'unpaid.BestSellers' table. You can move, or remove it, as needed.
            this.bestSellersTableAdapter.Fill(this.unpaid.BestSellers);

        }
    }
}