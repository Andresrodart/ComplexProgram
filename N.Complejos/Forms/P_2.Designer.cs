namespace N.Complejos.Forms
{
    partial class P_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_2));
            this.NC_ = new System.Windows.Forms.PictureBox();
            this.Return = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.TR_B = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NC_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TR_B)).BeginInit();
            this.SuspendLayout();
            // 
            // NC_
            // 
            this.NC_.BackColor = System.Drawing.Color.Transparent;
            this.NC_.Location = new System.Drawing.Point(68, 133);
            this.NC_.Name = "NC_";
            this.NC_.Size = new System.Drawing.Size(253, 40);
            this.NC_.TabIndex = 5;
            this.NC_.TabStop = false;
            this.NC_.Click += new System.EventHandler(this.NC__Click);
            this.NC_.MouseLeave += new System.EventHandler(this.NC__MouseLeave);
            this.NC_.MouseHover += new System.EventHandler(this.NC__MouseHover);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.Location = new System.Drawing.Point(12, 466);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(100, 25);
            this.Return.TabIndex = 6;
            this.Return.TabStop = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            this.Return.MouseLeave += new System.EventHandler(this.Return_MouseLeave);
            this.Return.MouseHover += new System.EventHandler(this.Return_MouseHover);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Location = new System.Drawing.Point(294, 467);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 25);
            this.Close.TabIndex = 7;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // TR_B
            // 
            this.TR_B.BackColor = System.Drawing.Color.Transparent;
            this.TR_B.Location = new System.Drawing.Point(68, 240);
            this.TR_B.Name = "TR_B";
            this.TR_B.Size = new System.Drawing.Size(253, 40);
            this.TR_B.TabIndex = 8;
            this.TR_B.TabStop = false;
            this.TR_B.Click += new System.EventHandler(this.TR_B_Click);
            // 
            // P_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::N.Complejos.Properties.Resources.P_2T;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.TR_B);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.NC_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P_2";
            ((System.ComponentModel.ISupportInitialize)(this.NC_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TR_B)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox NC_;
        private System.Windows.Forms.PictureBox Return;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox TR_B;
    }
}