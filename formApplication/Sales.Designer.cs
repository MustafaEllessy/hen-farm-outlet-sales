namespace formApplication
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpSales = new System.Windows.Forms.DateTimePicker();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colSerialNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFarmType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colStationName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSectionName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQunatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbxPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightBlue;
            this.btnAdd.Location = new System.Drawing.Point(12, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 50);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 22.2F);
            this.btnSave.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSave.Location = new System.Drawing.Point(557, 626);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(212, 46);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpSales
            // 
            this.dtpSales.Location = new System.Drawing.Point(571, 14);
            this.dtpSales.Name = "dtpSales";
            this.dtpSales.Size = new System.Drawing.Size(212, 39);
            this.dtpSales.TabIndex = 21;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToResizeColumns = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeight = 50;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNO,
            this.colFarmType,
            this.colStationName,
            this.colSectionName,
            this.colProductName,
            this.colPrice,
            this.colQunatity,
            this.colUnit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.Location = new System.Drawing.Point(12, 65);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSales.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSales.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSales.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSales.RowTemplate.Height = 60;
            this.dgvSales.Size = new System.Drawing.Size(1273, 560);
            this.dgvSales.TabIndex = 17;
            this.dgvSales.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSales_EditingControlShowing);
            this.dgvSales.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvSales_RowsRemoved);
            // 
            // colSerialNO
            // 
            this.colSerialNO.FillWeight = 40F;
            this.colSerialNO.HeaderText = "م";
            this.colSerialNO.MinimumWidth = 6;
            this.colSerialNO.Name = "colSerialNO";
            this.colSerialNO.ReadOnly = true;
            this.colSerialNO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSerialNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFarmType
            // 
            this.colFarmType.FillWeight = 90F;
            this.colFarmType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colFarmType.HeaderText = "نوع المزرعة";
            this.colFarmType.Items.AddRange(new object[] {
            "مزرعة البياض",
            "مزرعة التسمين"});
            this.colFarmType.Name = "colFarmType";
            // 
            // colStationName
            // 
            this.colStationName.FillWeight = 90F;
            this.colStationName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colStationName.HeaderText = "اسم المحطة";
            this.colStationName.Items.AddRange(new object[] {
            "محطة 2",
            "محطة 3",
            "محطة 5"});
            this.colStationName.Name = "colStationName";
            // 
            // colSectionName
            // 
            this.colSectionName.FillWeight = 70F;
            this.colSectionName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colSectionName.HeaderText = "اسم العنبر";
            this.colSectionName.Items.AddRange(new object[] {
            "1أ",
            "1ب",
            "2أ",
            "2ب",
            "3أ",
            "3ب",
            "4أ",
            "4ب",
            "5أ",
            "5ب",
            "6أ",
            "6ب"});
            this.colSectionName.Name = "colSectionName";
            this.colSectionName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "product";
            this.colProductName.FillWeight = 150F;
            this.colProductName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colProductName.HeaderText = "اسم المنتج";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPrice
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPrice.HeaderText = "السعر";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQunatity
            // 
            this.colQunatity.HeaderText = "الكمية";
            this.colQunatity.MinimumWidth = 6;
            this.colQunatity.Name = "colQunatity";
            this.colQunatity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQunatity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "unit";
            this.colUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.MinimumWidth = 6;
            this.colUnit.Name = "colUnit";
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cbxPortName
            // 
            this.cbxPortName.FormattingEnabled = true;
            this.cbxPortName.Items.AddRange(new object[] {
            "منفذ 1",
            "منفذ 2",
            "منفذ 3",
            "منفذ 4",
            "منفذ 5 ",
            "منفذ 6",
            "منفذ 7"});
            this.cbxPortName.Location = new System.Drawing.Point(199, 19);
            this.cbxPortName.Name = "cbxPortName";
            this.cbxPortName.Size = new System.Drawing.Size(271, 39);
            this.cbxPortName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "اسم المنفذ";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPortName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpSales);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.Resize += new System.EventHandler(this.Sales_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpSales;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.ComboBox cbxPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQunatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSectionName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStationName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colFarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNO;
    }
}