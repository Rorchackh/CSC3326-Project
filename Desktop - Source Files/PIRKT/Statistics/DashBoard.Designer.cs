namespace PIRKT.Statistics
{   
    partial class DashBoard
    {
        Form1 local= new Form1();
        Statistics stat=new Statistics();
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
            this.payReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unpaid = new PIRKT.Statistics.unpaid();
            this.bestSellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bestSellersTableAdapter = new PIRKT.Statistics.unpaidTableAdapters.BestSellersTableAdapter();
            this.payReportTableAdapter = new PIRKT.Statistics.unpaidTableAdapters.payReportTableAdapter();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRONAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROINCOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.payReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellersBindingSource)).BeginInit();
            this.Menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // payReportBindingSource
            // 
            this.payReportBindingSource.DataMember = "payReport";
            this.payReportBindingSource.DataSource = this.unpaid;
            // 
            // unpaid
            // 
            this.unpaid.DataSetName = "unpaid";
            this.unpaid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bestSellersBindingSource
            // 
            this.bestSellersBindingSource.DataMember = "BestSellers";
            this.bestSellersBindingSource.DataSource = this.unpaid;
            // 
            // bestSellersTableAdapter
            // 
            this.bestSellersTableAdapter.ClearBeforeFill = true;
            // 
            // payReportTableAdapter
            // 
            this.payReportTableAdapter.ClearBeforeFill = true;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.button5);
            this.Menu.Controls.Add(this.button4);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.button3);
            this.Menu.Controls.Add(this.button2);
            this.Menu.Location = new System.Drawing.Point(10, 26);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(109, 365);
            this.Menu.TabIndex = 5;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "DashBoard";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-1, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Vendors Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geographical Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Products Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reviews Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(148, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 383);
            this.panel2.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total paid orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total unpaid orders (pending payment status) ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.payReportBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(315, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(255, 84);
            this.dataGridView2.TabIndex = 0;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Best Sellers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRONAMEDataGridViewTextBoxColumn,
            this.vEDNAMEDataGridViewTextBoxColumn,
            this.pROPRICEDataGridViewTextBoxColumn,
            this.pROINCOMEDataGridViewTextBoxColumn,
            this.pROCNTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bestSellersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 152);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pRONAMEDataGridViewTextBoxColumn
            // 
            this.pRONAMEDataGridViewTextBoxColumn.DataPropertyName = "PRO_NAME";
            this.pRONAMEDataGridViewTextBoxColumn.HeaderText = "PRO_NAME";
            this.pRONAMEDataGridViewTextBoxColumn.Name = "pRONAMEDataGridViewTextBoxColumn";
            // 
            // vEDNAMEDataGridViewTextBoxColumn
            // 
            this.vEDNAMEDataGridViewTextBoxColumn.DataPropertyName = "VED_NAME";
            this.vEDNAMEDataGridViewTextBoxColumn.HeaderText = "VED_NAME";
            this.vEDNAMEDataGridViewTextBoxColumn.Name = "vEDNAMEDataGridViewTextBoxColumn";
            // 
            // pROPRICEDataGridViewTextBoxColumn
            // 
            this.pROPRICEDataGridViewTextBoxColumn.DataPropertyName = "PRO_PRICE";
            this.pROPRICEDataGridViewTextBoxColumn.HeaderText = "PRO_PRICE";
            this.pROPRICEDataGridViewTextBoxColumn.Name = "pROPRICEDataGridViewTextBoxColumn";
            // 
            // pROINCOMEDataGridViewTextBoxColumn
            // 
            this.pROINCOMEDataGridViewTextBoxColumn.DataPropertyName = "PRO_INCOME";
            this.pROINCOMEDataGridViewTextBoxColumn.HeaderText = "PRO_INCOME";
            this.pROINCOMEDataGridViewTextBoxColumn.Name = "pROINCOMEDataGridViewTextBoxColumn";
            // 
            // pROCNTDataGridViewTextBoxColumn
            // 
            this.pROCNTDataGridViewTextBoxColumn.DataPropertyName = "PRO_CNT";
            this.pROCNTDataGridViewTextBoxColumn.HeaderText = "PRO_CNT";
            this.pROCNTDataGridViewTextBoxColumn.Name = "pROCNTDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "public";
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 465);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.Menu);
            this.panel3.Location = new System.Drawing.Point(16, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 467);
            this.panel3.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(199, 9);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(698, 467);
            this.webBrowser1.TabIndex = 6;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(945, 523);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellersBindingSource)).EndInit();
            this.Menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private unpaid unpaid;
        private System.Windows.Forms.BindingSource bestSellersBindingSource;
        private PIRKT.Statistics.unpaidTableAdapters.BestSellersTableAdapter bestSellersTableAdapter;
        private System.Windows.Forms.BindingSource payReportBindingSource;
        private PIRKT.Statistics.unpaidTableAdapters.payReportTableAdapter payReportTableAdapter;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRONAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vEDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROINCOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}