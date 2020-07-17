using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using The_Nuts.JeanForm;
using The_Nuts.Metrial_Company;

namespace The_Nuts
{
    public partial class TheNutsMainFrm : Form
    {
        bool pflag1=true;
        int inteval1 = 90;
        bool pflag2 = true;
        int inteval2 = 60;
       
        public TheNutsMainFrm()
        {
            InitializeComponent();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            s.Tag = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            s.Parent.Left = this.Left + (e.X - ((Point)s.Tag).X);
            s.Parent.Top = this.Top + (e.Y - ((Point)s.Tag).Y);
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            BOMMainFrm frm = new BOMMainFrm();

            frm.MdiParent = this;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnProductCr_Click(object sender, EventArgs e)
        {
            OpenorCreateForm<ProductCreate>(); 
        }
        private void ProductMG_Click(object sender, EventArgs e)
        {
            OpenorCreateForm<ProductManager>();
        }
        private void BalzuManager_Click(object sender, EventArgs e)
        {
            OpenorCreateForm<BalzuForm.NeedBalzuForm>();
        }
        private void lblBOM_Click(object sender, EventArgs e)
        {
            OpenorCreateForm<BOMMainFrm>();
        }
        private void btnMetrial_Click(object sender, EventArgs e)
        {
            OpenorCreateForm<metrialFrm>();
        }
        private void btnCompany_Click(object sender, EventArgs e)
        {
            OpenorCreateForm<CompanyMEnagementFrm>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Slidingmenu(slide1, timer1, ref inteval1, ref pflag1, 90,3);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Slidingmenu(slide2,timer2,ref inteval2,ref pflag2,60);
        }
        private void Slidingmenu(Panel slide, Timer timer, ref int inteval, ref bool pflag, int intevalMax, int num =2)
        {
            if (pflag)
            {
                if (inteval > 0)
                {
                    slide.Location = new Point(slide.Location.X, slide.Location.Y + num);
                    inteval = inteval - num;
                }
                else
                {
                    pflag = false;
                    timer.Stop();
                }
            }
            else
            {
                if (inteval <= intevalMax)
                {
                    slide.Location = new Point(slide2.Location.X, slide.Location.Y - num);
                    inteval = inteval + num;
                }
                else
                {
                    pflag = true;
                    timer.Stop();
                }
            }
        }
       
        public void OpenorCreateForm<T>() where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            T frm = new T();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }
    }
}
