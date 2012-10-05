namespace PIRKT.Manage_Category
{
    partial class Add_Category
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khobalatte_aDataSet = new PIRKT.Manage_Category.khobalatte_aDataSet();
            this.buttonWithStyle1 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            this.buttonWithStyle2 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            this.cATEGORYTableAdapter = new PIRKT.Manage_Category.khobalatte_aDataSetTableAdapters.CATEGORYTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonWithStyle3 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khobalatte_aDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(203, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(203, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(288, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(203, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parent :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 99);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 135);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 239);
            this.textBox3.MaxLength = 100;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(325, 84);
            this.textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cATEGORYBindingSource;
            this.comboBox1.DisplayMember = "CAT_NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(275, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "CAT_ID";
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.khobalatte_aDataSet;
            // 
            // khobalatte_aDataSet
            // 
            this.khobalatte_aDataSet.DataSetName = "khobalatte_aDataSet";
            this.khobalatte_aDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonWithStyle1
            // 
            this.buttonWithStyle1.AlwaysDrawBorder = true;
            this.buttonWithStyle1.AlwaysDrawEnabled = true;
            this.buttonWithStyle1.Location = new System.Drawing.Point(169, 351);
            this.buttonWithStyle1.Name = "buttonWithStyle1";
            this.buttonWithStyle1.Size = new System.Drawing.Size(75, 23);
            this.buttonWithStyle1.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle1.TabIndex = 11;
            this.buttonWithStyle1.Text = "ADD";
            this.buttonWithStyle1.Click += new System.EventHandler(this.buttonWithStyle1_Click);
            // 
            // buttonWithStyle2
            // 
            this.buttonWithStyle2.AlwaysDrawBorder = true;
            this.buttonWithStyle2.AlwaysDrawEnabled = true;
            this.buttonWithStyle2.Location = new System.Drawing.Point(291, 351);
            this.buttonWithStyle2.Name = "buttonWithStyle2";
            this.buttonWithStyle2.Size = new System.Drawing.Size(75, 23);
            this.buttonWithStyle2.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle2.TabIndex = 12;
            this.buttonWithStyle2.Text = "CANCEL";
            this.buttonWithStyle2.Click += new System.EventHandler(this.buttonWithStyle2_Click);
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PIRKT.Properties.Resources.category;
            this.panel1.Controls.Add(this.buttonWithStyle3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonWithStyle2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonWithStyle1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(-8, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 492);
            this.panel1.TabIndex = 13;
            // 
            // buttonWithStyle3
            // 
            this.buttonWithStyle3.AlwaysDrawBorder = true;
            this.buttonWithStyle3.AlwaysDrawEnabled = true;
            this.buttonWithStyle3.Location = new System.Drawing.Point(419, 351);
            this.buttonWithStyle3.Name = "buttonWithStyle3";
            this.buttonWithStyle3.Size = new System.Drawing.Size(75, 23);
            this.buttonWithStyle3.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle3.TabIndex = 13;
            this.buttonWithStyle3.Text = "RESET";
            this.buttonWithStyle3.Click += new System.EventHandler(this.buttonWithStyle3_Click);
            // 
            // Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 480);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.Add_Vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khobalatte_aDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle1;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle2;
        private PIRKT.Manage_Category.khobalatte_aDataSet khobalatte_aDataSet;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private khobalatte_aDataSetTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle3;
    }
}