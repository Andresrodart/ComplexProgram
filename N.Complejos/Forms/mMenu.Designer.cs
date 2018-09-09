namespace N.Complejos.Forms
{
    partial class mMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mMenu));
            this.PrimerParcial = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.SegundoParcial = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrimerParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegundoParcial)).BeginInit();
            this.SuspendLayout();
            // 
            // PrimerParcial
            // 
            this.PrimerParcial.BackColor = System.Drawing.Color.Transparent;
            this.PrimerParcial.Location = new System.Drawing.Point(72, 149);
            this.PrimerParcial.Name = "PrimerParcial";
            this.PrimerParcial.Size = new System.Drawing.Size(254, 42);
            this.PrimerParcial.TabIndex = 0;
            this.PrimerParcial.TabStop = false;
            this.PrimerParcial.Click += new System.EventHandler(this.PrimerParcial_Click);
            this.PrimerParcial.MouseLeave += new System.EventHandler(this.PrimerParcial_MouseLeave);
            this.PrimerParcial.MouseHover += new System.EventHandler(this.PrimerParcial_MouseHover);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Location = new System.Drawing.Point(294, 467);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 25);
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // SegundoParcial
            // 
            this.SegundoParcial.BackColor = System.Drawing.Color.Transparent;
            this.SegundoParcial.Location = new System.Drawing.Point(72, 255);
            this.SegundoParcial.Name = "SegundoParcial";
            this.SegundoParcial.Size = new System.Drawing.Size(254, 42);
            this.SegundoParcial.TabIndex = 2;
            this.SegundoParcial.TabStop = false;
            this.SegundoParcial.Click += new System.EventHandler(this.SegundoParcial_Click);
            // 
            // mMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::N.Complejos.Properties.Resources.MainM;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.SegundoParcial);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.PrimerParcial);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mMenu";
            ((System.ComponentModel.ISupportInitialize)(this.PrimerParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegundoParcial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PrimerParcial;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox SegundoParcial;
    }
}