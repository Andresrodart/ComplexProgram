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

namespace N.Complejos
{
    public partial class Roots : Form
    {
        List<ComplexNum> Roots_Num;
        ComplexNum _Po;

        public Roots(List<string> The_Roots, ComplexNum Num, List<ComplexNum> Roots_Num)
        {
            InitializeComponent();
            foreach (var item in The_Roots)
                RootsArea.Text += item + Environment.NewLine;

            RootsArea.Text += Environment.NewLine + "Pow: " + Num.Printable() ;
            this.Roots_Num = Roots_Num;
            _Po = Num;
        }

        private void _Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _Close_MouseHover(object sender, EventArgs e)
        {
            _Close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void _Close_MouseLeave(object sender, EventArgs e)
        {
            _Close.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void chart_MouseHover(object sender, EventArgs e)
        {
            chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void chart_MouseLeave(object sender, EventArgs e)
        {
            chart.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void chart_Click(object sender, EventArgs e)
        {
            WChart frm = new WChart(Roots_Num);
            frm.Show();
        }
    }
}
