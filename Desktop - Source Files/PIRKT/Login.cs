using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIRKT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Owner = this;
            createAccount.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonWithStyle1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text == "admin") && (this.textBox2.Text == "admin"))
            {
                MainForm Form = new MainForm();
                Form.Owner = this;
                Form.Show();
                this.Visible = false;
            }
            else
            {
                this.label5.Visible = true;
                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void treeControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWithStyle2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonWithStyle2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}