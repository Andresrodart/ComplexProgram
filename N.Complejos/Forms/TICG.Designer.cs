namespace N.Complejos.Forms
{
    partial class TICG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TICG));
            this.fx = new System.Windows.Forms.ComboBox();
            this.exp_n = new System.Windows.Forms.TextBox();
            this.Z0 = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.TextBox();
            this.Csc = new System.Windows.Forms.PictureBox();
            this.Return = new System.Windows.Forms.PictureBox();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this._Close = new System.Windows.Forms.PictureBox();
            this.CirculePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Csc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Close)).BeginInit();
            this.SuspendLayout();
            // 
            // fx
            // 
            this.fx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fx.FormattingEnabled = true;
            this.fx.Items.AddRange(new object[] {
            "Z^n",
            "e^z",
            "sen(z)",
            "cosh(z)",
            "Ln(z)"});
            this.fx.Location = new System.Drawing.Point(308, 97);
            this.fx.Name = "fx";
            this.fx.Size = new System.Drawing.Size(121, 21);
            this.fx.TabIndex = 0;
            // 
            // exp_n
            // 
            this.exp_n.Location = new System.Drawing.Point(52, 98);
            this.exp_n.Name = "exp_n";
            this.exp_n.Size = new System.Drawing.Size(100, 20);
            this.exp_n.TabIndex = 1;
            this.exp_n.Enter += new System.EventHandler(this.exp_n_Enter);
            this.exp_n.Leave += new System.EventHandler(this.exp_n_Leave);
            // 
            // Z0
            // 
            this.Z0.Location = new System.Drawing.Point(183, 98);
            this.Z0.Name = "Z0";
            this.Z0.Size = new System.Drawing.Size(100, 20);
            this.Z0.TabIndex = 2;
            this.Z0.Enter += new System.EventHandler(this.Z0_Enter);
            this.Z0.Leave += new System.EventHandler(this.Z0_Leave);
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(447, 99);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(100, 20);
            this.r.TabIndex = 3;
            this.r.Enter += new System.EventHandler(this.r_Enter);
            this.r.Leave += new System.EventHandler(this.r_Leave);
            // 
            // Csc
            // 
            this.Csc.BackColor = System.Drawing.Color.Transparent;
            this.Csc.Location = new System.Drawing.Point(468, 358);
            this.Csc.Name = "Csc";
            this.Csc.Size = new System.Drawing.Size(117, 30);
            this.Csc.TabIndex = 14;
            this.Csc.TabStop = false;
            this.Csc.Click += new System.EventHandler(this.Csc_Click);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.Location = new System.Drawing.Point(16, 363);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(112, 25);
            this.Return.TabIndex = 15;
            this.Return.TabStop = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            this.Return.MouseLeave += new System.EventHandler(this.Return_MouseLeave);
            this.Return.MouseHover += new System.EventHandler(this.Return_MouseHover);
            // 
            // ResultTB
            // 
            this.ResultTB.Location = new System.Drawing.Point(166, 362);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.ReadOnly = true;
            this.ResultTB.Size = new System.Drawing.Size(263, 20);
            this.ResultTB.TabIndex = 16;
            // 
            // _Close
            // 
            this._Close.BackColor = System.Drawing.Color.Transparent;
            this._Close.Location = new System.Drawing.Point(578, 2);
            this._Close.Name = "_Close";
            this._Close.Size = new System.Drawing.Size(21, 22);
            this._Close.TabIndex = 17;
            this._Close.TabStop = false;
            this._Close.Click += new System.EventHandler(this._Close_Click);
            // 
            // CirculePanel
            // 
            this.CirculePanel.Location = new System.Drawing.Point(212, 154);
            this.CirculePanel.Name = "CirculePanel";
            this.CirculePanel.Size = new System.Drawing.Size(180, 180);
            this.CirculePanel.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Exponente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Número Complejo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Función";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Radio";
            // 
            // TICG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CirculePanel);
            this.Controls.Add(this._Close);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Csc);
            this.Controls.Add(this.r);
            this.Controls.Add(this.Z0);
            this.Controls.Add(this.exp_n);
            this.Controls.Add(this.fx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TICG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TICG";
            ((System.ComponentModel.ISupportInitialize)(this.Csc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fx;
        private System.Windows.Forms.TextBox exp_n;
        private System.Windows.Forms.TextBox Z0;
        private System.Windows.Forms.TextBox r;
        private System.Windows.Forms.PictureBox Csc;
        private System.Windows.Forms.PictureBox Return;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.PictureBox _Close;
        private System.Windows.Forms.Panel CirculePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}