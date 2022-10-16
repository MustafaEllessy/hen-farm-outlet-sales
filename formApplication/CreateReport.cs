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
    public partial class CreateReport : Form
    {
        string cmd = "";
        DataTable dtCMD;
        List<string> columnsNames;
        int totalPageNO = 0;
        int currPage = 0;
        int rowsCounter = 0;
        public CreateReport()
        {
            InitializeComponent();
        }

        private void CreateReport_Shown(object sender, EventArgs e)
        {
            defaultReport();
        }

        private void defaultReport()
        {
            clbITems.CheckOnClick = true;
            cbxReportType.SelectedIndex = 0;
            cbxShowType.SelectedIndex = 0;
            cbxPortName.SelectedIndex = 0;
            clbITems.SetItemChecked(0, true);
            cbxTotal.Checked = true;
        }
        public void prepareReport()
        {
            if (dtCMD.Rows.Count < 15)
            {
                totalPageNO = 1;
            }
            else
            {
                float remain = dtCMD.Rows.Count - 17;
                totalPageNO = 1 + Convert.ToInt32(Math.Ceiling(remain / 21));

            }
            currPage = 1;
            rowsCounter = 0;
        }
        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            if (checkConditions())
            {
                cmd = makeCMD();
                dtCMD = DB.Data(cmd);
                prepareReport();
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                printPreviewDialog1.ShowDialog();
            }
            reportShown = true;
       }
        private string makeCMD()
        {
            columnsNames = new List<string>();
            string cmd = "select saleDate ";
            columnsNames.Add("التاريخ");
            List<string> items;
            items = getItems();
            //all ports
            if (cbxPortName.SelectedIndex == 0)
            {
                cmd += ", portName ";
                columnsNames.Add("المنفذ");
            }
            //مفصل
            if (cbxShowType.SelectedIndex == 0)
            {
            

                if (cbxFarmType.Checked)
                {
                    cmd += ", farmType ";
                    columnsNames.Add("المزرعة");
                }
                if (cbxStationName.Checked)
                {
                    cmd += ", stationName ";
                    columnsNames.Add("المحطة");
                }
                if (cbxSectionName.Checked)
                {
                    cmd += ", sectionName ";
                    columnsNames.Add("العنبر");
                }
                cmd += ", productName ";
                columnsNames.Add("المنتج");
                if (cbxUnit.Checked)
                {
                    cmd += ", unit ";
                    columnsNames.Add("الوحدة");
                }
                if (cbxPrice.Checked)
                {
                    cmd += ", price ";
                    columnsNames.Add("السعر");
                }
                if (cbxQuantity.Checked)
                {
                    cmd += ", quantity ";
                    columnsNames.Add("الكمية");
                }
                if (cbxTotal.Checked)
                {
                    cmd += ", price*quantity as total ";
                    columnsNames.Add("الإجمالى");
                }
                cmd += " from sales ";
                DateTime dt1 = dtpStart.Value;
                DateTime dt2 = dtpEnd.Value;
                cmd += "where saleDate >=#" + dt1.ToString("yyyy/MM/dd") + "# and saleDate <= #" + dt2.ToString("yyyy/MM/dd") + "# ";
                if(cbxPortName.SelectedIndex!=0)
                {
                    cmd += "and portName='" + cbxPortName.SelectedItem.ToString() + "' ";
                }
                if (!clbITems.GetItemChecked(0) )
                {
                    cmd += "and productName IN (";
                    for (int i = 0; i < clbITems.CheckedItems.Count; i++)
                    {
                        cmd += "'" + clbITems.CheckedItems[i].ToString() + "'";
                        if (clbITems.CheckedItems.Count-1==i)
                        {
                            cmd += ") ";
                        }
                        else
                        {
                            cmd += ", ";
                        }
                    }

                   
                }
                cmd += "order by saleDate ";
                if(cbxPortName.SelectedIndex==0)
                {
                    cmd += ",portName ";
                }
                cmd += " ,productName;";
            }
            //مجمل
            else
            {
                cmd += ", sum(price*quantity) as total";
                columnsNames.Add("الإجمالى");
                cmd += " from sales ";
                DateTime dt1 = dtpStart.Value;
                DateTime dt2 = dtpEnd.Value;
                cmd += "where saleDate >=#" + dt1.ToString("yyyy/MM/dd") + "# and saleDate <= #" + dt2.ToString("yyyy/MM/dd") + "# ";
                if(cbxPortName.SelectedIndex!=0)
                {
                    string portName = cbxPortName.SelectedItem.ToString();
                    cmd += "and portName='" + portName + "' ";
                }
                cmd += "group  by saleDate ";
                if (cbxPortName.SelectedIndex == 0)
                    cmd += ", portName ";
                cmd += " order by saleDate";
                if (cbxPortName.SelectedIndex == 0)
                    cmd += ", portName;";

            }

            return cmd;
        }
        private List<string> getItems()
        {
            List<string> items = new List<string>();
        if(clbITems.GetItemChecked(0))
                for (int i = 1; i < clbITems.Items.Count; i++)
                {
                    items.Add(clbITems.Items[i].ToString());
                }
        else
            {
                for (int i = 0; i < clbITems.CheckedItems.Count; i++)
                {
                    items.Add(clbITems.CheckedItems[i].ToString());
                }
            }
            return items;
        }
        private bool checkConditions()
        {

             if (cbxReportType.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار نوع التقرير من القائمة");
                return false;
            }
            else if (cbxShowType.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار نوع العرض من القائمة");
                return false;
            }
            else if (cbxPortName.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار اسم المنفذ من القائمة");
                return false;
            }
            else if (!checkTime())
            {
                MessageBox.Show("يجب أن يكون تاريخ البدأ قبل تاريخ الإنتهاء");
                return false;
            }
            else if (clbITems.CheckedItems.Count==0)
            {
                MessageBox.Show("يجب اختيار صنف واحد على الأقل ");
                return false;
            }
            else if (!cbxFarmType.Checked && !cbxSectionName.Checked && !cbxStationName.Checked && !cbxQuantity.Checked && !cbxPrice.Checked && !cbxTotal.Checked )
            {
                MessageBox.Show("يجب اختيار على الأقل حقل اخر مع الصنف ");
                return false;
            }
          

            return true;
        }
        private bool checkTime()
        {
            int day1 = dtpStart.Value.Day;
            int day2 = dtpEnd.Value.Day;
            int month1 = dtpStart.Value.Month;
            int month2 = dtpEnd.Value.Month;
            int year1 = dtpStart.Value.Year;
            int year2 = dtpEnd.Value.Year;
            if (year2 > year1 || (year2 == year1 && month2 > month1) || (year2 == year1 && month2 == month1 && day2 >= day1))
            {
                return true;
            }

            else
            {
                return false;
            }

        }
        private void cbxShowType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxShowType.SelectedIndex==1)
            {
                gbxFields.Enabled = false;
            }
            else if (cbxShowType.SelectedIndex == 0)
            {
                gbxFields.Enabled = true ;
            }
        }
        private void CreateReport_Load(object sender, EventArgs e)
        {
          
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        bool firstLoad = true;
     
         private void CreateReport_Resize(object sender, EventArgs e)
        {
                if (firstLoad)
                {
                formApplication.ResizeForm.initialFormHeight = 757;
                    formApplication.ResizeForm.initialFormWidth = 1313;
                    formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                    formApplication.ResizeForm.setControlResult(this, controlsDetails, controlsResult);
                    firstLoad = false;
                }
                ResizeForm.changeControls(this, controlsResult);  
        }

        private void clbITems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(clbITems.GetItemChecked(0))
            {
                e.NewValue = CheckState.Unchecked;
            }
            else
            {
                if(clbITems.CheckedIndices.Count>0 && e.Index==0)
                    e.NewValue = CheckState.Unchecked;
            }
          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (currPage <= totalPageNO)
            {
                if (currPage == 1)
                {
                    //begin of template drawing
                    string startDate = dtpStart.Value.ToString("yyyy/MM/dd");
                    string endDate = dtpEnd.Value.ToString("yyyy/MM/dd");
                    int pageWidth = e.PageBounds.Width;
                    int pageHeight = e.PageBounds.Height;
                    int leftMargin = 50;
                    int topMargin = 50;
                    Font logoTitleFont = new Font("Arial", 16, FontStyle.Bold);
                    Font mainTitleFont = new Font("Arial", 20, FontStyle.Bold);
                    string udaTitle = "هيئة تنمية الصعيد";
                    Image logoImg = formApplication.Properties.Resources.logo1;
                    int imgHight = logoImg.Height;
                    int tableTopMargin = imgHight + 5;
                    int tableHeight = pageHeight - tableTopMargin - 30;
                    int tableWidth = pageWidth - (leftMargin * 2);
                    string timeP1 = "الفترة الزمنية";
                    string timeP2 = "من " + startDate;
                    string timeP3 = "الى " + endDate;
                    e.Graphics.DrawImage(logoImg, new Point(leftMargin, topMargin));                
                    e.Graphics.DrawString(udaTitle, logoTitleFont, Brushes.Black, new Point(leftMargin, imgHight - 25));
                    SizeF titileSize = e.Graphics.MeasureString("المبيعات", mainTitleFont);
                    int titleTopMargin = topMargin + 10;
                    e.Graphics.DrawString("المبيعات", mainTitleFont, Brushes.Black, new Point(pageWidth / 2 - Convert.ToInt32(titileSize.Width / 2), titleTopMargin));
                    if(cbxPortName.SelectedIndex!=0)
                    {
                        string portName =convertToArabicNumbers( cbxPortName.SelectedItem.ToString());

                        SizeF titileSize2 = e.Graphics.MeasureString(portName, mainTitleFont);

                        e.Graphics.DrawString(portName, mainTitleFont, Brushes.Black, new Point(pageWidth / 2 - Convert.ToInt32(titileSize2.Width / 2), Convert.ToInt32(titleTopMargin + titileSize.Height)+10));
                    }
                    //draw time
                    SizeF timeP1Size = e.Graphics.MeasureString(timeP1, mainTitleFont);
                    SizeF timeP2Size = e.Graphics.MeasureString(timeP2, mainTitleFont);
                    SizeF timeP3Size = e.Graphics.MeasureString(timeP3, mainTitleFont);
                    int timeTopMargin = titleTopMargin + 33;
                    e.Graphics.DrawString(timeP1, mainTitleFont, Brushes.Black, new Point(pageWidth - leftMargin - Convert.ToInt32(timeP1Size.Width), timeTopMargin));
                    e.Graphics.DrawString(convertToArabicNumbers(timeP2), mainTitleFont, Brushes.Black, new Point(pageWidth - leftMargin - Convert.ToInt32(timeP2Size.Width), timeTopMargin + Convert.ToInt32(timeP1Size.Height)));
                    e.Graphics.DrawString(convertToArabicNumbers(timeP3), mainTitleFont, Brushes.Black, new Point(pageWidth - leftMargin - Convert.ToInt32(timeP3Size.Width), timeTopMargin + Convert.ToInt32(timeP1Size.Height) + Convert.ToInt32(timeP2Size.Height)));
                    e.Graphics.DrawRectangle(Pens.Black, leftMargin, tableTopMargin, tableWidth, tableHeight);
           //end of Template drawing
                    

                    int tableStartX = leftMargin;
                    int startX = leftMargin;
                    int tableStartY = tableTopMargin;
                    int endX = leftMargin + tableWidth;
                    int columnWidth = tableWidth / columnsNames.Count;
                    int rowHeight = tableHeight / 18;

                    for (int i = 0; i < columnsNames.Count - 1; i++)
                    {
                        tableStartX += columnWidth;
                        e.Graphics.DrawLine(Pens.Black, new Point(tableStartX, tableStartY), new Point(tableStartX, tableStartY + tableHeight));
                    }
                    //make rows
                    int rowIndexer = tableTopMargin;
                    for (int i = 0; i < 17; i++)
                    {
                        rowIndexer += rowHeight;
                        e.Graphics.DrawLine(Pens.Black, new Point(startX, rowIndexer), new Point(endX, rowIndexer));
                    }
                    //draw header
                    Font headerTitleFont = new Font("Arial", 18, FontStyle.Bold);
                    int rowWriterX = leftMargin;
                    int rowWriterY = tableTopMargin;
                    SizeF tHeader = e.Graphics.MeasureString("start", headerTitleFont);
                    for (int i = columnsNames.Count - 1; i >= 0; i--)
                    {
                        for (int k = 18; k >= 14; k--)
                        {
                            headerTitleFont = new Font("Arial", k, FontStyle.Bold);
                            tHeader = e.Graphics.MeasureString(columnsNames[i], headerTitleFont);
                            if (tHeader.Width < columnWidth)
                                break;
                        }
                        int wordWidthMid = Convert.ToInt32((tHeader.Width / 2));
                        int wordHeightMid = Convert.ToInt32((tHeader.Height / 2));
                        int xSpace = (columnWidth / 2) - wordWidthMid;
                        int ySpace = (rowHeight / 2) - wordHeightMid;
                        e.Graphics.DrawString(columnsNames[i], headerTitleFont, Brushes.Black, new Point(rowWriterX + xSpace, rowWriterY + ySpace));
                        rowWriterX += columnWidth;
                    }
                    
                    //draw data
                    rowWriterX = leftMargin;
                    rowWriterY += rowHeight;
                    for (int k = 0; ((k < 17) && (k < dtCMD.Rows.Count)); k++)
                    {
                        rowWriterX = leftMargin;
                        for (int i = dtCMD.Columns.Count - 1; i >= 0; i--)
                        {
                            //write word
                            string theWord = dtCMD.Rows[k][i].ToString();
                            if (columnsNames[i] == "التاريخ")
                                theWord = ((DateTime)(dtCMD.Rows[k][i])).ToString("MM/dd");
                           
                            theWord = convertToArabicNumbers(theWord);
                            for (int l = 18; l >= 10; l--)
                            {
                                headerTitleFont = new Font("Arial", l, FontStyle.Bold);
                                tHeader = e.Graphics.MeasureString(theWord, headerTitleFont);
                                if (tHeader.Width < columnWidth)
                                    break;
                            }
                    
                            int wordWidthMid = Convert.ToInt32((tHeader.Width / 2));
                            int wordHeightMid = Convert.ToInt32((tHeader.Height / 2));
                            int xSpace = (columnWidth / 2) - wordWidthMid;
                            int ySpace = (rowHeight / 2) - wordHeightMid;


                            e.Graphics.DrawString(theWord, headerTitleFont, Brushes.Black, new Point(rowWriterX + xSpace, rowWriterY + ySpace));
                            rowWriterX += columnWidth;
                        }
                        rowWriterY += rowHeight;
                }
            }
                else
                {
                    //make rows
                    int tableTopMargin = 30;
                    int leftMargin = 50;
                    int pageWidth = e.PageBounds.Width;
                    int tableStartX = leftMargin;
                    int tableStartY = tableTopMargin;
                    int tableHeight = e.PageBounds.Height - 60;
                    int tableWidth = pageWidth - (leftMargin * 2);
                    int startX = leftMargin;
                    int endX = leftMargin + tableWidth;
                    int columnWidth = tableWidth / columnsNames.Count;
                    int rowHeight = tableHeight / 22;
                    //draw table
                    int rowIndexer = tableTopMargin;
                    e.Graphics.DrawRectangle(Pens.Black, leftMargin, tableTopMargin, tableWidth, tableHeight);
                    for (int i = 0; i < columnsNames.Count - 1; i++)
                    {
                        tableStartX += columnWidth;
                        e.Graphics.DrawLine(Pens.Black, new Point(tableStartX, tableStartY), new Point(tableStartX, tableStartY + tableHeight));
                    }
                    for (int i = 0; i < 21; i++)
                    {
                        rowIndexer += rowHeight;
                        e.Graphics.DrawLine(Pens.Black, new Point(startX, rowIndexer), new Point(endX, rowIndexer));
                    }

                    //draw header
                    Font headerTitleFont = new Font("Arial", 18, FontStyle.Bold);
                    int rowWriterX = leftMargin;
                    int rowWriterY = tableTopMargin;
                    SizeF tHeader = e.Graphics.MeasureString("start", headerTitleFont);
                    for (int i = columnsNames.Count - 1; i >= 0; i--)
                    {
                        for (int k = 18; k >= 14; k--)
                        {
                            headerTitleFont = new Font("Arial", k, FontStyle.Bold);
                            tHeader = e.Graphics.MeasureString(columnsNames[i], headerTitleFont);
                            if (tHeader.Width < columnWidth)
                                break;
                        }
                        int wordWidthMid = Convert.ToInt32((tHeader.Width / 2));
                        int wordHeightMid = Convert.ToInt32((tHeader.Height / 2));
                        int xSpace = (columnWidth / 2) - wordWidthMid;
                        int ySpace = (rowHeight / 2) - wordHeightMid;
                        e.Graphics.DrawString(columnsNames[i], headerTitleFont, Brushes.Black, new Point(rowWriterX + xSpace, rowWriterY + ySpace));
                        rowWriterX += columnWidth;
                    }
                    //draw data
                    rowWriterX = leftMargin;
                    rowWriterY += rowHeight;
                    for (int k = rowsCounter; ((k < (rowsCounter + 21)) && (k < dtCMD.Rows.Count)); k++)
                    {
                        rowWriterX = leftMargin;
                        for (int i = dtCMD.Columns.Count - 1; i >= 0; i--)
                        {
                            //write word
                            string theWord = dtCMD.Rows[k][i].ToString();
                            if (columnsNames[i] == "التاريخ")
                                theWord = ((DateTime)(dtCMD.Rows[k][i])).ToString("MM/dd");
                       
                            theWord = convertToArabicNumbers(theWord);
                            for (int l = 18; l >= 10; l--)
                            {
                                headerTitleFont = new Font("Arial", l, FontStyle.Bold);
                                tHeader = e.Graphics.MeasureString(theWord, headerTitleFont);
                                if (tHeader.Width < columnWidth)
                                    break;
                            }
                            int wordWidthMid = Convert.ToInt32((tHeader.Width / 2));
                            int wordHeightMid = Convert.ToInt32((tHeader.Height / 2));
                            int xSpace = (columnWidth / 2) - wordWidthMid;
                            int ySpace = (rowHeight / 2) - wordHeightMid;


                            e.Graphics.DrawString(theWord, headerTitleFont, Brushes.Black, new Point(rowWriterX + xSpace, rowWriterY + ySpace));
                            rowWriterX += columnWidth;
                        }
                        rowWriterY += rowHeight;
                    }
                    rowsCounter += 21;
                }
                currPage++;
                if (currPage <= totalPageNO)
                    e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

        }
        public string convertToArabicNumbers(string str)
        {
            string strNew = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    strNew += "١";
                }
                else if (str[i] == '2')
                {
                    strNew += "٢";
                }
                else if (str[i] == '3')
                {
                    strNew += "٣";
                }
                else if (str[i] == '4')
                {
                    strNew += "٤";
                }
                else if (str[i] == '5')
                {
                    strNew += "٥";
                }
                else if (str[i] == '6')
                {
                    strNew += "٦";
                }
                else if (str[i] == '7')
                {
                    strNew += "٧";
                }
                else if (str[i] == '8')
                {
                    strNew += "٨";
                }
                else if (str[i] == '9')
                {
                    strNew += "٩";
                }
                else if (str[i] == '0')
                {
                    strNew += "٠";
                }
                else
                {
                    strNew += str[i];
                }

            }
            return strNew;
        }
        bool reportShown = false;   
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if(!reportShown)
            {
                MessageBox.Show("يجب عرض التقرير اولا");
                return;
            }
            DialogResult rslt= printDialog1.ShowDialog();
            if(rslt==DialogResult.OK)
            {
                printDocument1.Print();
            }
            reportShown = false;
        }
    }
}
