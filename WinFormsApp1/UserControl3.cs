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
using System.Reflection;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UserControl3 : UserControl
    {
        Excel.Application app;
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;

        public UserControl3()
        {
            InitializeComponent();

        }

        private void CreateTable()
        {
            string[] fejléc = new string[]
            {
                "Id",
                "Name",
            };

            for (int i = 0; i < fejléc.Length; i++)
            {
                worksheet.Cells[1, i + 1] = fejléc[i];
            }

            StudiesContext context = new StudiesContext();
            var times = context.Times.ToList();

            object[,] data = new object[times.Count(), fejléc.Count()];

            for (int i = 0; i < times.Count(); i++)
            {
                data[i, 0] = times[i].TimeId;
                data[i, 1] = times[i].Name;
            }

            int sor = data.GetLength(0);
            int oszlop = data.GetLength(1);

            Excel.Range adatRange = worksheet.get_Range("A2", Missing.Value).get_Resize(sor, oszlop);
            adatRange.Value2 = data;
            adatRange.Columns.AutoFit();
        }

        private void CreateExcel()
        {
            try
            {
                app = new Excel.Application();
                workbook = app.Workbooks.Add(Missing.Value);
                worksheet = workbook.ActiveSheet;

                CreateTable();

                app.Visible = true;
                app.UserControl = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

                workbook.Close(false, Type.Missing, Type.Missing);
                app.Quit();
                workbook = null;
                app = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (app != null)
            {
                Formázás();
            }
            else
            {
                MessageBox.Show("Először nyisd meg az Excelt!");
            }
        }

        private void Formázás()
        {
            try
            {
                Excel.Range fejlécRange = worksheet.get_Range("A1", Missing.Value).get_Resize(1, 2);
                fejlécRange.Font.Bold = true;
                fejlécRange.Interior.Color = Color.Fuchsia;
                fejlécRange.Font.Color = Color.White;
                fejlécRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                fejlécRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Először nyisd meg az Excelt!");
            }
        }
    }
}
