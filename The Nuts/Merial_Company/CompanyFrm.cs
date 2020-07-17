using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Nuts.Metrial_Company
{
    public partial class CompanyFrm : Form
    {
        public CompanyFrm()
        {
            InitializeComponent();
        }

        private void CompanyFrm_Load(object sender, EventArgs e)
        {
            CommonUtil.InitSettingGridView(dataGridView1);
        }
    }
}
