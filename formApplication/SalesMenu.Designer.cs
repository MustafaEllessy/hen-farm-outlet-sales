namespace farmApplication
{
    partial class frmSalesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesMenu));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeTool1 = new formApplication.closeTool();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEnter = new System.Windows.Forms.Panel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(453, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "المبيعات";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(151, 656);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 36);
            this.label7.TabIndex = 18;
            this.label7.Text = "العرض";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(38, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "الادخال";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(267, 656);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "التقارير";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeTool1
            // 
            this.closeTool1.Location = new System.Drawing.Point(2, 2);
            this.closeTool1.Margin = new System.Windows.Forms.Padding(6);
            this.closeTool1.Name = "closeTool1";
            this.closeTool1.Size = new System.Drawing.Size(86, 81);
            this.closeTool1.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BackgroundImage = global::formApplication.Properties.Resources.titleSales;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(85, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1198, 81);
            this.panel3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::formApplication.Properties.Resources.تقارير;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(266, 569);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 84);
            this.panel2.TabIndex = 20;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImage = global::formApplication.Properties.Resources.ادخال;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(565, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 90);
            this.panel1.TabIndex = 19;
            // 
            // pnlEnter
            // 
            this.pnlEnter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEnter.BackgroundImage")));
            this.pnlEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEnter.Location = new System.Drawing.Point(38, 569);
            this.pnlEnter.Name = "pnlEnter";
            this.pnlEnter.Size = new System.Drawing.Size(108, 84);
            this.pnlEnter.TabIndex = 15;
            this.pnlEnter.Click += new System.EventHandler(this.pnlEnter_Click);
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlView.BackgroundImage")));
            this.pnlView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlView.Location = new System.Drawing.Point(152, 569);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(108, 84);
            this.pnlView.TabIndex = 16;
            this.pnlView.Click += new System.EventHandler(this.pnlView_Click);
            // 
            // pnlSales
            // 
            this.pnlSales.BackgroundImage = global::formApplication.Properties.Resources.مبيعات;
            this.pnlSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSales.Location = new System.Drawing.Point(453, 226);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(371, 271);
            this.pnlSales.TabIndex = 8;
            this.pnlSales.Click += new System.EventHandler(this.pnlSales_Click_2);
            this.pnlSales.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSales_Paint);
            // 
            // frmSalesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.closeTool1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlEnter);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlSales);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSalesMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEnter;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private formApplication.closeTool closeTool1;
    }
}

