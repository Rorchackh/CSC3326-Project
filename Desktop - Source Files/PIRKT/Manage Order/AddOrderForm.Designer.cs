namespace PIRKT.Manage_Order
{
    partial class AddOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonWithStyle1 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            this.buttonWithStyle2 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            this.buttonWithStyle3 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(100, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(100, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(313, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Time:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(313, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Time:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(100, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cart ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox1.Location = new System.Drawing.Point(183, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(396, 260);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(183, 256);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PIRKT.Properties.Resources.order;
            this.panel1.Controls.Add(this.buttonWithStyle3);
            this.panel1.Controls.Add(this.buttonWithStyle2);
            this.panel1.Controls.Add(this.buttonWithStyle1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(-6, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 491);
            this.panel1.TabIndex = 13;
            // 
            // buttonWithStyle1
            // 
            this.buttonWithStyle1.Location = new System.Drawing.Point(215, 338);
            this.buttonWithStyle1.Name = "buttonWithStyle1";
            this.buttonWithStyle1.Size = new System.Drawing.Size(75, 23);
            this.buttonWithStyle1.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle1.TabIndex = 13;
            this.buttonWithStyle1.Text = "ADD";
            this.buttonWithStyle1.Click += new System.EventHandler(this.buttonWithStyle1_Click);
            // 
            // buttonWithStyle2
            // 
            this.buttonWithStyle2.Location = new System.Drawing.Point(316, 338);
            this.buttonWithStyle2.Name = "buttonWithStyle2";
            this.buttonWithStyle2.Size = new System.Drawing.Size(75, 23);
            this.buttonWithStyle2.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle2.TabIndex = 14;
            this.buttonWithStyle2.Text = "RESET";
            this.buttonWithStyle2.Click += new System.EventHandler(this.buttonWithStyle2_Click);
            // 
            // buttonWithStyle3
            // 
            this.buttonWithStyle3.Location = new System.Drawing.Point(412, 338);
            this.buttonWithStyle3.Name = "buttonWithStyle3";
            this.buttonWithStyle3.Size = new System.Drawing.Size(75, 23);
            this.buttonWithStyle3.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle3.TabIndex = 15;
            this.buttonWithStyle3.Text = "CANCEL";
            this.buttonWithStyle3.Click += new System.EventHandler(this.buttonWithStyle3_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.panel1);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrderForm";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle3;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle2;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle1;
    }
}