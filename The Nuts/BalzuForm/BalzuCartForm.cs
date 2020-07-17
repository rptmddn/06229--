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
    public partial class BalzuCartForm : Form
    {
        public BalzuCartForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TheNutsMainFrm main = (TheNutsMainFrm)this.MdiParent;
            main.OpenorCreateForm<BalzuForm.BalzuIngForm>();
        }
    }
}
