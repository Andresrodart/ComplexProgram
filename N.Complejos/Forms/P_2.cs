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
    public partial class P_2 : Form
    {
        private P_2()
        {
            InitializeComponent();
        }

        public static P_2 P_2T
        {
            get
            {
                if (_P_2T == null)
                {
                    _P_2T = new P_2();
                }
                return _P_2T;
            }
        }
        private static P_2 _P_2T;

        private void NC__Click(object sender, EventArgs e)
        {
            TICG frm = new TICG();
            frm.Show();
            this.Hide();
        }

        private void TR_B_Click(object sender, EventArgs e)
        {
            T_Residuo frm = new T_Residuo();
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

        private void Return_Click(object sender, EventArgs e)
        {
            mMenu.MainMenu.Show();
            this.Hide();
        }

        private void Return_MouseHover(object sender, EventArgs e)
        {
            Return.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void Return_MouseLeave(object sender, EventArgs e)
        {
            Return.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
