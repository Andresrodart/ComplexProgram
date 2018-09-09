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
    public partial class T_Residuo : Form
    {
        public T_Residuo()
        {
            InitializeComponent();
            fx.SelectedIndex = 0;
            exp_n.Text = "Exponente n";
            exp_m.Text = "Exponente m";
            a1_tb.Text = "Pto a1";
            bi_tb.Text = "Pto b1";
        }

        private void _Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            P_2.P_2T.Show();
            this.Close();
        }

        private void exp_n_Enter(object sender, EventArgs e)
        {
            if (exp_n.Text.Equals("Exponente n")) exp_n.Text = "";
        }

        private void exp_n_Leave(object sender, EventArgs e)
        {
            if (exp_n.Text.Equals("")) exp_n.Text = "Exponente n";
        }

        private void exp_m_Enter(object sender, EventArgs e)
        {
            if (exp_m.Text.Equals("Exponente m")) exp_m.Text = "";
        }

        private void exp_m_Leave(object sender, EventArgs e)
        {
            if (exp_m.TextLength == 0) exp_m.Text = "Exponente m";
        }

        private void a1_tb_Enter(object sender, EventArgs e)
        {
            if (a1_tb.Text.Equals("Pto a1")) a1_tb.Text = "";
        }

        private void a1_tb_Leave(object sender, EventArgs e)
        {
            if (a1_tb.TextLength == 0) a1_tb.Text = "Pto a1";
        }

        private void bi_tb_Enter(object sender, EventArgs e)
        {
            if (bi_tb.Text.Equals("Pto b1")) bi_tb.Text = "";
        }

        private void bi_tb_Leave(object sender, EventArgs e)
        {
            if (bi_tb.TextLength == 0) bi_tb.Text = "Pto b1";
        }

        private void Go_Click(object sender, EventArgs e)
        {
            switch (fx.SelectedIndex)
            {
                case (0):
                    Res_Z2();
                    break;
                default:
                    break;
            }
        }

        private string Res_Z2()
        {
            return "";
            throw new NotImplementedException();
        }
    }
}
