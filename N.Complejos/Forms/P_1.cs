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
    public partial class P_1 : Form
    {
        public P_1()
        {
            InitializeComponent();
        }

        private void NC__Click(object sender, EventArgs e)
        {
            NC frm = new NC();
            frm.Show();
            this.Hide();
        }

        private void NC__MouseHover(object sender, EventArgs e)
        {
            NC_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void NC__MouseLeave(object sender, EventArgs e)
        {
            NC_.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            Close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void CalcCom_Click(object sender, EventArgs e)
        {
            CalcC frm = new CalcC();
            frm.Show();
            this.Hide();
        }

        private void CalcCom_MouseHover(object sender, EventArgs e)
        {
            CalcCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void CalcCom_MouseLeave(object sender, EventArgs e)
        {
            CalcCom.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            mMenu.MainMenu.Show();
            this.Close();
        }
    }
}
