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
    public partial class mMenu : Form
    {
        private mMenu()
        {
            InitializeComponent();
        }

        public static mMenu MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new mMenu();
                }
                return _mainMenu;
            }
        }
        private static mMenu _mainMenu;

        private void PrimerParcial_Click(object sender, EventArgs e)
        {
            P_1 frm = new P_1();
            frm.Show();
            this.Hide();
        }

        private void SegundoParcial_Click(object sender, EventArgs e)
        {
            P_2 frm = P_2.P_2T;
            frm.Show();
            this.Hide();
        }

        private void PrimerParcial_MouseHover(object sender, EventArgs e)
        {
            PrimerParcial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void PrimerParcial_MouseLeave(object sender, EventArgs e)
        {
            PrimerParcial.BorderStyle = System.Windows.Forms.BorderStyle.None;
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

        
    }
}
