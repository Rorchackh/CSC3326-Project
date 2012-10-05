namespace PIRKT
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonWithStyle1 = new Crownwood.DotNetMagic.Controls.ButtonWithStyle();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PIRKT.Properties.Resources.about_copy;
            this.panel1.Controls.Add(this.buttonWithStyle1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 514);
            this.panel1.TabIndex = 0;
            // 
            // buttonWithStyle1
            // 
            this.buttonWithStyle1.Location = new System.Drawing.Point(390, 23);
            this.buttonWithStyle1.Name = "buttonWithStyle1";
            this.buttonWithStyle1.Size = new System.Drawing.Size(46, 23);
            this.buttonWithStyle1.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
            this.buttonWithStyle1.TabIndex = 26;
            this.buttonWithStyle1.Text = "OK";
            this.buttonWithStyle1.Click += new System.EventHandler(this.buttonWithStyle1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(457, 506);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            this.Load += new System.EventHandler(this.About_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Crownwood.DotNetMagic.Controls.ButtonWithStyle buttonWithStyle1;

    }
}
