namespace LCG
{
    partial class LCGForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCGForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelEq1 = new System.Windows.Forms.Label();
            this.labelEq2 = new System.Windows.Forms.Label();
            this.labelEq2Preview = new System.Windows.Forms.Label();
            this.labelEq1Preview = new System.Windows.Forms.Label();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.checkBoxEquations = new System.Windows.Forms.CheckBox();
            this.labelPhaseMin = new System.Windows.Forms.Label();
            this.trackBarPhase = new System.Windows.Forms.TrackBar();
            this.labelFreqMin = new System.Windows.Forms.Label();
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.labelPhaseMax = new System.Windows.Forms.Label();
            this.textBoxPhaseValue = new System.Windows.Forms.TextBox();
            this.labelPhaseTitle = new System.Windows.Forms.Label();
            this.labelFreqMax = new System.Windows.Forms.Label();
            this.textBoxFreqValue = new System.Windows.Forms.TextBox();
            this.labelFreqTitle = new System.Windows.Forms.Label();
            this.labelAmpMax = new System.Windows.Forms.Label();
            this.trackBarAmp = new System.Windows.Forms.TrackBar();
            this.labelAmpMin = new System.Windows.Forms.Label();
            this.textBoxAmpValue = new System.Windows.Forms.TextBox();
            this.labelAmpTitle = new System.Windows.Forms.Label();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.checkBoxAnimate = new System.Windows.Forms.CheckBox();
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.pictureBoxEq1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEq2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPhase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEq2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTitle.Location = new System.Drawing.Point(25, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(660, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = " Lissajous Curve Generator";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseUp);
            // 
            // labelMinimize
            // 
            this.labelMinimize.BackColor = System.Drawing.Color.Transparent;
            this.labelMinimize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMinimize.ForeColor = System.Drawing.Color.DimGray;
            this.labelMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMinimize.Location = new System.Drawing.Point(721, 1);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(39, 24);
            this.labelMinimize.TabIndex = 1;
            this.labelMinimize.Text = "-";
            this.labelMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            this.labelMinimize.MouseLeave += new System.EventHandler(this.labelMinimize_MouseLeave);
            this.labelMinimize.MouseHover += new System.EventHandler(this.labelMinimize_MouseHover);
            // 
            // labelEq1
            // 
            this.labelEq1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelEq1.ForeColor = System.Drawing.Color.Black;
            this.labelEq1.Location = new System.Drawing.Point(52, 45);
            this.labelEq1.Margin = new System.Windows.Forms.Padding(5);
            this.labelEq1.Name = "labelEq1";
            this.labelEq1.Size = new System.Drawing.Size(92, 21);
            this.labelEq1.TabIndex = 3;
            this.labelEq1.Text = "Equation 1";
            this.labelEq1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelEq1.Click += new System.EventHandler(this.labelEq1_Click);
            this.labelEq1.MouseLeave += new System.EventHandler(this.labelEq1_MouseLeave);
            this.labelEq1.MouseHover += new System.EventHandler(this.labelEq1_MouseHover);
            // 
            // labelEq2
            // 
            this.labelEq2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelEq2.ForeColor = System.Drawing.Color.DimGray;
            this.labelEq2.Location = new System.Drawing.Point(187, 45);
            this.labelEq2.Margin = new System.Windows.Forms.Padding(5);
            this.labelEq2.Name = "labelEq2";
            this.labelEq2.Size = new System.Drawing.Size(92, 21);
            this.labelEq2.TabIndex = 4;
            this.labelEq2.Text = "Equation 2";
            this.labelEq2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelEq2.Click += new System.EventHandler(this.labelEq2_Click);
            this.labelEq2.MouseLeave += new System.EventHandler(this.labelEq2_MouseLeave);
            this.labelEq2.MouseHover += new System.EventHandler(this.labelEq2_MouseHover);
            // 
            // labelEq2Preview
            // 
            this.labelEq2Preview.BackColor = System.Drawing.Color.Transparent;
            this.labelEq2Preview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelEq2Preview.ForeColor = System.Drawing.Color.DimGray;
            this.labelEq2Preview.Location = new System.Drawing.Point(483, 710);
            this.labelEq2Preview.Name = "labelEq2Preview";
            this.labelEq2Preview.Size = new System.Drawing.Size(209, 20);
            this.labelEq2Preview.TabIndex = 11;
            this.labelEq2Preview.Text = "second equation";
            this.labelEq2Preview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEq2Preview.Visible = false;
            // 
            // labelEq1Preview
            // 
            this.labelEq1Preview.BackColor = System.Drawing.Color.Transparent;
            this.labelEq1Preview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelEq1Preview.ForeColor = System.Drawing.Color.Black;
            this.labelEq1Preview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEq1Preview.Location = new System.Drawing.Point(105, 710);
            this.labelEq1Preview.Name = "labelEq1Preview";
            this.labelEq1Preview.Size = new System.Drawing.Size(209, 20);
            this.labelEq1Preview.TabIndex = 10;
            this.labelEq1Preview.Text = "first equation";
            this.labelEq1Preview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEq1Preview.Visible = false;
            // 
            // pictureIcon
            // 
            this.pictureIcon.ErrorImage = null;
            this.pictureIcon.Image = global::LCG.Properties.Resources.icon2;
            this.pictureIcon.InitialImage = null;
            this.pictureIcon.Location = new System.Drawing.Point(4, 4);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(21, 21);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 7;
            this.pictureIcon.TabStop = false;
            // 
            // labelClose
            // 
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelClose.ForeColor = System.Drawing.Color.DimGray;
            this.labelClose.Location = new System.Drawing.Point(760, 1);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(39, 24);
            this.labelClose.TabIndex = 2;
            this.labelClose.Text = "x";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            this.labelClose.MouseHover += new System.EventHandler(this.labelClose_MouseHover);
            // 
            // checkBoxEquations
            // 
            this.checkBoxEquations.AutoSize = true;
            this.checkBoxEquations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxEquations.Location = new System.Drawing.Point(60, 423);
            this.checkBoxEquations.Name = "checkBoxEquations";
            this.checkBoxEquations.Size = new System.Drawing.Size(183, 23);
            this.checkBoxEquations.TabIndex = 9;
            this.checkBoxEquations.Text = "Enable equations preview";
            this.checkBoxEquations.UseVisualStyleBackColor = true;
            this.checkBoxEquations.CheckedChanged += new System.EventHandler(this.checkBoxEquations_CheckedChanged);
            // 
            // labelPhaseMin
            // 
            this.labelPhaseMin.AutoSize = true;
            this.labelPhaseMin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhaseMin.Location = new System.Drawing.Point(63, 365);
            this.labelPhaseMin.Name = "labelPhaseMin";
            this.labelPhaseMin.Size = new System.Drawing.Size(13, 13);
            this.labelPhaseMin.TabIndex = 30;
            this.labelPhaseMin.Text = "0";
            // 
            // trackBarPhase
            // 
            this.trackBarPhase.LargeChange = 10;
            this.trackBarPhase.Location = new System.Drawing.Point(56, 335);
            this.trackBarPhase.Maximum = 360;
            this.trackBarPhase.Name = "trackBarPhase";
            this.trackBarPhase.Size = new System.Drawing.Size(243, 45);
            this.trackBarPhase.TabIndex = 26;
            this.trackBarPhase.TickFrequency = 5;
            this.trackBarPhase.Value = 100;
            this.trackBarPhase.Scroll += new System.EventHandler(this.trackBarPhase_Scroll);
            // 
            // labelFreqMin
            // 
            this.labelFreqMin.AutoSize = true;
            this.labelFreqMin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreqMin.Location = new System.Drawing.Point(63, 260);
            this.labelFreqMin.Name = "labelFreqMin";
            this.labelFreqMin.Size = new System.Drawing.Size(13, 13);
            this.labelFreqMin.TabIndex = 29;
            this.labelFreqMin.Text = "1";
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.LargeChange = 2;
            this.trackBarFreq.Location = new System.Drawing.Point(56, 230);
            this.trackBarFreq.Minimum = 1;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(243, 45);
            this.trackBarFreq.TabIndex = 22;
            this.trackBarFreq.Value = 10;
            this.trackBarFreq.Scroll += new System.EventHandler(this.trackBarFreq_Scroll);
            // 
            // labelPhaseMax
            // 
            this.labelPhaseMax.AutoSize = true;
            this.labelPhaseMax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhaseMax.Location = new System.Drawing.Point(272, 365);
            this.labelPhaseMax.Name = "labelPhaseMax";
            this.labelPhaseMax.Size = new System.Drawing.Size(25, 13);
            this.labelPhaseMax.TabIndex = 28;
            this.labelPhaseMax.Text = "360";
            // 
            // textBoxPhaseValue
            // 
            this.textBoxPhaseValue.Enabled = false;
            this.textBoxPhaseValue.Location = new System.Drawing.Point(249, 305);
            this.textBoxPhaseValue.Name = "textBoxPhaseValue";
            this.textBoxPhaseValue.Size = new System.Drawing.Size(40, 22);
            this.textBoxPhaseValue.TabIndex = 27;
            this.textBoxPhaseValue.Text = "100";
            this.textBoxPhaseValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPhaseTitle
            // 
            this.labelPhaseTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPhaseTitle.Location = new System.Drawing.Point(56, 305);
            this.labelPhaseTitle.Name = "labelPhaseTitle";
            this.labelPhaseTitle.Size = new System.Drawing.Size(75, 20);
            this.labelPhaseTitle.TabIndex = 25;
            this.labelPhaseTitle.Text = "Phase";
            // 
            // labelFreqMax
            // 
            this.labelFreqMax.AutoSize = true;
            this.labelFreqMax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreqMax.Location = new System.Drawing.Point(276, 260);
            this.labelFreqMax.Name = "labelFreqMax";
            this.labelFreqMax.Size = new System.Drawing.Size(19, 13);
            this.labelFreqMax.TabIndex = 24;
            this.labelFreqMax.Text = "10";
            // 
            // textBoxFreqValue
            // 
            this.textBoxFreqValue.Enabled = false;
            this.textBoxFreqValue.Location = new System.Drawing.Point(249, 200);
            this.textBoxFreqValue.Name = "textBoxFreqValue";
            this.textBoxFreqValue.Size = new System.Drawing.Size(40, 22);
            this.textBoxFreqValue.TabIndex = 23;
            this.textBoxFreqValue.Text = "10";
            this.textBoxFreqValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFreqTitle
            // 
            this.labelFreqTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFreqTitle.Location = new System.Drawing.Point(56, 200);
            this.labelFreqTitle.Name = "labelFreqTitle";
            this.labelFreqTitle.Size = new System.Drawing.Size(75, 20);
            this.labelFreqTitle.TabIndex = 21;
            this.labelFreqTitle.Text = "Frequency";
            // 
            // labelAmpMax
            // 
            this.labelAmpMax.AutoSize = true;
            this.labelAmpMax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmpMax.Location = new System.Drawing.Point(272, 154);
            this.labelAmpMax.Name = "labelAmpMax";
            this.labelAmpMax.Size = new System.Drawing.Size(25, 13);
            this.labelAmpMax.TabIndex = 20;
            this.labelAmpMax.Text = "200";
            // 
            // trackBarAmp
            // 
            this.trackBarAmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trackBarAmp.LargeChange = 10;
            this.trackBarAmp.Location = new System.Drawing.Point(56, 124);
            this.trackBarAmp.Maximum = 200;
            this.trackBarAmp.Minimum = 1;
            this.trackBarAmp.Name = "trackBarAmp";
            this.trackBarAmp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarAmp.Size = new System.Drawing.Size(243, 45);
            this.trackBarAmp.TabIndex = 17;
            this.trackBarAmp.TickFrequency = 5;
            this.trackBarAmp.Value = 150;
            this.trackBarAmp.Scroll += new System.EventHandler(this.trackBarAmp_Scroll);
            // 
            // labelAmpMin
            // 
            this.labelAmpMin.AutoSize = true;
            this.labelAmpMin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmpMin.Location = new System.Drawing.Point(63, 154);
            this.labelAmpMin.Name = "labelAmpMin";
            this.labelAmpMin.Size = new System.Drawing.Size(13, 13);
            this.labelAmpMin.TabIndex = 19;
            this.labelAmpMin.Text = "1";
            // 
            // textBoxAmpValue
            // 
            this.textBoxAmpValue.Enabled = false;
            this.textBoxAmpValue.Location = new System.Drawing.Point(249, 94);
            this.textBoxAmpValue.Name = "textBoxAmpValue";
            this.textBoxAmpValue.Size = new System.Drawing.Size(40, 22);
            this.textBoxAmpValue.TabIndex = 18;
            this.textBoxAmpValue.Text = "150";
            this.textBoxAmpValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAmpTitle
            // 
            this.labelAmpTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelAmpTitle.Location = new System.Drawing.Point(56, 94);
            this.labelAmpTitle.Name = "labelAmpTitle";
            this.labelAmpTitle.Size = new System.Drawing.Size(75, 20);
            this.labelAmpTitle.TabIndex = 16;
            this.labelAmpTitle.Text = "Amplitude";
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraph.Location = new System.Drawing.Point(340, 45);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(420, 420);
            this.pictureBoxGraph.TabIndex = 31;
            this.pictureBoxGraph.TabStop = false;
            // 
            // checkBoxAnimate
            // 
            this.checkBoxAnimate.AutoSize = true;
            this.checkBoxAnimate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxAnimate.Location = new System.Drawing.Point(60, 394);
            this.checkBoxAnimate.Name = "checkBoxAnimate";
            this.checkBoxAnimate.Size = new System.Drawing.Size(119, 23);
            this.checkBoxAnimate.TabIndex = 32;
            this.checkBoxAnimate.Text = "Animate graph";
            this.checkBoxAnimate.UseVisualStyleBackColor = true;
            this.checkBoxAnimate.CheckedChanged += new System.EventHandler(this.checkBoxAnimate_CheckedChanged);
            // 
            // timerAnimate
            // 
            this.timerAnimate.Interval = 20;
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxGrid.Location = new System.Drawing.Point(60, 452);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(123, 23);
            this.checkBoxGrid.TabIndex = 33;
            this.checkBoxGrid.Text = "Enable gridlines";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // pictureBoxEq1
            // 
            this.pictureBoxEq1.BackColor = System.Drawing.Color.White;
            this.pictureBoxEq1.Location = new System.Drawing.Point(40, 507);
            this.pictureBoxEq1.Name = "pictureBoxEq1";
            this.pictureBoxEq1.Size = new System.Drawing.Size(350, 200);
            this.pictureBoxEq1.TabIndex = 34;
            this.pictureBoxEq1.TabStop = false;
            // 
            // pictureBoxEq2
            // 
            this.pictureBoxEq2.BackColor = System.Drawing.Color.White;
            this.pictureBoxEq2.Location = new System.Drawing.Point(410, 507);
            this.pictureBoxEq2.Name = "pictureBoxEq2";
            this.pictureBoxEq2.Size = new System.Drawing.Size(350, 200);
            this.pictureBoxEq2.TabIndex = 35;
            this.pictureBoxEq2.TabStop = false;
            // 
            // LCGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBoxEq2);
            this.Controls.Add(this.pictureBoxEq1);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.labelEq2Preview);
            this.Controls.Add(this.labelEq1Preview);
            this.Controls.Add(this.checkBoxAnimate);
            this.Controls.Add(this.pictureBoxGraph);
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
            this.Controls.Add(this.checkBoxEquations);
            this.Controls.Add(this.pictureIcon);
            this.Controls.Add(this.labelEq2);
            this.Controls.Add(this.labelEq1);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelMinimize);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LCGForm";
            this.Text = "LCG";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPhase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEq2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelEq1;
        private System.Windows.Forms.Label labelEq2;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Label labelEq1Preview;
        private System.Windows.Forms.Label labelEq2Preview;
        private System.Windows.Forms.CheckBox checkBoxEquations;
        private System.Windows.Forms.Label labelPhaseMin;
        private System.Windows.Forms.Label labelFreqMin;
        private System.Windows.Forms.Label labelPhaseMax;
        private System.Windows.Forms.TextBox textBoxPhaseValue;
        private System.Windows.Forms.TrackBar trackBarPhase;
        private System.Windows.Forms.Label labelPhaseTitle;
        private System.Windows.Forms.Label labelFreqMax;
        private System.Windows.Forms.TextBox textBoxFreqValue;
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.Label labelFreqTitle;
        private System.Windows.Forms.Label labelAmpMax;
        private System.Windows.Forms.Label labelAmpMin;
        private System.Windows.Forms.TextBox textBoxAmpValue;
        private System.Windows.Forms.TrackBar trackBarAmp;
        private System.Windows.Forms.Label labelAmpTitle;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.CheckBox checkBoxAnimate;
        private System.Windows.Forms.Timer timerAnimate;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.PictureBox pictureBoxEq1;
        private System.Windows.Forms.PictureBox pictureBoxEq2;
    }
}

