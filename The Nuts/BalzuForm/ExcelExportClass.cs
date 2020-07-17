using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace The_Nuts.BalzuForm
{
    public class ExcelExportClass
    {
        public void ExportExcel()
        {
            try
            {
                Application application = new Application();
                Workbook workbook = application.Workbooks.Open(Filename:AppDomain.CurrentDomain.BaseDirectory+ "\\거래명세서Excel.xlsx");
                Worksheet worksheet = workbook.Worksheets.Item[0];
                Range range = worksheet.Cells[1,1];
                range.Value = 1;
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
            }
        }
    }
}
