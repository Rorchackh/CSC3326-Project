namespace PIRKT.Manage_Invoice
{
    partial class AddInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonWithStyle3 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            this.buttonWithStyle2 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            this.buttonWithStyle1 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(288, 228);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(216, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Order ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(198, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Invoice Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(207, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Invoice ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Miriam", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(139, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "* The invoice amount is computed automatically";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PIRKT.Properties.Resources.invoice;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonWithStyle3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonWithStyle2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonWithStyle1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(-8, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 489);
            this.panel1.TabIndex = 27;
            // 
            // buttonWithStyle3
            // 
            this.buttonWithStyle3.AlwaysDrawBorder = true;
            this.buttonWithStyle3.AlwaysDrawEnabled = true;
            this.buttonWithStyle3.Location = new System.Drawing.Point(444, 328);
            this.buttonWithStyle3.Name = "buttonWithStyle3";
            this.buttonWithStyle3.Size = new System.Drawing.Size(75, 23);
            this.buttonWithStyle3.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle3.TabIndex = 30;
            this.buttonWithStyle3.Text = "RESET";
            this.buttonWithStyle3.Click += new System.EventHandler(this.buttonWithStyle3_Click);
            // 
            // buttonWithStyle2
            // 
            this.buttonWithStyle2.AlwaysDrawBorder = true;
            this.buttonWithStyle2.AlwaysDrawEnabled = true;
            this.buttonWithStyle2.Location = new System.Drawing.Point(316, 328);
            this.buttonWithStyle2.Name = "buttonWithStyle2";
            this.buttonWithStyle2.Size = new System.Drawing.Size(75, 23);
            this.buttonWithStyle2.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle2.TabIndex = 29;
            this.buttonWithStyle2.Text = "CANCEL";
            this.buttonWithStyle2.Click += new System.EventHandler(this.buttonWithStyle2_Click);
            // 
            // buttonWithStyle1
            // 
            this.buttonWithStyle1.AlwaysDrawBorder = true;
            this.buttonWithStyle1.AlwaysDrawEnabled = true;
            this.buttonWithStyle1.Location = new System.Drawing.Point(194, 328);
            this.buttonWithStyle1.Name = "buttonWithStyle1";
            this.buttonWithStyle1.Size = new System.Drawing.Size(75, 23);
            this.buttonWithStyle1.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle1.TabIndex = 28;
            this.buttonWithStyle1.Text = "ADD";
            this.buttonWithStyle1.Click += new System.EventHandler(this.buttonWithStyle1_Click);
            // 
            // AddInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(701, 477);
            this.Controls.Add(this.panel1);
            this.Name = "AddInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddInvoiceForm";
            this.Load += new System.EventHandler(this.AddInvoiceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle3;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle2;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle1;
    }
}