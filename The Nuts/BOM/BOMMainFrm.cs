using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Nuts.Service;
using TheNutsVO;

namespace The_Nuts
{
    public partial class BOMMainFrm : Form
    {
        List<ComboItemVO> codeList;
        public BOMMainFrm()
        {
            InitializeComponent();

        }

        private void BOMMainFrm_Load(object sender, EventArgs e)
        {
            CommonUtil.InitSettingGridView(dgvProduct);
            CommonUtil.AddNewColumnToDataGridView(dgvProduct, "품목코드", "Code", true, 150);
            CommonUtil.AddNewColumnToDataGridView(dgvProduct, "품목명", "CodeNm", true, 360);
            CommonUtil.AddNewColumnToDataGridView(dgvProduct, "유형", "CodeType", true, 100);

            DataGridViewButtonColumn btnBOM = new DataGridViewButtonColumn();
            btnBOM.HeaderText = "BOM등록";
            btnBOM.Text = "BOM";
            btnBOM.Width = 125;
            btnBOM.DefaultCellStyle.Padding = new Padding(1, 1, 1, 1);
            btnBOM.UseColumnTextForButtonValue = true;
            dgvProduct.Columns.Add(btnBOM); //3

            DataGridViewButtonColumn btnFR = new DataGridViewButtonColumn();
            btnFR.HeaderText = "조회";
            btnFR.Text = "조회";
            btnFR.Width = 125;
            btnFR.DefaultCellStyle.Padding = new Padding(1, 1, 1, 1);
            btnFR.UseColumnTextForButtonValue = true;
            dgvProduct.Columns.Add(btnFR); //4

            ProductLoad();
        }

        private void ProductLoad()
        {
            rdoAll.Checked = true;
            BOMService service = new BOMService();
            //codeList = service.GetAllProduct();

            dgvProduct.DataSource = codeList;
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            List<ComboItemVO> typeList = null;
            if (rdoAll.Checked)
            {
                typeList = (from type in codeList

                            select type).ToList();
            }
            else if (rdoProduct.Checked)
            {
                typeList = (from type in codeList
                            where type.CodeType == "제품"
                            select type).ToList();
            }
            else if (rdoMaterial.Checked)
            {
                typeList = (from type in codeList
                            where type.CodeType == "원재료"
                            select type).ToList();
            }
            dgvProduct.DataSource = typeList;
        }
    }
}
