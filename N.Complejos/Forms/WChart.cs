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
    public partial class WChart : Form
    {
        ComplexNum _Sum, _Mul, _Div, _Res;

        public WChart(ComplexNum _Sum, ComplexNum _Mul, ComplexNum _Div, ComplexNum _Res, ComplexNum _Po)
        {
            InitializeComponent();
            this._Sum = _Sum;
            this._Res = _Res;
            this._Mul = _Mul;
            this._Div = _Div;

            chart.Series["Sum"].Points.AddXY(_Sum.getReal(), _Sum.getUnreal());
            chart.Series["Res"].Points.AddXY(_Res.getReal(), _Res.getUnreal());
            chart.Series["Mul"].Points.AddXY(_Mul.getReal(), _Mul.getUnreal());
            if (_Div != null) chart.Series["Div"].Points.AddXY(_Div.getReal(), _Div.getUnreal());
            chart.Series["Pow"].Points.AddXY(_Po.getReal(), _Po.getUnreal());

        }

        public WChart(List<ComplexNum> _Roots)
        {
            InitializeComponent();
            foreach (var item in _Roots)
                chart.Series["Roots"].Points.AddXY(item.getReal(), item.getUnreal());
        }

        public WChart(ComplexNum a, ComplexNum b )
        {
            InitializeComponent();
            chart.Series["Sum"].Points.AddXY(a.getReal(), a.getUnreal());
            chart.Series["Trigo"].Points.AddXY(b.getReal(), b.getUnreal());
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
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
