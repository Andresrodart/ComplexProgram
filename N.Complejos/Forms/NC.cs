using MathNet.Numerics;
using N.Complejos.Clases;
using System;
using System.Globalization;
using System.Windows.Forms;


namespace N.Complejos
{
    public partial class NC : Form
    {
        ComplexNum N1, N2, _Sum, _Mul, _Div, _Res, _Pow;

        public NC()
        {
            InitializeComponent();
            NumU2.Text = NumU1.Text = NumR2.Text = NumR1.Text = "0";
        }

        private void But_Click(object sender, EventArgs e)
        {
            if (nNatural.Text.Length == 0 )
                MessageBox.Show("Campo n vacio", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
            {
                try
                {
                    N1 = new ComplexNum(Convert.ToDouble(NumR1.Text), Convert.ToDouble(NumU1.Text));
                    N2 = new ComplexNum(Convert.ToDouble(NumR2.Text), Convert.ToDouble(NumU2.Text));
                    _Sum = N1.Sum(N2.getReal(), N2.getUnreal());
                    _Res = N1.Res(N2.getReal(), N2.getUnreal());
                    _Mul = N1.Mul(N2.getReal(), N2.getUnreal());
                    _Div = N1.Div(N2.getReal(), N2.getUnreal());
                    _Pow = N2.Pow(Convert.ToInt32(nPow.Text));
                    //Console.WriteLine("--------------");
                    //Console.WriteLine("r: " + _Pow.getr() + "  teta:" + _Pow.getTeta() * 180 / Math.PI);
                    //Console.WriteLine("--------------");

                    Sum.Text = _Sum.getReal() + ((_Sum.getUnreal() > 0) ? " + " : " - ") + Math.Abs(_Sum.getUnreal()) + " i";
                    Div.Text = (_Div == null) ? "Math Error" : _Div.getReal() + ((_Div.getUnreal() > 0) ? " + " : " - ") + Math.Abs(_Div.getUnreal()) + " i";
                    Res.Text = _Res.getReal() + ((_Res.getUnreal() > 0) ? " + " : " - ") + Math.Abs(_Res.getUnreal()) + " i";
                    Mul.Text = _Mul.getReal() + ((_Mul.getUnreal() > 0) ? " + " : " - ") + Math.Abs(_Mul.getUnreal()) + " i";
                    Pow.Text = _Pow.Printable();
                    Console.WriteLine(_Pow.getReal() + "====" + _Pow.getUnreal());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
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
            WChart frm = new WChart(_Sum, _Mul, _Div, _Res, _Pow);
            frm.Show();
        }

        private void Roots_Click(object sender, EventArgs e)
        {
            if (nNatural.Text.Length == 0 || nPow.Text.Length == 0)
                MessageBox.Show("Campo n vacio", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
            {
                Roots frm = new Roots(N1.Roots(Convert.ToInt32(nNatural.Text)), _Pow, N1.Roots_Num(Convert.ToInt32(nNatural.Text)));
                frm.Show();
            }
            
        }

        private void Roots_MouseHover(object sender, EventArgs e)
        {
            Roots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void Roots_MouseLeave(object sender, EventArgs e)
        {
            Roots.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void But_MouseHover(object sender, EventArgs e)
        {
            But.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void But_MouseLeave(object sender, EventArgs e)
        {
            But.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            _Close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            _Close.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
