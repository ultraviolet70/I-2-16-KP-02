using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace Shop
{
    public partial class FormCreateOrder : Form
    {

        public FormCreateOrder()
        {
            InitializeComponent();
            FormAuthoriz.sql.Open();
            SqlCommand command2 = new SqlCommand("SELECT Surname_client FROM Client", FormAuthoriz.sql);
            SqlCommand command7 = new SqlCommand("SELECT Surname_employee FROM Employee", FormAuthoriz.sql);
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                cbKlient.Items.Add(read2.GetValue(0).ToString());
            }
            read2.Close();

            SqlDataReader read7 = command7.ExecuteReader();
            while (read7.Read())
            {
                cbEmployee.Items.Add(read7.GetValue(0).ToString());
            }
            read7.Close();
            FormAuthoriz.sql.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void FormCreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
            GetData();
            dataGridViewTovar.Columns["ID_Product"].Visible = false;
        }

        public SqlCommand command = new SqlCommand("Select [ID_Product], [Name_product] as 'Наименование товара', [Const_product] as 'Цена товара', [Type_product_ID] as 'Категория товара' from [dbo].[Product]");
        public void GetData()
        {
            Action act = () =>
            {
                command.Connection = FormAuthoriz.sql;
                command.Notification = null;
                SqlDependency dependency = new SqlDependency(command);
                SqlDependency.Start(FormAuthoriz.sql.ConnectionString);
                dependency.OnChange += new OnChangeEventHandler(OnDataChanget);
                FormAuthoriz.sql.Open();
                DataTable data = new DataTable();
                data.Load(command.ExecuteReader());
                dataGridViewTovar.DataSource = data;
                FormAuthoriz.sql.Close();
            };
            Invoke(act);
        }

        public void OnDataChanget(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                GetData();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            FormAddClient child = new FormAddClient(this);
            child.Show();
        }

        Word.Application winword = new Word.Application(); //создаем COM-объект Word

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                winword.Visible = false;
                object missing = System.Reflection.Missing.Value;
                Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                //Добавление верхнего колонтитула
                foreach (Word.Section section in document.Sections)
                {
                    Word.Range header =
                    section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    header.Fields.Add(header, Word.WdFieldType.wdFieldPage);
                    header.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    header.Font.ColorIndex = Word.WdColorIndex.wdGreen;
                    header.Font.Size = 11;
                    header.Text = "Форма чека " + tbNumberOrder.Text;
                    header.Font.Name = "Times New Roman";
                }
                //Добавление параграфа
                Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                //Создание таблицы 
                Word.Table table = document.Tables.Add(para1.Range, 1, 2, ref missing, ref missing);
                table.Borders.Enable = 1;
                foreach (Word.Row row in table.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Задаем шрифт и размер текста
                        cell.Range.Font.Name = "Times New Roman";
                        cell.Range.Font.Size = 12;
                        cell.Range.Font.Bold = 1;
                        //Выравнивание текста по центру, удаление интервалов
                        cell.VerticalAlignment =
                        Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        table.Range.Paragraphs.SpaceAfter = 0;
                        winword.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
                        //Значения ячеек
                        table.Cell(1, 2).Range.Text = "Магазин MakeUP" + "\n" + DateTime.Today.ToShortDateString() + "\n" + tbPriceOrder.Text + " руб." + "\n" + cbEmployee.Text + " сотрудник." + cbKlient.Text + " клиент.";
                        table.Cell(1, 1).Range.Text = "Сумма чека";
                    }
                }
                winword.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
