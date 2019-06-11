using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Shop
{
    public partial class FormAddDocument : Form
    {

        string s;
        double a;
        double b;
        double c;

        public FormAddDocument()
        {
            InitializeComponent();
        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void FormAddDocument_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            a = Convert.ToDouble(s);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s = textBox2.Text;
            b = Convert.ToDouble(s);
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            c = a - b;
            textBox3.Text = Convert.ToString(c);
        }

        private void FormAddDocument_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        Excel.Application winex = new Excel.Application(); //создаем COM-объект Excel

        private void buttonCreateDocument_Click(object sender, EventArgs e)
        {
            try
            {
                winex.Visible = false;
                winex.SheetsInNewWorkbook = 1;
                Excel.Workbook workBook = winex.Workbooks.Add(Type.Missing);
                winex.DisplayAlerts = false;
                Excel.Worksheet sheet = (Excel.Worksheet)winex.Worksheets.get_Item(1);
                //Название листа (вкладки снизу)
                sheet.Name = "Финансовый отчет";
                //Захватываем диапазон ячеек
                Excel.Range range1 = sheet.get_Range("A2", "F2").Cells;
                // Производим объединение
                range1.Merge(Type.Missing);
                sheet.Cells[2, 1] = "Финансовый отчет";
                range1.Cells.Font.Name = "Times New Roman";
                range1.Cells.Font.Size = 12;
                range1.Cells.Font.Bold = 1;
                range1.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                range1.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                //Захватываем диапазон ячеек
                Excel.Range range0 = sheet.get_Range("A3", "F3").Cells;
                // Производим объединение
                range0.Merge(Type.Missing);
                sheet.Cells[3, 1] = "Предприятия MakeUP";
                range0.Cells.Font.Name = "Times New Roman";
                range0.Cells.Font.Size = 10;
                range0.Cells.Font.Bold = 1;
                range0.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                range0.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                //Растановка рамок
                range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight =
                Excel.XlBorderWeight.xlThin;
                range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).Weight =
                Excel.XlBorderWeight.xlThin;
                range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).Weight =
                Excel.XlBorderWeight.xlThin;
                range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).Weight =
                Excel.XlBorderWeight.xlThin;
                //Захватываем диапазон ячеек
                Excel.Range range5 = sheet.get_Range("A4", "C5").Cells;
                // Производим объединение
                range5.Merge(Type.Missing);
                //Растановка рамок
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight =
                Excel.XlBorderWeight.xlThin;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).Weight =
                Excel.XlBorderWeight.xlThin;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).Weight =
                Excel.XlBorderWeight.xlThin;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).Weight =
                Excel.XlBorderWeight.xlThin;
                sheet.Cells[4, 1] = "Доходы отдела продаж";
                //Захватываем диапазон ячеек
                Excel.Range range6 = sheet.get_Range("D4", "F5").Cells;
                // Производим объединение
                range6.Merge(Type.Missing);
                //Растановка рамок
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight =
                Excel.XlBorderWeight.xlThin;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).Weight =
                Excel.XlBorderWeight.xlThin;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).Weight =
                Excel.XlBorderWeight.xlThin;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).Weight =
                Excel.XlBorderWeight.xlThin;
                sheet.Cells[4, 4] = textBox1.Text + " руб.";
                //Захватываем диапазон ячеек
                Excel.Range range7 = sheet.get_Range("A6", "C7").Cells;
                // Производим объединение
                range7.Merge(Type.Missing);
                //Растановка рамок
                range7.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight =
                Excel.XlBorderWeight.xlThin;
                range7.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).Weight =
                Excel.XlBorderWeight.xlThin;
                range7.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).Weight =
                Excel.XlBorderWeight.xlThin;
                range7.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).Weight =
                Excel.XlBorderWeight.xlThin;
                sheet.Cells[6, 1] = "Расходы от поставок";
                //Захватываем диапазон ячеек
                Excel.Range range8 = sheet.get_Range("D6", "F7").Cells;
                // Производим объединение
                range8.Merge(Type.Missing);
                //Растановка рамок
                range8.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight =
                Excel.XlBorderWeight.xlThin;
                range8.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).Weight =
                Excel.XlBorderWeight.xlThin;
                range8.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).Weight =
                Excel.XlBorderWeight.xlThin;
                range8.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).Weight =
                Excel.XlBorderWeight.xlThin;
                sheet.Cells[6, 4] = textBox2.Text + " руб.";
                winex.Visible = true;
                sheet.Cells[8, 1] = "Итог";
                //Захватываем диапазон ячеек
                Excel.Range range9 = sheet.get_Range("D6", "F8").Cells;
                // Производим объединение
                range6.Merge(Type.Missing);
                sheet.Cells[8, 4] = textBox2.Text + " руб.";
                winex.Visible = true;
                sheet.Cells[10, 1] = "Дата начала";
                //Захватываем диапазон ячеек
                Excel.Range range10 = sheet.get_Range("D6", "F9").Cells;
                // Производим объединение
                range6.Merge(Type.Missing);
                sheet.Cells[10, 4] = dateTimePickerStart.Text;
                winex.Visible = true;
                sheet.Cells[12, 1] = "Дата окончания";
                //Захватываем диапазон ячеек
                Excel.Range range12 = sheet.get_Range("D6", "F10").Cells;
                // Производим объединение
                range6.Merge(Type.Missing);
                sheet.Cells[12, 4] = dateTimePickerFinish.Text;
                winex.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
