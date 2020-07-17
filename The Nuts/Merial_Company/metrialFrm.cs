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


namespace The_Nuts.Metrial_Company
{
    public partial class metrialFrm : Form
    {
        public metrialFrm()
        {
            InitializeComponent();
        }

        private void metrialFrm_Load(object sender, EventArgs e)
        {
            CommonService service = new CommonService();
            List<CommonVO> allList = service.GetCodeInfo();

            List<CommonVO> cList = (from item in allList
                                       where item.CodeType == "Metrial"
                                       select item).ToList();
            CommonUtil.ComboBinding(cboMetrialCategory, cList, "선택");
            

            CommonUtil.InitSettingGridView(dgvMetrial);
            CommonUtil.AddNewColumnToDataGridView(dgvMetrial, "유형", "Metrial_category", true);
            CommonUtil.AddNewColumnToDataGridView(dgvMetrial, "원재료명", "Metrial_name",true);
            CommonUtil.AddNewColumnToDataGridView(dgvMetrial, "원재료아이디", "Metrial_ID", false);
            CommonUtil.AddNewColumnToDataGridView(dgvMetrial, "단위", "Metrial_unit", true);
            CommonUtil.AddNewColumnToDataGridView(dgvMetrial, "이미지", "Metrial_Image", true);
            CommonUtil.AddNewColumnToDataGridView(dgvMetrial, "위험재고", "emergency_stock", true);
            CommonUtil.AddNewColumnToDataGridView(dgvMetrial, "안전재고", "safe_stock", true);

           MerialService metrialService = new MerialService();
             dgvMetrial.DataSource = metrialService.GetMetrialinfo();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

      
    }
}
