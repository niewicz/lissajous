namespace LCG
{
    partial class controlEq1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAmpTitle = new System.Windows.Forms.Label();
            this.trackBarAmp = new System.Windows.Forms.TrackBar();
            this.textBoxAmpValue = new System.Windows.Forms.TextBox();
            this.labelAmpMin = new System.Windows.Forms.Label();
            this.labelAmpMax = new System.Windows.Forms.Label();
            this.labelFreqMax = new System.Windows.Forms.Label();
            this.textBoxFreqValue = new System.Windows.Forms.TextBox();
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.labelFreqTitle = new System.Windows.Forms.Label();
            this.labelPhaseMax = new System.Windows.Forms.Label();
            this.textBoxPhaseValue = new System.Windows.Forms.TextBox();
            this.trackBarPhase = new System.Windows.Forms.TrackBar();
            this.labelPhaseTitle = new System.Windows.Forms.Label();
            this.labelFreqMin = new System.Windows.Forms.Label();
            this.labelPhaseMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPhase)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmpTitle
            // 
            this.labelAmpTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelAmpTitle.Location = new System.Drawing.Point(10, 25);
            this.labelAmpTitle.Name = "labelAmpTitle";
            this.labelAmpTitle.Size = new System.Drawing.Size(75, 20);
            this.labelAmpTitle.TabIndex = 0;
            this.labelAmpTitle.Text = "Amplitude";
            // 
            // trackBarAmp
            // 
            this.trackBarAmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trackBarAmp.LargeChange = 10;
            this.trackBarAmp.Location = new System.Drawing.Point(10, 55);
            this.trackBarAmp.Maximum = 180;
            this.trackBarAmp.Minimum = 1;
            this.trackBarAmp.Name = "trackBarAmp";
            this.trackBarAmp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarAmp.Size = new System.Drawing.Size(243, 45);
            this.trackBarAmp.TabIndex = 1;
            this.trackBarAmp.TickFrequency = 5;
            this.trackBarAmp.Value = 100;
            this.trackBarAmp.Scroll += new System.EventHandler(this.trackBarAmp_Scroll);
            // 
            // textBoxAmpValue
            // 
            this.textBoxAmpValue.Enabled = false;
            this.textBoxAmpValue.Location = new System.Drawing.Point(203, 25);
            this.textBoxAmpValue.Name = "textBoxAmpValue";
            this.textBoxAmpValue.Size = new System.Drawing.Size(40, 20);
            this.textBoxAmpValue.TabIndex = 3;
            // 
            // labelAmpMin
            // 
            this.labelAmpMin.AutoSize = true;
            this.labelAmpMin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmpMin.Location = new System.Drawing.Point(17, 85);
            this.labelAmpMin.Name = "labelAmpMin";
            this.labelAmpMin.Size = new System.Drawing.Size(13, 13);
            this.labelAmpMin.TabIndex = 4;
            this.labelAmpMin.Text = "1";
            // 
            // labelAmpMax
            // 
            this.labelAmpMax.AutoSize = true;
            this.labelAmpMax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmpMax.Location = new System.Drawing.Point(226, 85);
            this.labelAmpMax.Name = "labelAmpMax";
            this.labelAmpMax.Size = new System.Drawing.Size(25, 13);
            this.labelAmpMax.TabIndex = 5;
            this.labelAmpMax.Text = "180";
            // 
            // labelFreqMax
            // 
            this.labelFreqMax.AutoSize = true;
            this.labelFreqMax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreqMax.Location = new System.Drawing.Point(230, 192);
            this.labelFreqMax.Name = "labelFreqMax";
            this.labelFreqMax.Size = new System.Drawing.Size(19, 13);
            this.labelFreqMax.TabIndex = 9;
            this.labelFreqMax.Text = "10";
            // 
            // textBoxFreqValue
            // 
            this.textBoxFreqValue.Enabled = false;
            this.textBoxFreqValue.Location = new System.Drawing.Point(203, 132);
            this.textBoxFreqValue.Name = "textBoxFreqValue";
            this.textBoxFreqValue.Size = new System.Drawing.Size(40, 20);
            this.textBoxFreqValue.TabIndex = 8;
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.LargeChange = 2;
            this.trackBarFreq.Location = new System.Drawing.Point(10, 162);
            this.trackBarFreq.Minimum = 1;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(243, 45);
            this.trackBarFreq.TabIndex = 7;
            this.trackBarFreq.Value = 10;
            this.trackBarFreq.Scroll += new System.EventHandler(this.trackBarFreq_Scroll);
            // 
            // labelFreqTitle
            // 
            this.labelFreqTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFreqTitle.Location = new System.Drawing.Point(10, 132);
            this.labelFreqTitle.Name = "labelFreqTitle";
            this.labelFreqTitle.Size = new System.Drawing.Size(75, 20);
            this.labelFreqTitle.TabIndex = 6;
            this.labelFreqTitle.Text = "Frequency";
            // 
            // labelPhaseMax
            // 
            this.labelPhaseMax.AutoSize = true;
            this.labelPhaseMax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhaseMax.Location = new System.Drawing.Point(226, 299);
            this.labelPhaseMax.Name = "labelPhaseMax";
            this.labelPhaseMax.Size = new System.Drawing.Size(25, 13);
            this.labelPhaseMax.TabIndex = 13;
            this.labelPhaseMax.Text = "360";
            // 
            // textBoxPhaseValue
            // 
            this.textBoxPhaseValue.Enabled = false;
            this.textBoxPhaseValue.Location = new System.Drawing.Point(203, 239);
            this.textBoxPhaseValue.Name = "textBoxPhaseValue";
            this.textBoxPhaseValue.Size = new System.Drawing.Size(40, 20);
            this.textBoxPhaseValue.TabIndex = 12;
            // 
            // trackBarPhase
            // 
            this.trackBarPhase.LargeChange = 10;
            this.trackBarPhase.Location = new System.Drawing.Point(10, 269);
            this.trackBarPhase.Maximum = 360;
            this.trackBarPhase.Name = "trackBarPhase";
            this.trackBarPhase.Size = new System.Drawing.Size(243, 45);
            this.trackBarPhase.TabIndex = 11;
            this.trackBarPhase.TickFrequency = 5;
            this.trackBarPhase.Value = 100;
            this.trackBarPhase.Scroll += new System.EventHandler(this.trackBarPhase_Scroll);
            // 
            // labelPhaseTitle
            // 
            this.labelPhaseTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPhaseTitle.Location = new System.Drawing.Point(10, 239);
            this.labelPhaseTitle.Name = "labelPhaseTitle";
            this.labelPhaseTitle.Size = new System.Drawing.Size(75, 20);
            this.labelPhaseTitle.TabIndex = 10;
            this.labelPhaseTitle.Text = "Phase";
            // 
            // labelFreqMin
            // 
            this.labelFreqMin.AutoSize = true;
            this.labelFreqMin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreqMin.Location = new System.Drawing.Point(17, 192);
            this.labelFreqMin.Name = "labelFreqMin";
            this.labelFreqMin.Size = new System.Drawing.Size(13, 13);
            this.labelFreqMin.TabIndex = 14;
            this.labelFreqMin.Text = "1";
            // 
            // labelPhaseMin
            // 
            this.labelPhaseMin.AutoSize = true;
            this.labelPhaseMin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhaseMin.Location = new System.Drawing.Point(17, 299);
            this.labelPhaseMin.Name = "labelPhaseMin";
            this.labelPhaseMin.Size = new System.Drawing.Size(13, 13);
            this.labelPhaseMin.TabIndex = 15;
            this.labelPhaseMin.Text = "0";
            // 
            // controlEq1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.labelPhaseMin);
            this.Controls.Add(this.labelFreqMin);
            this.Controls.Add(this.labelPhaseMax);
            this.Controls.Add(this.textBoxPhaseValue);
            this.Controls.Add(this.trackBarPhase);
            this.Controls.Add(this.labelPhaseTitle);
            this.Controls.Add(this.labelFreqMax);
            this.Controls.Add(this.textBoxFreqValue);
            this.Controls.Add(this.trackBarFreq);
            this.Controls.Add(this.labelFreqTitle);
            this.Controls.Add(this.labelAmpMax);
            this.Controls.Add(this.labelAmpMin);
            this.Controls.Add(this.textBoxAmpValue);
            this.Controls.Add(this.trackBarAmp);
            this.Controls.Add(this.labelAmpTitle);
            this.Name = "controlEq1";
            this.Size = new System.Drawing.Size(263, 351);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPhase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmpTitle;
        private System.Windows.Forms.TrackBar trackBarAmp;
        private System.Windows.Forms.TextBox textBoxAmpValue;
        private System.Windows.Forms.Label labelAmpMin;
        private System.Windows.Forms.Label labelAmpMax;
        private System.Windows.Forms.Label labelFreqMax;
        private System.Windows.Forms.TextBox textBoxFreqValue;
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.Label labelFreqTitle;
        private System.Windows.Forms.Label labelPhaseMax;
        private System.Windows.Forms.TextBox textBoxPhaseValue;
        private System.Windows.Forms.TrackBar trackBarPhase;
        private System.Windows.Forms.Label labelPhaseTitle;
        private System.Windows.Forms.Label labelFreqMin;
        private System.Windows.Forms.Label labelPhaseMin;
    }
}
