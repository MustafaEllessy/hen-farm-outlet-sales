namespace formApplication
{
    partial class CreateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReport));
            this.label2 = new System.Windows.Forms.Label();
            this.cbxReportType = new System.Windows.Forms.ComboBox();
            this.cbxShowType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTime = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxFields = new System.Windows.Forms.GroupBox();
            this.cbxUnit = new System.Windows.Forms.CheckBox();
            this.gbxItems = new System.Windows.Forms.GroupBox();
            this.clbITems = new System.Windows.Forms.CheckedListBox();
            this.cbxFarmType = new System.Windows.Forms.CheckBox();
            this.cbxSectionName = new System.Windows.Forms.CheckBox();
            this.cbxTotal = new System.Windows.Forms.CheckBox();
            this.cbxStationName = new System.Windows.Forms.CheckBox();
            this.cbxPrice = new System.Windows.Forms.CheckBox();
            this.cbxQuantity = new System.Windows.Forms.CheckBox();
            this.cbxPortName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gbxTime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxFields.SuspendLayout();
            this.gbxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(893, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "نوع التقرير";
            // 
            // cbxReportType
            // 
            this.cbxReportType.FormattingEnabled = true;
            this.cbxReportType.Items.AddRange(new object[] {
            "جداول"});
            this.cbxReportType.Location = new System.Drawing.Point(728, 27);
            this.cbxReportType.Name = "cbxReportType";
            this.cbxReportType.Size = new System.Drawing.Size(157, 39);
            this.cbxReportType.TabIndex = 5;
            // 
            // cbxShowType
            // 
            this.cbxShowType.FormattingEnabled = true;
            this.cbxShowType.Items.AddRange(new object[] {
            "مفصل",
            "مجمل"});
            this.cbxShowType.Location = new System.Drawing.Point(28, 23);
            this.cbxShowType.Name = "cbxShowType";
            this.cbxShowType.Size = new System.Drawing.Size(157, 39);
            this.cbxShowType.TabIndex = 5;
            this.cbxShowType.SelectedIndexChanged += new System.EventHandler(this.cbxShowType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "نوع العرض";
            // 
            // gbxTime
            // 
            this.gbxTime.Controls.Add(this.dtpEnd);
            this.gbxTime.Controls.Add(this.dtpStart);
            this.gbxTime.Controls.Add(this.label4);
            this.gbxTime.Controls.Add(this.label3);
            this.gbxTime.Location = new System.Drawing.Point(132, 193);
            this.gbxTime.Name = "gbxTime";
            this.gbxTime.Size = new System.Drawing.Size(1043, 168);
            this.gbxTime.TabIndex = 7;
            this.gbxTime.TabStop = false;
            this.gbxTime.Text = "الفترة الزمنية";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(403, 93);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(226, 39);
            this.dtpEnd.TabIndex = 7;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(403, 41);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(226, 39);
            this.dtpStart.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(687, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "إلى";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(687, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "من";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxShowType);
            this.panel1.Controls.Add(this.cbxReportType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(132, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 100);
            this.panel1.TabIndex = 8;
            // 
            // gbxFields
            // 
            this.gbxFields.Controls.Add(this.cbxUnit);
            this.gbxFields.Controls.Add(this.gbxItems);
            this.gbxFields.Controls.Add(this.cbxFarmType);
            this.gbxFields.Controls.Add(this.cbxSectionName);
            this.gbxFields.Controls.Add(this.cbxTotal);
            this.gbxFields.Controls.Add(this.cbxStationName);
            this.gbxFields.Controls.Add(this.cbxPrice);
            this.gbxFields.Controls.Add(this.cbxQuantity);
            this.gbxFields.Location = new System.Drawing.Point(132, 380);
            this.gbxFields.Name = "gbxFields";
            this.gbxFields.Size = new System.Drawing.Size(1043, 211);
            this.gbxFields.TabIndex = 9;
            this.gbxFields.TabStop = false;
            this.gbxFields.Text = "الحقول";
            // 
            // cbxUnit
            // 
            this.cbxUnit.AutoSize = true;
            this.cbxUnit.Location = new System.Drawing.Point(493, 141);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(98, 36);
            this.cbxUnit.TabIndex = 3;
            this.cbxUnit.Text = "الوحدة";
            this.cbxUnit.UseVisualStyleBackColor = true;
            // 
            // gbxItems
            // 
            this.gbxItems.Controls.Add(this.clbITems);
            this.gbxItems.Location = new System.Drawing.Point(797, 38);
            this.gbxItems.Name = "gbxItems";
            this.gbxItems.Size = new System.Drawing.Size(233, 167);
            this.gbxItems.TabIndex = 2;
            this.gbxItems.TabStop = false;
            this.gbxItems.Text = "الأصناف";
            // 
            // clbITems
            // 
            this.clbITems.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbITems.FormattingEnabled = true;
            this.clbITems.Items.AddRange(new object[] {
            "الكل",
            "دواجن تسمين",
            "دواجن عتاقى",
            "بيض عتاقى",
            "بيض بشاير",
            "بيض وسط",
            "بيض كسر",
            "كتكوت عمر يوم مشعر",
            "كتكوت عمر يوم فيومى ودقى",
            "كتكوت عمر يوم سلالات مستنبطة",
            "اعلاف",
            "سبلة خشنة",
            "سبلة ناعمة",
            "أشولة فارغة"});
            this.clbITems.Location = new System.Drawing.Point(0, 43);
            this.clbITems.Name = "clbITems";
            this.clbITems.Size = new System.Drawing.Size(233, 120);
            this.clbITems.TabIndex = 0;
            this.clbITems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbITems_ItemCheck);
            // 
            // cbxFarmType
            // 
            this.cbxFarmType.AutoSize = true;
            this.cbxFarmType.Location = new System.Drawing.Point(625, 70);
            this.cbxFarmType.Name = "cbxFarmType";
            this.cbxFarmType.Size = new System.Drawing.Size(156, 36);
            this.cbxFarmType.TabIndex = 1;
            this.cbxFarmType.Text = "نوع المزرعة";
            this.cbxFarmType.UseVisualStyleBackColor = true;
            // 
            // cbxSectionName
            // 
            this.cbxSectionName.AutoSize = true;
            this.cbxSectionName.Location = new System.Drawing.Point(28, 60);
            this.cbxSectionName.Name = "cbxSectionName";
            this.cbxSectionName.Size = new System.Drawing.Size(128, 36);
            this.cbxSectionName.TabIndex = 1;
            this.cbxSectionName.Text = "اسم العنبر";
            this.cbxSectionName.UseVisualStyleBackColor = true;
            // 
            // cbxTotal
            // 
            this.cbxTotal.AutoSize = true;
            this.cbxTotal.Location = new System.Drawing.Point(42, 141);
            this.cbxTotal.Name = "cbxTotal";
            this.cbxTotal.Size = new System.Drawing.Size(114, 36);
            this.cbxTotal.TabIndex = 1;
            this.cbxTotal.Text = "الإجمالى";
            this.cbxTotal.UseVisualStyleBackColor = true;
            // 
            // cbxStationName
            // 
            this.cbxStationName.AutoSize = true;
            this.cbxStationName.Location = new System.Drawing.Point(324, 70);
            this.cbxStationName.Name = "cbxStationName";
            this.cbxStationName.Size = new System.Drawing.Size(144, 36);
            this.cbxStationName.TabIndex = 1;
            this.cbxStationName.Text = "اسم المحطة";
            this.cbxStationName.UseVisualStyleBackColor = true;
            // 
            // cbxPrice
            // 
            this.cbxPrice.AutoSize = true;
            this.cbxPrice.Location = new System.Drawing.Point(274, 141);
            this.cbxPrice.Name = "cbxPrice";
            this.cbxPrice.Size = new System.Drawing.Size(89, 36);
            this.cbxPrice.TabIndex = 1;
            this.cbxPrice.Text = "السعر";
            this.cbxPrice.UseVisualStyleBackColor = true;
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.AutoSize = true;
            this.cbxQuantity.Location = new System.Drawing.Point(650, 141);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(92, 36);
            this.cbxQuantity.TabIndex = 1;
            this.cbxQuantity.Text = "الكمية";
            this.cbxQuantity.UseVisualStyleBackColor = true;
            // 
            // cbxPortName
            // 
            this.cbxPortName.FormattingEnabled = true;
            this.cbxPortName.Items.AddRange(new object[] {
            "الكل",
            "منفذ الإدارة",
            "منفذ الشيخ حسن",
            "منفذ الفنية",
            "منفذ النهضة",
            "منفذ الرى",
            "منفذ دار رماد",
            "منفذ البارودية",
            "منفذ لطف الله"});
            this.cbxPortName.Location = new System.Drawing.Point(649, 148);
            this.cbxPortName.Name = "cbxPortName";
            this.cbxPortName.Size = new System.Drawing.Size(157, 39);
            this.cbxPortName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "اسم المنفذ";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintReport.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(670, 611);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(314, 51);
            this.btnPrintReport.TabIndex = 10;
            this.btnPrintReport.Text = "طباعة التقرير";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeReport.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReport.Location = new System.Drawing.Point(323, 611);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(314, 51);
            this.btnMakeReport.TabIndex = 11;
            this.btnMakeReport.Text = "عرض التقرير";
            this.btnMakeReport.UseVisualStyleBackColor = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CreateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 674);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnMakeReport);
            this.Controls.Add(this.cbxPortName);
            this.Controls.Add(this.gbxFields);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbxTime);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "CreateReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عمل تقرير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateReport_Load);
            this.Shown += new System.EventHandler(this.CreateReport_Shown);
            this.Resize += new System.EventHandler(this.CreateReport_Resize);
            this.gbxTime.ResumeLayout(false);
            this.gbxTime.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxFields.ResumeLayout(false);
            this.gbxFields.PerformLayout();
            this.gbxItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxReportType;
        private System.Windows.Forms.ComboBox cbxShowType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxTime;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxFields;
        private System.Windows.Forms.CheckBox cbxFarmType;
        private System.Windows.Forms.CheckBox cbxSectionName;
        private System.Windows.Forms.CheckBox cbxTotal;
        private System.Windows.Forms.CheckBox cbxStationName;
        private System.Windows.Forms.CheckBox cbxPrice;
        private System.Windows.Forms.CheckBox cbxQuantity;
        private System.Windows.Forms.CheckedListBox clbITems;
        private System.Windows.Forms.ComboBox cbxPortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.GroupBox gbxItems;
        private System.Windows.Forms.CheckBox cbxUnit;
    }
}