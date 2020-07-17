using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Nuts.JeanForm
{
    public partial class ProductCreate : Form
    {
        public ProductCreate()
        {
            InitializeComponent();
        }

        private void ProductCreate_Load(object sender, EventArgs e)
        {
            
            for(int i =0; i<6; i++)
            {
                flowLayoutPanel1.Controls.Add(UserControlAdd(i));
            }
        }

        private ProductControl UserControlAdd(int i)
        {
            ProductControl ctrl = new ProductControl();
            return ctrl;
            
        }
    }
}
