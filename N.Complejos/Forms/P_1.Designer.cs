namespace N.Complejos.Forms
{
    partial class P_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_1));
            this.Close = new System.Windows.Forms.PictureBox();
            this.Return = new System.Windows.Forms.PictureBox();
            this.NC_ = new System.Windows.Forms.PictureBox();
            this.CalcCom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NC_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcCom)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Location = new System.Drawing.Point(293, 467);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 25);
            this.Close.TabIndex = 2;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.Location = new System.Drawing.Point(11, 467);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(100, 25);
            this.Return.TabIndex = 3;
            this.Return.TabStop = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // NC_
            // 
            this.NC_.BackColor = System.Drawing.Color.Transparent;
            this.NC_.Location = new System.Drawing.Point(69, 133);
            this.NC_.Name = "NC_";
            this.NC_.Size = new System.Drawing.Size(253, 40);
            this.NC_.TabIndex = 4;
            this.NC_.TabStop = false;
            this.NC_.Click += new System.EventHandler(this.NC__Click);
            this.NC_.MouseLeave += new System.EventHandler(this.NC__MouseLeave);
            this.NC_.MouseHover += new System.EventHandler(this.NC__MouseHover);
            // 
            // CalcCom
            // 
            this.CalcCom.BackColor = System.Drawing.Color.Transparent;
            this.CalcCom.Location = new System.Drawing.Point(69, 239);
            this.CalcCom.Name = "CalcCom";
            this.CalcCom.Size = new System.Drawing.Size(253, 40);
            this.CalcCom.TabIndex = 5;
            this.CalcCom.TabStop = false;
            this.CalcCom.Click += new System.EventHandler(this.CalcCom_Click);
            this.CalcCom.MouseLeave += new System.EventHandler(this.CalcCom_MouseLeave);
            this.CalcCom.MouseHover += new System.EventHandler(this.CalcCom_MouseHover);
            // 
            // P_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.CalcCom);
            this.Controls.Add(this.NC_);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P_1";
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NC_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcCom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Return;
        private System.Windows.Forms.PictureBox NC_;
        private System.Windows.Forms.PictureBox CalcCom;
    }
}