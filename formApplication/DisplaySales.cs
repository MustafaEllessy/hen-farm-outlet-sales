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
    public partial class DisplaySales : Form
    {
        DataTable dtSales;
        
        public DisplaySales()
        {
            InitializeComponent();
        }

        private void frmSalesDisplay_Load(object sender, EventArgs e)
        {
            dtSales = DB.Data("select * from sales");
            dgvSales.DataSource = dtSales;
            dgvSales.Columns["ID"].Visible = false;
            dgvSales.ClearSelection();
            dgvSales.Columns["colSaleDate"].DisplayIndex = 0;
            dgvSales.Columns["colPortName"].DisplayIndex = 1;
            dgvSales.Columns["colFarmType"].DisplayIndex = 2;
            dgvSales.Columns["colStationName"].DisplayIndex = 3;
            dgvSales.Columns["colSectionName"].DisplayIndex = 4;
            dgvSales.Columns["colProductName"].DisplayIndex = 5;
            dgvSales.Columns["colPrice"].DisplayIndex = 6;
            dgvSales.Columns["colUnit"].DisplayIndex = 7;
            dgvSales.Columns["colQuantity"].DisplayIndex = 8;
            dgvSales.Sort(dgvSales.Columns["colSaleDate"], ListSortDirection.Descending);
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
