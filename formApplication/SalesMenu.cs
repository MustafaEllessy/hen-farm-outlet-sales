using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmApplication
{

    public partial class frmSalesMenu : Form
    {

        //1 for show 0 for enter
     public  int frmMode = 0;
        
        public frmSalesMenu()
        {
            InitializeComponent();
        }
        static SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        static SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMode = 0;
            panel1.BackgroundImage = formApplication.Properties.Resources.ادخال;

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void pnlEnter_Click(object sender, EventArgs e)
        {
            frmMode = 0;
            panel1.BackgroundImage = formApplication.Properties.Resources.ادخال;
        }

        private void pnlView_Click(object sender, EventArgs e)
        {
            frmMode = 1;
            panel1.BackgroundImage = formApplication.Properties.Resources.عرض;
        }


        private void pnlSales_Click_2(object sender, EventArgs e)
        {
            if(frmMode==0)
            {
                formApplication.Sales frm = new formApplication.Sales();
                frm.ShowDialog();
            }
           else if (frmMode == 1)
            {
                formApplication.DisplaySales frm = new formApplication.DisplaySales();
                frm.ShowDialog();
            }
        }

        private void pnlSales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pnlFeed_Paint(object sender, PaintEventArgs e)
        {

        }

        bool firstLoad = true;
        private void frmMain_Resize(object sender, EventArgs e)
        {

            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                frmMode = 1;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this,controlsDetails, controlsResult);
                firstLoad = false;
            }
            formApplication.ResizeForm.changeControls(this,controlsResult);

        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
    
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            formApplication.CreateReport frm = new formApplication.CreateReport();
            frm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
