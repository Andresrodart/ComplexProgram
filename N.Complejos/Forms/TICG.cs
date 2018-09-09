using N.Complejos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N.Complejos.Forms
{
    public partial class TICG : Form
    {
        ComplexNum Z_0;
        int n_, r_, fx_;
        String Res;

        public TICG()
        {
            InitializeComponent();
            exp_n.Text = "n";
            r.Text = "r";
            Z0.Text = "Z0";
        }

        private void Csc_Click(object sender, EventArgs e)
        {
            n_ = Convert.ToInt32(exp_n.Text);
            fx_ = fx.SelectedIndex;
            r_ = Convert.ToInt32(r.Text);

            if (n_ <= 0)
                MessageBox.Show("n no cumple la forma: C", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else if (fx_ == -1)
                MessageBox.Show("Función no selecionada", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else if (Z0.Text.Length < 1)
                MessageBox.Show("Z0 vacio", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
            {
                Z_0 = new ComplexNum(Z0.Text);

                if (Z_0.getr() > r_)
                    Res = "0";
                else if (Z_0.getr() == r_)
                    Res = "Indeterminado";
                else
                {
                    switch (fx_)
                    {
                        case 0:
                            Res = ZexpN();
                            break;
                        case 1:
                            Res = expZ();
                            break;
                        case 2:
                            Res = Sen_Z();
                            break;
                        case 3:
                            Res = Cosh_Z();
                            break;
                        case 4:
                            Res = Ln_Z();
                            break;
                        default:
                            Res = "Función no seleccionada";
                            break;
                    }
                }
            }
            ResultTB.Text = Res;
            Console.WriteLine(Z_0.getReal() + " -- " + Z_0.getUnreal());
            float wid = CirculePanel.Width, he = CirculePanel.Height;
            float zx = ((wid - 1) / 2 - 2.98F  ) + (((wid - 1) / 2) * (float) Z_0.getReal()   / r_)*1;
            float zy = ((he  - 1) / 2 - 2.8F) + (((he  - 1) / 2) * (float) Z_0.getUnreal() / r_)*-1;
            Pen p = new Pen(Color.DarkOrange);
            Pen pb = new Pen(Color.LightGray, 0.2F);

            // Create array of points that define lines to draw.
            PointF[] points =
                     {
                 new PointF((wid-1)/2, 0),
                 new PointF((wid-1)/2, he - 1),
                 new PointF(0,(he -1)/2),
                 new PointF(wid-1,(he -1)/2)
             };

            Graphics g = CirculePanel.CreateGraphics();
            g.Clear(Color.White);
            g.DrawEllipse(p, 0, 0, wid - 1, he - 1);
            g.DrawLine(pb, points[0], points[1]);
            g.DrawLine(pb, points[2], points[3]);

            // Create font and brush.
            Font drawFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.DarkRed);

            // Draw string to screen.
            g.DrawString(r_ + "i", drawFont, drawBrush, points[0]);
            g.DrawString(-r_ + "i", drawFont, drawBrush, new PointF((wid - 1) / 2, he - 10));
            g.DrawString(-r_ + "", drawFont, drawBrush, new PointF(0, (he - 1) / 2));
            g.DrawString(r_ + "", drawFont, drawBrush, new PointF(wid - 10, (he - 1) / 2));

            g.DrawRectangle(p, zx, zy, 5, 5);
            g.DrawString("Z₀(" + Z_0.getReal() + ", " + Z_0.getUnreal() + ")", drawFont, drawBrush, new PointF(zx + 5 , zy - 10));


        }

        private string Ln_Z()
        {
            switch (n_)
            {
                case 1:
                    return "\u222E ᶠ⁽ᶻ⁾/₍z₋z₀₎ⁿ dz = ( " + Z_0.Ln().Mul(0,2).Printable() + " )\u03C0";
                default:
                    return "\u222E ᶠ⁽ᶻ⁾/₍z₋z₀₎ⁿ dz = ("+ Z_0.Pow(1-n_).Mul(0,2).Div(n_-1,0).Mul(Math.Pow(-1,n_),0).Printable() + " )\u03C0";
            }
        }

        private string Cosh_Z()
        {
            if(n_ % 2 == 0)
                return "\u222E  ᶠ⁽ᶻ⁾/₍z₋z₀₎ⁿ dz = (" + Z_0.Senh().Mul(0,2).Div(Factorial(n_ - 1),0).Printable() + ")\u03C0";
            else
                return "\u222E  ᶠ⁽ᶻ⁾/₍z₋z₀₎ⁿ dz = (" + Z_0.Cosh().Mul(0, 2).Div(Factorial(n_ - 1), 0).Printable() + ")\u03C0";
        }

        private string Sen_Z()
        {
            return "\u222E  ᶠ⁽ᶻ⁾/₍z₋z₀₎ⁿ dz = (" + Z_0.Cos().Mul(Math.Sin(Math.PI * (n_-1)/ 2), 0).Mul(0, 2).Div(Factorial(n_ - 1), 0).Printable() + ")\u03C0";
        }

        private string expZ()
        {
            return "\u222E  ᶠ⁽ᶻ⁾/₍z₋z₀₎ⁿ dz = (" + Z_0.E_Z().Mul(0, 2).Div(Factorial(n_ - 1), 0).Printable() + ")\u03C0";
        }

        private string ZexpN()
        {
            return "\u222E = ᶠ⁽ᶻ⁾/₍z₋z₀₎ⁿ dz = ("+ Z_0.Mul(0, 2 * n_).Printable() + ")\u03C0";
        }

        /*private ComplexNum StringToComplex(String num)
        {
            /*string pattern = @"(\s*) (i)";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            num = rgx.Replace(num, replacement);

            num = new string((from c in num
                              where char.IsDigit(c) || (c == '+') || (c == '-')
                              select c
               ).ToArray());


            Console.WriteLine(num);
            num = (num.IndexOf('i') > 0) ? num.Substring(0, num.Length - 1) : num;
            int mid = (num.IndexOf('-', 1) == -1)? 
                            num.IndexOf("+", 1)
                        :
                            num.IndexOf('-', 1);

            if (mid == -1)
                return new ComplexNum(0, Convert.ToDouble(num.Substring(0, num.Length)));

            Double real = Convert.ToDouble(num.Substring(0, mid));
            Double unreal = Convert.ToDouble(num.Substring(mid));
            return new ComplexNum(real, unreal);
        }*/

        private void Return_Click(object sender, EventArgs e)
        {
            P_2.P_2T.Show();
            this.Close();
        }

        private void Return_MouseHover(object sender, EventArgs e)
        {
            Return.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void _Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void exp_n_Enter(object sender, EventArgs e)
        {
            exp_n.Text = "";
        }

        private void exp_n_Leave(object sender, EventArgs e)
        {
            if(exp_n.Text.Length == 0)
                exp_n.Text = "n";
        }

        private void Z0_Enter(object sender, EventArgs e)
        {
            Z0.Text = "";
        }

        private void Z0_Leave(object sender, EventArgs e)
        {
            if (Z0.Text.Length == 0)
                Z0.Text = "Z0";
        }

        private void r_Enter(object sender, EventArgs e)
        {
            r.Text = "";
        }

        private void r_Leave(object sender, EventArgs e)
        {
            if (r.Text.Length == 0)
                r.Text = "r";
        }

        private void Return_MouseLeave(object sender, EventArgs e)
        {
            Return.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }


        //HelpFunction

        public int Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return f * Factorial(f - 1);
        }
    }
}
