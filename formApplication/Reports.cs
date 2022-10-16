using Microsoft.Reporting.WinForms;
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
    public partial class Reports : Form
    {
       
        public Reports()
        {
            InitializeComponent();
        }

   
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmFarms_Load(object sender, EventArgs e)
        {

        }
        bool firstLoad = true;
        private void FarmsMenu_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this,controlsDetails, controlsResult);
                firstLoad = false;
            }
            ResizeForm.changeControls(this, controlsResult);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            DataTable tblShow = new DataTable();
            tblShow = DB.Data("select * from  dailySales");
            ReportDataSource rds = new ReportDataSource("ds1", tblShow);
            Report1 frm = new Report1();
            frm.reportViewer2.LocalReport.DataSources.Clear();
            frm.reportViewer2.LocalReport.DataSources.Add(rds);
            frm.reportViewer2.LocalReport.Refresh();
            frm.ShowDialog();
        }
    }
}
