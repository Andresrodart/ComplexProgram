using N.Complejos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N.Complejos.Forms
{
    public partial class CalcC : Form
    {
        ComplexNum N;
        ComplexNum R;
        public CalcC()
        {
            InitializeComponent();
            NumR.Text = NumI.Text = "0";
        }
        
        private void Sen_Click(object sender, EventArgs e)
        {//Sin(Z) = (Sin(a) * ((eb + e-b) / 2) + Cos(a) * ((eb - e-b) / 2)i)            
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Sen();
            Res.Text = R.Printable();
        }

        private void Sen_MouseHover(object sender, EventArgs e)
        {
            Sen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void Sen_MouseLeave(object sender, EventArgs e)
        {
            Sen.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void Cos_Click(object sender, EventArgs e)
        {//Cos(Z) = (Cos(a) * ((eb + e-b) / 2) + -Sin(a) * ((eb - e-b) / 2)i
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Cos();
            Res.Text = R.Printable();
        }

        private void e_z_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.E_Z();
            Res.Text = R.Printable();
        }

        private void Ln_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Ln();
            Res.Text = R.Printable();
        }

        private void _Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Tan_Click(object sender, EventArgs e)
        { // T = S/c
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Tan(N.Sen(), N.Cos());
            Res.Text = R.Printable();
        }

        private void Csc_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Csc(N.Sen());
            Res.Text = R.Printable();
        }

        private void Sec_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Sec(N.Cos());
            Res.Text = R.Printable();
        }

        private void Cot_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Cot(N.Tan(N.Sen(), N.Cos()));
            Res.Text = R.Printable();
        }

        private void Senh_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Senh();
            Res.Text = R.Printable();
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Cosh();
            Res.Text = R.Printable();
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.Tanh();
            Res.Text = R.Printable();
        }

        private void arcS_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.ArcS();
            Res.Text = R.Printable();
        }

        private void arcC_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.ArcC();
            Res.Text = R.Printable();
        }

        private void arcT_Click(object sender, EventArgs e)
        {
            N = new ComplexNum(Convert.ToDouble(NumR.Text), Convert.ToDouble(NumI.Text));
            R = N.ArcT();
            Res.Text = R.Printable();
        }

        private void chart_Click(object sender, EventArgs e)
        {
            WChart frm = new WChart(N, R);
            frm.Show();
        }

        private void CalcC_Load(object sender, EventArgs e)
        {

        }
    }
}
