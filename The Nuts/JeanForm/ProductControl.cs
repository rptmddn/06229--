using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Nuts
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }
        private string proname;

        public string ProName
        {
            get { return lblProName.Text; }
            set { lblProName.Text = value; }
        }
        private string proprice;

        public string ProPrice
        {
            get { return lblProPrice.Text; }
            set { lblProPrice.Text = value; }

        }
        private string madeday;

        public string Madeday
        {
            get { return lblMadeday.Text; }
            set { lblMadeday.Text = value; }
        }
      

      
    }
}
