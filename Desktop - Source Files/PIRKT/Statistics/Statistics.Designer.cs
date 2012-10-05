namespace PIRKT.Statistics
{
    partial class Statistics
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
            this.bestSellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unpaidOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paidPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unpaid1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unpaid1 = new PIRKT.Statistics.unpaid();
            this.bestSellersTableAdapter = new PIRKT.Statistics.unpaidTableAdapters.BestSellersTableAdapter();
            this.unpaidOrdersTableAdapter = new PIRKT.Statistics.unpaidTableAdapters.unpaidOrdersTableAdapter();
            this.paidPaymentTableAdapter = new PIRKT.Statistics.unpaidTableAdapters.paidPaymentTableAdapter();
            this.payReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payReportTableAdapter = new PIRKT.Statistics.unpaidTableAdapters.payReportTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRONAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROINCOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaidOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaid1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payReportBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bestSellersBindingSource
            // 
            this.bestSellersBindingSource.DataMember = "BestSellers";
            this.bestSellersBindingSource.DataSource = this.unpaid1BindingSource;
            // 
            // unpaidOrdersBindingSource
            // 
            this.unpaidOrdersBindingSource.DataMember = "unpaidOrders";
            this.unpaidOrdersBindingSource.DataSource = this.unpaid1BindingSource;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.unpaid1BindingSource;
            // 
            // paidPaymentBindingSource
            // 
            this.paidPaymentBindingSource.DataMember = "paidPayment";
            this.paidPaymentBindingSource.DataSource = this.unpaid1BindingSource;
            // 
            // unpaid1BindingSource
            // 
            this.unpaid1BindingSource.DataSource = this.unpaid1;
            this.unpaid1BindingSource.Position = 0;
            // 
            // unpaid1
            // 
            this.unpaid1.DataSetName = "unpaid";
            this.unpaid1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bestSellersTableAdapter
            // 
            this.bestSellersTableAdapter.ClearBeforeFill = true;
            // 
            // unpaidOrdersTableAdapter
            // 
            this.unpaidOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // paidPaymentTableAdapter
            // 
            this.paidPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // payReportBindingSource
            // 
            this.payReportBindingSource.DataMember = "payReport";
            this.payReportBindingSource.DataSource = this.unpaid1BindingSource;
            // 
            // payReportTableAdapter
            // 
            this.payReportTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 383);
            this.panel1.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Best Sellers";
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
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 407);
            this.Controls.Add(this.panel1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bestSellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaidOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaid1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payReportBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource unpaid1BindingSource;
        private unpaid unpaid1;
        private System.Windows.Forms.BindingSource bestSellersBindingSource;
        private PIRKT.Statistics.unpaidTableAdapters.BestSellersTableAdapter bestSellersTableAdapter;
        private System.Windows.Forms.BindingSource unpaidOrdersBindingSource;
        private PIRKT.Statistics.unpaidTableAdapters.unpaidOrdersTableAdapter unpaidOrdersTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource paidPaymentBindingSource;
        private PIRKT.Statistics.unpaidTableAdapters.paidPaymentTableAdapter paidPaymentTableAdapter;
        private System.Windows.Forms.BindingSource payReportBindingSource;
        private PIRKT.Statistics.unpaidTableAdapters.payReportTableAdapter payReportTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRONAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vEDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROINCOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCNTDataGridViewTextBoxColumn;
    }
}