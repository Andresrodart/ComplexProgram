namespace N.Complejos
{
    partial class Roots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roots));
            this.RootsArea = new System.Windows.Forms.TextBox();
            this._Close = new System.Windows.Forms.PictureBox();
            this.chart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // RootsArea
            // 
            this.RootsArea.AcceptsReturn = true;
            this.RootsArea.AcceptsTab = true;
            this.RootsArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RootsArea.Font = new System.Drawing.Font("mimich", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RootsArea.HideSelection = false;
            this.RootsArea.Location = new System.Drawing.Point(70, 100);
            this.RootsArea.Multiline = true;
            this.RootsArea.Name = "RootsArea";
            this.RootsArea.ReadOnly = true;
            this.RootsArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RootsArea.Size = new System.Drawing.Size(460, 247);
            this.RootsArea.TabIndex = 0;
            this.RootsArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _Close
            // 
            this._Close.BackColor = System.Drawing.Color.Transparent;
            this._Close.Location = new System.Drawing.Point(578, 1);
            this._Close.Name = "_Close";
            this._Close.Size = new System.Drawing.Size(21, 22);
            this._Close.TabIndex = 8;
            this._Close.TabStop = false;
            this._Close.Click += new System.EventHandler(this._Close_Click);
            this._Close.MouseLeave += new System.EventHandler(this._Close_MouseLeave);
            this._Close.MouseHover += new System.EventHandler(this._Close_MouseHover);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.Image = global::N.Complejos.Properties.Resources.graph;
            this.chart.Location = new System.Drawing.Point(554, 357);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(34, 31);
            this.chart.TabIndex = 11;
            this.chart.TabStop = false;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // Roots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::N.Complejos.Properties.Resources.RootsTemplate1;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.chart);
            this.Controls.Add(this._Close);
            this.Controls.Add(this.RootsArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Roots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roots";
            ((System.ComponentModel.ISupportInitialize)(this._Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RootsArea;
        private System.Windows.Forms.PictureBox _Close;
        private System.Windows.Forms.PictureBox chart;
    }
}