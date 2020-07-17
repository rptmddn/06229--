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
    public partial class BalzuIngForm : Form
    {
        public BalzuIngForm()
        {
            InitializeComponent();
        }

        private void BalzuIngForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TheNutsMainFrm main = (TheNutsMainFrm)this.MdiParent;
            main.OpenorCreateForm<BalzuForm.ExcelPopUpForm>();
        }
    }
}
