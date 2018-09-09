namespace N.Complejos
{
    partial class NC
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NC));
            this.Sum = new System.Windows.Forms.Label();
            this.Res = new System.Windows.Forms.Label();
            this.Mul = new System.Windows.Forms.Label();
            this.Div = new System.Windows.Forms.Label();
            this.But = new System.Windows.Forms.PictureBox();
            this.NumR1 = new System.Windows.Forms.TextBox();
            this.NumR2 = new System.Windows.Forms.TextBox();
            this._Close = new System.Windows.Forms.PictureBox();
            this.NumU1 = new System.Windows.Forms.TextBox();
            this.NumU2 = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.PictureBox();
            this.nNatural = new System.Windows.Forms.TextBox();
            this.Pow = new System.Windows.Forms.Label();
            this.Roots = new System.Windows.Forms.PictureBox();
            this.nPow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.But)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roots)).BeginInit();
            this.SuspendLayout();
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.BackColor = System.Drawing.Color.Transparent;
            this.Sum.Location = new System.Drawing.Point(161, 210);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(0, 13);
            this.Sum.TabIndex = 0;
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.BackColor = System.Drawing.Color.Transparent;
            this.Res.Location = new System.Drawing.Point(161, 252);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(0, 13);
            this.Res.TabIndex = 1;
            // 
            // Mul
            // 
            this.Mul.AutoSize = true;
            this.Mul.BackColor = System.Drawing.Color.Transparent;
            this.Mul.Location = new System.Drawing.Point(161, 289);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(0, 13);
            this.Mul.TabIndex = 2;
            // 
            // Div
            // 
            this.Div.AutoSize = true;
            this.Div.BackColor = System.Drawing.Color.Transparent;
            this.Div.Location = new System.Drawing.Point(161, 329);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(0, 13);
            this.Div.TabIndex = 3;
            // 
            // But
            // 
            this.But.BackColor = System.Drawing.Color.Transparent;
            this.But.Location = new System.Drawing.Point(406, 349);
            this.But.Name = "But";
            this.But.Size = new System.Drawing.Size(126, 24);
            this.But.TabIndex = 4;
            this.But.TabStop = false;
            this.But.Click += new System.EventHandler(this.But_Click);
            this.But.MouseLeave += new System.EventHandler(this.But_MouseLeave);
            this.But.MouseHover += new System.EventHandler(this.But_MouseHover);
            // 
            // NumR1
            // 
            this.NumR1.BackColor = System.Drawing.SystemColors.Menu;
            this.NumR1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumR1.Location = new System.Drawing.Point(96, 123);
            this.NumR1.Name = "NumR1";
            this.NumR1.Size = new System.Drawing.Size(50, 13);
            this.NumR1.TabIndex = 5;
            this.NumR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumR2
            // 
            this.NumR2.BackColor = System.Drawing.SystemColors.Menu;
            this.NumR2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumR2.Location = new System.Drawing.Point(95, 168);
            this.NumR2.Name = "NumR2";
            this.NumR2.Size = new System.Drawing.Size(50, 13);
            this.NumR2.TabIndex = 6;
            this.NumR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _Close
            // 
            this._Close.BackColor = System.Drawing.Color.Transparent;
            this._Close.Location = new System.Drawing.Point(579, 0);
            this._Close.Name = "_Close";
            this._Close.Size = new System.Drawing.Size(21, 22);
            this._Close.TabIndex = 7;
            this._Close.TabStop = false;
            this._Close.Click += new System.EventHandler(this.Close_Click);
            this._Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this._Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // NumU1
            // 
            this.NumU1.BackColor = System.Drawing.SystemColors.Menu;
            this.NumU1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumU1.Location = new System.Drawing.Point(160, 123);
            this.NumU1.Name = "NumU1";
            this.NumU1.Size = new System.Drawing.Size(40, 13);
            this.NumU1.TabIndex = 8;
            this.NumU1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumU2
            // 
            this.NumU2.BackColor = System.Drawing.SystemColors.Menu;
            this.NumU2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumU2.Location = new System.Drawing.Point(162, 168);
            this.NumU2.Name = "NumU2";
            this.NumU2.Size = new System.Drawing.Size(40, 13);
            this.NumU2.TabIndex = 9;
            this.NumU2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.Location = new System.Drawing.Point(547, 345);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(34, 31);
            this.chart.TabIndex = 10;
            this.chart.TabStop = false;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            this.chart.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chart.MouseHover += new System.EventHandler(this.chart_MouseHover);
            // 
            // nNatural
            // 
            this.nNatural.BackColor = System.Drawing.SystemColors.Menu;
            this.nNatural.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nNatural.Location = new System.Drawing.Point(346, 123);
            this.nNatural.Name = "nNatural";
            this.nNatural.Size = new System.Drawing.Size(50, 13);
            this.nNatural.TabIndex = 11;
            this.nNatural.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pow
            // 
            this.Pow.AutoSize = true;
            this.Pow.BackColor = System.Drawing.Color.Transparent;
            this.Pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pow.Location = new System.Drawing.Point(431, 249);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(0, 13);
            this.Pow.TabIndex = 13;
            // 
            // Roots
            // 
            this.Roots.BackColor = System.Drawing.Color.Transparent;
            this.Roots.Location = new System.Drawing.Point(426, 206);
            this.Roots.Name = "Roots";
            this.Roots.Size = new System.Drawing.Size(126, 24);
            this.Roots.TabIndex = 14;
            this.Roots.TabStop = false;
            this.Roots.Click += new System.EventHandler(this.Roots_Click);
            this.Roots.MouseLeave += new System.EventHandler(this.Roots_MouseLeave);
            this.Roots.MouseHover += new System.EventHandler(this.Roots_MouseHover);
            // 
            // nPow
            // 
            this.nPow.BackColor = System.Drawing.SystemColors.Menu;
            this.nPow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nPow.Location = new System.Drawing.Point(346, 161);
            this.nPow.Name = "nPow";
            this.nPow.Size = new System.Drawing.Size(50, 13);
            this.nPow.TabIndex = 15;
            this.nPow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::N.Complejos.Properties.Resources.ComplexTemplate6;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.nPow);
            this.Controls.Add(this.Roots);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.nNatural);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.NumU2);
            this.Controls.Add(this.NumU1);
            this.Controls.Add(this._Close);
            this.Controls.Add(this.NumR2);
            this.Controls.Add(this.NumR1);
            this.Controls.Add(this.But);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Sum);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NC";
            ((System.ComponentModel.ISupportInitialize)(this.But)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.Label Mul;
        private System.Windows.Forms.Label Div;
        private System.Windows.Forms.PictureBox But;
        private System.Windows.Forms.TextBox NumR1;
        private System.Windows.Forms.TextBox NumR2;
        private System.Windows.Forms.PictureBox _Close;
        private System.Windows.Forms.TextBox NumU1;
        private System.Windows.Forms.TextBox NumU2;
        private System.Windows.Forms.PictureBox chart;
        private System.Windows.Forms.TextBox nNatural;
        private System.Windows.Forms.Label Pow;
        private System.Windows.Forms.PictureBox Roots;
        private System.Windows.Forms.TextBox nPow;
    }
}

