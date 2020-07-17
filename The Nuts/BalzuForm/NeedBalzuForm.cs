using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Nuts.BalzuForm
{
    public partial class NeedBalzuForm : Form
    {
        public NeedBalzuForm()
        {
            InitializeComponent();
        }

        private void NeedBalzuForm_Load(object sender, EventArgs e)
        {
            label1.Text = "※재고량의 전월 재고 소진량 대비 ()% 떨어지면 전월재고 소진량의 ()%까지 발주한다 ";
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           //TheNutsMain main = (TheNutsMain)this.MdiParent;
           // main.OpenorCreateForm<BalzuForm.BalzuCartForm>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TheNutsMainFrm main = (TheNutsMainFrm)this.MdiParent;
            main.OpenorCreateForm<BalzuForm.BalzuIngForm>();
        }
    }
}