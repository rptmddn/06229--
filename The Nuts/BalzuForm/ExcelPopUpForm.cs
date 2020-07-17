using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.IO;
using System.Net.Mail;

namespace The_Nuts.BalzuForm
{
    public partial class ExcelPopUpForm : Form
    {
        public ExcelPopUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application application = new Excel.Application();
                Workbook workbook = application.Workbooks.Open(Filename: AppDomain.CurrentDomain.BaseDirectory + ".\\BalzuForm\\거래명세서Excel.xlsx");
                Worksheet worksheet = workbook.Worksheets.Item[1];
                
                Range range1 = worksheet.Cells[5, 5];
                range1.Value = "거래처명";
                Range range2 = worksheet.Cells[5, 3];
                range2.Value = "등록번호";
                Range range3 = worksheet.Cells[6, 3];
                range3.Value = "주소";
                Range range4 = worksheet.Cells[7, 3];
                range4.Value = "전화번호";
                Range range5 = worksheet.Cells[6, 5];
                range5.Value = "업태";
                Range range6 = worksheet.Cells[7, 5];
                range6.Value = "이메일";
                worksheet.SaveAs(AppDomain.CurrentDomain.BaseDirectory+ ".\\거래명세서_다운.xls", Excel.XlFileFormat.xlWorkbookNormal);
                workbook.Close();
                application.Quit();
                MessageBox.Show("저장 성공");
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
            //이메일 보내기 버튼
        {
            try
            {
                string adminEmail = ConfigurationManager.AppSettings["adminEmail"].ToString();
                FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + ".\\거래명세서_다운.xls", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string tempStr = sr.ReadToEnd();

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true; //SSL을 사용한다.
                client.UseDefaultCredentials = false; //시스템에 설정된 인증정보를 사용하지 않는다.
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new System.Net.NetworkCredential("k48245568@gmail.com", "meiling0513");

                //보내는사람, 받는사람, 제목, 내용, (html 여부, 파일첨부)
                MailAddress from = new MailAddress(adminEmail, "관리자", Encoding.UTF8);
                MailAddress to = new MailAddress("k48245568@gmail.com", "거래처", Encoding.UTF8);
                MailMessage message = new MailMessage(from, to);
                message.Subject = "발주 거래명세서";
                // message.Body = tempStr;
                //// message.IsBodyHtml = true;
                // message.BodyEncoding = Encoding.UTF8;
                // message.SubjectEncoding = Encoding.UTF8;
                Attachment attachment = new Attachment("거래명세서_다운.xls");
                attachment.NameEncoding = Encoding.UTF8;
                message.Attachments.Add(attachment);
                client.Send(message);
                message.Dispose();
                MessageBox.Show("이메일 보내기 성공");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
