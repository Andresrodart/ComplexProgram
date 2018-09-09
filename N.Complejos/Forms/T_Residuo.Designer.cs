namespace N.Complejos.Forms
{
    partial class T_Residuo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_Residuo));
            this._Close = new System.Windows.Forms.PictureBox();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.PictureBox();
            this.a1_tb = new System.Windows.Forms.TextBox();
            this.exp_m = new System.Windows.Forms.TextBox();
            this.exp_n = new System.Windows.Forms.TextBox();
            this.fx = new System.Windows.Forms.ComboBox();
            this.bi_tb = new System.Windows.Forms.TextBox();
            this.Res_TB_b = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go)).BeginInit();
            this.SuspendLayout();
            // 
            // _Close
            // 
            this._Close.BackColor = System.Drawing.Color.Transparent;
            this._Close.Location = new System.Drawing.Point(578, 1);
            this._Close.Name = "_Close";
            this._Close.Size = new System.Drawing.Size(21, 22);
            this._Close.TabIndex = 31;
            this._Close.TabStop = false;
            this._Close.Click += new System.EventHandler(this._Close_Click);
            // 
            // ResultTB
            // 
            this.ResultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTB.Location = new System.Drawing.Point(58, 185);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.ReadOnly = true;
            this.ResultTB.Size = new System.Drawing.Size(491, 35);
            this.ResultTB.TabIndex = 30;
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.Location = new System.Drawing.Point(18, 358);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(104, 26);
            this.Return.TabIndex = 29;
            this.Return.TabStop = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // a1_tb
            // 
            this.a1_tb.Location = new System.Drawing.Point(371, 104);
            this.a1_tb.Name = "a1_tb";
            this.a1_tb.Size = new System.Drawing.Size(83, 20);
            this.a1_tb.TabIndex = 27;
            this.a1_tb.Enter += new System.EventHandler(this.a1_tb_Enter);
            this.a1_tb.Leave += new System.EventHandler(this.a1_tb_Leave);
            // 
            // exp_m
            // 
            this.exp_m.Location = new System.Drawing.Point(136, 104);
            this.exp_m.Name = "exp_m";
            this.exp_m.Size = new System.Drawing.Size(86, 20);
            this.exp_m.TabIndex = 26;
            this.exp_m.Enter += new System.EventHandler(this.exp_m_Enter);
            this.exp_m.Leave += new System.EventHandler(this.exp_m_Leave);
            // 
            // exp_n
            // 
            this.exp_n.Location = new System.Drawing.Point(22, 104);
            this.exp_n.Name = "exp_n";
            this.exp_n.Size = new System.Drawing.Size(81, 20);
            this.exp_n.TabIndex = 25;
            this.exp_n.Enter += new System.EventHandler(this.exp_n_Enter);
            this.exp_n.Leave += new System.EventHandler(this.exp_n_Leave);
            // 
            // fx
            // 
            this.fx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fx.FormattingEnabled = true;
            this.fx.Items.AddRange(new object[] {
            "Z^2",
            "e^z",
            "sen(z)",
            "cosh(z)"});
            this.fx.Location = new System.Drawing.Point(255, 103);
            this.fx.Name = "fx";
            this.fx.Size = new System.Drawing.Size(82, 21);
            this.fx.TabIndex = 24;
            // 
            // bi_tb
            // 
            this.bi_tb.Location = new System.Drawing.Point(487, 104);
            this.bi_tb.Name = "bi_tb";
            this.bi_tb.Size = new System.Drawing.Size(83, 20);
            this.bi_tb.TabIndex = 32;
            this.bi_tb.Enter += new System.EventHandler(this.bi_tb_Enter);
            this.bi_tb.Leave += new System.EventHandler(this.bi_tb_Leave);
            // 
            // Res_TB_b
            // 
            this.Res_TB_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res_TB_b.Location = new System.Drawing.Point(58, 266);
            this.Res_TB_b.Name = "Res_TB_b";
            this.Res_TB_b.ReadOnly = true;
            this.Res_TB_b.Size = new System.Drawing.Size(491, 35);
            this.Res_TB_b.TabIndex = 33;
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.Transparent;
            this.Go.Location = new System.Drawing.Point(477, 358);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(104, 26);
            this.Go.TabIndex = 34;
            this.Go.TabStop = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // T_Residuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::N.Complejos.Properties.Resources.ResiduosTemplate;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Res_TB_b);
            this.Controls.Add(this.bi_tb);
            this.Controls.Add(this._Close);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.a1_tb);
            this.Controls.Add(this.exp_m);
            this.Controls.Add(this.exp_n);
            this.Controls.Add(this.fx);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "T_Residuo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T_Residuo";
            ((System.ComponentModel.ISupportInitialize)(this._Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _Close;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.PictureBox Return;
        private System.Windows.Forms.TextBox a1_tb;
        private System.Windows.Forms.TextBox exp_m;
        private System.Windows.Forms.TextBox exp_n;
        private System.Windows.Forms.ComboBox fx;
        private System.Windows.Forms.TextBox bi_tb;
        private System.Windows.Forms.TextBox Res_TB_b;
        private System.Windows.Forms.PictureBox Go;
    }
}