﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Nuts
{
    public partial class BOMCUDFrm : Form
    {
        public BOMCUDFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MaterialDetailFrm frm = new MaterialDetailFrm();
            frm.ShowDialog();
        }
    }
}
