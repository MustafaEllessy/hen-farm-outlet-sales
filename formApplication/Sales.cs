using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApplication
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxPortName.SelectedIndex == -1)
                {
                    MessageBox.Show("من فضلك إدخل اسم المنفذ بشكل صحيح ");
                    return;
                }
                string portName = cbxPortName.SelectedItem.ToString();

               
                if (dgvSales.Rows.Count == 0)
                {
                    MessageBox.Show("لم يتم إدخال بيانات");
                    return;
                }
                for (int i = 0; i < dgvSales.Rows.Count; i++)
                {
                    string saleDate = dtpSales.Value.ToString("dd/MM/yyyy");
                    string productName = dgvSales.Rows[i].Cells[4].Value.ToString();
                    string price = dgvSales.Rows[i].Cells[5].Value.ToString();
                    string quantity = dgvSales.Rows[i].Cells[6].Value.ToString();
                    string unit = dgvSales.Rows[i].Cells[7].Value.ToString();
                    string farmType= dgvSales.Rows[i].Cells[1].Value.ToString();
                    string stationName = dgvSales.Rows[i].Cells[2].Value.ToString();
                    string sectionName = dgvSales.Rows[i].Cells[3].Value.ToString();
                    if (!(isValidNumber(quantity) && isValidNumber(price)))
                    {
                        MessageBox.Show("من فضلك إدخل الرقم بشكل صحيح فى الصف رقم "+(i+1));
                        return;
                    }
                    if(productName=="")
                    {
                        MessageBox.Show("من فضلك إدخل اسم المنتج بشكل صحيح فى الصف رقم "+ (i+1));
                        return;
                    }
                    else if (unit == "")
                    {
                        MessageBox.Show("من فضلك إدخل الوحدة بشكل صحيح فى الصف رقم " + (i + 1));
                        return;
                    }
                    else if (quantity == "")
                    {
                        MessageBox.Show("من فضلك إدخل الكمية بشكل صحيح فى الصف رقم " + (i + 1));
                        return;
                    }
                    else if (price == "")
                    {
                        MessageBox.Show("من فضلك إدخل السعر بشكل صحيح فى الصف رقم " + (i + 1));
                        return;
                    }
                    else if (farmType == "")
                    {
                        MessageBox.Show("من فضلك إدخل نوع المزرعة بشكل صحيح فى الصف رقم " + (i + 1));
                        return;
                    }
                    else if (sectionName == "")
                    {
                        MessageBox.Show("من فضلك إدخل اسم العنبر بشكل صحيح فى الصف رقم " + (i + 1));
                        return;
                    }
                    else if (stationName == "")
                    {
                        MessageBox.Show("من فضلك إدخل اسم محطة بشكل صحيح فى الصف رقم " + (i + 1));
                        return;
                    }

                   if(!(farmType=="مزرعة التسمين" && stationName=="محطة 2" || farmType == "مزرعة البياض" && stationName == "محطة 3" || farmType == "مزرعة البياض" && stationName == "محطة 5"))
                    {
                        MessageBox.Show("مزرعة التسمين بها محطة 2 فقط ومزرعة البياض بها محطة 3 ومحطة 5 فقط");
                        return;
                    }
                    object[] values = new object[] { saleDate, productName, Convert.ToDecimal(quantity), unit, Convert.ToDecimal(price),portName,stationName,sectionName ,farmType};
                    DB.insertToDB("sales", new string[] { "saleDate", "productName", "quantity", "unit", "price" ,"portName","stationName","sectionName","farmType"}, values);
                }
                MessageBox.Show("تم الحفظ");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("يوجد مشكلة بالإدخال:");
                MessageBox.Show(ex.Message);
            }

        }

        private bool isValidNumber(string str)
        {
            int dotCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.') dotCounter++;
            }
            if (dotCounter > 1)
                return false;
            return true;
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        DataTable dtProducts;
        DataTable dtUnits;
        private void frmSales_Load(object sender, EventArgs e)
        {
            dtProducts = DB.Data("select * from product");
            dtUnits = DB.Data("select * from unit");
            ((DataGridViewComboBoxColumn)dgvSales.Columns["colProductName"]).DataSource = dtProducts;
            ((DataGridViewComboBoxColumn)dgvSales.Columns["colProductName"]).DisplayMember = "productName";
            ((DataGridViewComboBoxColumn)dgvSales.Columns["colProductName"]).ValueMember = "productName";
            ((DataGridViewComboBoxColumn)dgvSales.Columns["colUnit"]).DataSource = dtUnits;
            ((DataGridViewComboBoxColumn)dgvSales.Columns["colUnit"]).DisplayMember = "unitName";
            ((DataGridViewComboBoxColumn)dgvSales.Columns["colUnit"]).ValueMember = "unitName";
        }
        int serial = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            serial = dgvSales.Rows.Count + 1;
            dgvSales.Rows.Add(new object[] { serial, "", "", "", "", "", "", "", "" });
        }

        private void dgvSales_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < dgvSales.Rows.Count; i++)
            {
                dgvSales.Rows[i].Cells[0].Value = i + 1;
            }
        }


        bool firstLoad = true;
        private void Sales_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this, controlsDetails, controlsResult);
                firstLoad = false;
            }
            ResizeForm.changeControls(this, controlsResult);
        }
        int currentRowIndex=-1, currentColIndex = -1;
        private void dgvSales_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);

            int colIndex = ((DataGridView)sender).CurrentCell.ColumnIndex;
            if (!(colIndex == 5 || colIndex == 6)) return;
            else
            {
                currentColIndex = colIndex;
                currentRowIndex = ((DataGridView)sender).CurrentCell.RowIndex;
            }

            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='.'  )
            {
                return;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
