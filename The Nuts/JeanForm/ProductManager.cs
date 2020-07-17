using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Nuts.Service;
using TheNutsVO;

namespace The_Nuts.JeanForm
{
    public partial class ProductManager : Form
    {
        string errorMessage;
        List<ProductInfoVO> allList;
        public ProductManager()
        {
            InitializeComponent();
        }
        private void InitControl()
        {
            pbxImage.ImageLocation = "image/검은콩.jpg";//절대경로    >> 상대경로는 : "../images/noimage.png"
            //txtDate.Text = DateTime.Now.ToShortDateString();
            //txtEndDate.Text = DateTime.Now.ToShortDateString();
            cboQuantity.SelectedIndex = 0;
            //txtDate.ReadOnly = true;
        }

        private void btnProInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRegistration())
                {
                    ProductInfoVO pro = new ProductInfoVO();
                    pro.Pro_Name = txtProName.Text.Trim();
                    pro.Pro_Price = txtProPrice.Text.Trim();
                    pro.Pro_Code = txtProCode.Text.Trim();
                    //pro.ProductDate = txtDate.Text; 
                    //pro.ProductDateEnd = txtEndDate.Text;//유통기한 조정필요
                    pro.Pro_Count = Convert.ToInt32(cboQuantity.Text);
                    pro.Pro_Note = txtNotes.Text.Trim();
                    //이미지 => byte[] 변환 VO 속성에 저장
                    FileStream fs = new FileStream(pbxImage.ImageLocation, FileMode.Open, FileAccess.Read);
                    byte[] bImage = new byte[fs.Length];
                    fs.Read(bImage, 0, (int)fs.Length);
                    pro.Pro_Image = bImage;



                    Service.ProductService ser = new Service.ProductService();
                    bool bResult = ser.RegisterProduct(pro);
                    if (bResult)
                    {
                        MessageBox.Show("성공적으로 등록 되었습니다!.");
                    }
                    else
                    {
                        MessageBox.Show("신규 등록 중 오류가 발생했습니다. 다시시도하여 주십시오.");
                    }
                }
                else
                {
                    this.ShowErrorMessage(this.errorMessage, "신규 등록 에러");
                }
            }
            catch (Exception err)
            {
                this.ShowErrorMessage(err);
            }
        }
        private bool ValidateRegistration()
        {
            this.errorMessage = string.Empty;

            if (txtProName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("제품 이름을 입력해주세요.");
            }

            if (cboQuantity.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("수량을 선택해 주세요.");
            }

            if (txtProPrice.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("가격을 입력해 주세요.");
            }
            if (txtProCode.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage("제품코드를 입력해 주세요.");
            }



            return this.errorMessage != string.Empty ? false : true;
        }
        private void AddErrorMessage(string error)
        {
            if (this.errorMessage == string.Empty)
            {
                this.errorMessage = "등록 실패" + "\n\n";
            }

            this.errorMessage += error + "\n";
        }

        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "에러 메세지",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        private void ShowErrorMessage(string errorMsg, string title)
        {
            MessageBox.Show(
                errorMsg,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxImage.ImageLocation = openFileDialog1.FileName;
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            InitControl();
            CommonUtil.InitSettingGridView(dgvProduct);
            CommonUtil.AddNewColumnToDataGridView(dgvProduct, "제품 이름", "Pro_Name", true, 60);
            CommonUtil.AddNewColumnToDataGridView(dgvProduct, "제품 코드", "Pro_Code", true, 80);
            CommonUtil.AddNewColumnToDataGridView(dgvProduct, "제품 가격", "Pro_Price", true, 80);           
            CommonUtil.AddNewColumnToDataGridView(dgvProduct, "제품 수량", "Pro_Count", true, 80);
            CommonUtil.AddNewColumnToDataGridView(dgvProduct, "제품 설명", "Pro_Note", true, 100);

            LoadData();
        }

        private void LoadData()
        {
            ProductService service = new ProductService();
            allList = service.GetAllProData();

            dgvProduct.DataSource = allList;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblProCode.Text.Length < 1)
                return;

            try
            {
                ProductInfoVO pro = new ProductInfoVO();
                pro.Pro_Name = txtName.Text.Trim();
                pro.Pro_Count = Convert.ToInt32(cboEA.SelectedValue);
                pro.Pro_Price = txtPrice.Text.Trim();
                //pro.ProductDate = dtpDate.Value.ToShortDateString();
                //pro.ProductDateEnd = dtpEndDate.Value.ToShortDateString();
                pro.Pro_Note = txtNote.Text.Trim();
                pro.Pro_Image = ImageToByte(pbxImagechange.Image);

                ProductService service = new ProductService();
                bool bResult = service.UpdateProduct(pro);
                if (bResult)
                {
                    //LoadData();
                    //ClearControls();
                    MessageBox.Show("성공적으로 수정되었습니다");
                }
                else
                {
                    MessageBox.Show("수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
