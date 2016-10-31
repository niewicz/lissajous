using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCG
{
    public partial class LCGForm : Form
    {
        // moving windows
        bool TogMove;
        int MValX;
        int MValY;

        // controls
        bool firstEqSelected;

        // graph variables
        int XAmp, YAmp;
        int XFreq, YFreq;
        int XPhase, YPhase;
        bool IsGridOn;

        public LCGForm()
        {
            InitializeComponent();
            firstEqSelected = true;
            IsGridOn = false;
            this.trackBarPhase.Enabled = false;
            this.InitData();
            this.SetData();
            this.UpdateEquationPreview();
            this.UpdateTextBoxes();
            this.PaintGraphs();
        }

        private void InitData()
        {
            XAmp = 150;
            YAmp = 150;

            XFreq = 1;
            YFreq = 1;

            XPhase = 0;
            YPhase = 0;
        }

        private void SetData()
        {
            if (firstEqSelected)
            {
                this.trackBarAmp.Value = XAmp;
                this.trackBarFreq.Value = XFreq;
                this.trackBarPhase.Value = XPhase;
            }
            else
            {
                this.trackBarAmp.Value = YAmp;
                this.trackBarFreq.Value = YFreq;
                this.trackBarPhase.Value = YPhase;
            }
        }

        private void GetData()
        {
            if (firstEqSelected)
            {
                XAmp = this.trackBarAmp.Value;
                XFreq = this.trackBarFreq.Value;
                XPhase = this.trackBarPhase.Value;
            }
            else
            {
                YAmp = this.trackBarAmp.Value;
                YFreq = this.trackBarFreq.Value;
                YPhase = this.trackBarPhase.Value;
            }
        }

        private void UpdateEquationPreview()
        {
            this.labelEq1Preview.Text = "y\x2081 = " + XAmp.ToString() + " sin(" + XFreq.ToString() + "t)";
            this.labelEq2Preview.Text = "y\x2082 = " + YAmp.ToString() + " sin(" + YFreq.ToString() + "t + " + YPhase.ToString() + "°)";
        }

        private void UpdateTextBoxes()
        {
            if (firstEqSelected)
            {
                this.textBoxAmpValue.Text = XAmp.ToString();
                this.textBoxFreqValue.Text = XFreq.ToString();
                this.textBoxPhaseValue.Text = XPhase.ToString();
            }
            else
            {
                this.textBoxAmpValue.Text = YAmp.ToString();
                this.textBoxFreqValue.Text = YFreq.ToString();
                this.textBoxPhaseValue.Text = YPhase.ToString();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen penGray = new Pen(Color.Gray, 2);

            Graphics externalBorder = this.CreateGraphics();
            externalBorder.DrawRectangle(penGray, 0, 0, this.Size.Width, this.Size.Height);

            externalBorder.Dispose();
        }

        private void PaintGraphs()
        {
            PaintMainGraph();
            if (checkBoxEquations.Checked)
            {
                PaintEquationGraph(this.pictureBoxEq1, 1);
                PaintEquationGraph(this.pictureBoxEq2, 2);
            }
        }

        private void PaintMainGraph()
        {
            Pen DimGrayPen = new Pen(Color.DimGray, 2);
            Pen LightGrayPen = new Pen(Color.LightGray, 2);
            Pen WhiteSmokePen = new Pen(Color.Gainsboro, 1);
            List<Point> pointList = new List<Point>();

            double XPhaseRad = XPhase * Math.PI / 180;
            double YPhaseRad = YPhase * Math.PI / 180;
            double t_max = Math.PI * 2, t;

            for (t = 0; t < t_max; t += Math.PI / 500)
            {
                pointList.Add(new Point(this.pictureBoxGraph.Size.Width / 2 + Convert.ToInt16(XAmp * Math.Sin(XFreq * t + XPhaseRad)), this.pictureBoxGraph.Size.Height / 2 + Convert.ToInt16(YAmp * Math.Cos(YFreq * t + YPhaseRad))));
            }

            Bitmap flag = new Bitmap(pictureBoxGraph.Size.Width, pictureBoxGraph.Size.Height);
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.DrawRectangle(LightGrayPen, 0, 0, pictureBoxGraph.Size.Width, pictureBoxGraph.Size.Height);

            if (IsGridOn)
            {
                for (int i = 0; i <= pictureBoxGraph.Size.Width; i += 10)
                {
                    flagGraphics.DrawLine(WhiteSmokePen, i, 0, i, pictureBoxGraph.Size.Height);
                    //flagGraphics.DrawString((i - 210).ToString(), new Font("myFont", 10), new SolidBrush(Color.Black), i, this.pictureBoxGraph.Size.Height / 2);
                }
                for (int i = 0; i <= pictureBoxGraph.Size.Height; i += 10)
                {
                    flagGraphics.DrawLine(WhiteSmokePen, 0, i, pictureBoxGraph.Size.Width, i);
                }
                flagGraphics.DrawLine(LightGrayPen, 0, this.pictureBoxGraph.Size.Height / 2, this.pictureBoxGraph.Size.Width, this.pictureBoxGraph.Size.Height / 2);
                flagGraphics.DrawLine(LightGrayPen, this.pictureBoxGraph.Size.Width / 2, 0, this.pictureBoxGraph.Size.Width / 2, this.pictureBoxGraph.Size.Height);


            }

            flagGraphics.DrawLines(DimGrayPen, pointList.ToArray());
            pictureBoxGraph.Image = flag;
        }


        private void PaintEquationGraph(PictureBox MyDrawingPlace, int EquationSelector)
        {
            Pen WhiteSmokePen = new Pen(Color.WhiteSmoke, 1);
            List<Point> pointList = new List<Point>();

            double t_max = Math.PI * 2.5, t;

            if (EquationSelector == 1)
            {
                for (t = 0; t < t_max; t += Math.PI / 500)
                {
                    pointList.Add(new Point(Convert.ToInt16(t * 50), Convert.ToInt16((XAmp / 2.1) * Math.Sin(XFreq * t)) + 100));
                }
            }
            else
            {
                double YPhaseRad = YPhase * Math.PI / 180;
                for (t = 0; t < t_max; t += Math.PI / 500)
                {
                    pointList.Add(new Point(Convert.ToInt16(t * 50), Convert.ToInt16((YAmp / 2.1) * Math.Sin(YFreq * t + YPhaseRad)) + 100));
                }
            }

            Bitmap flag = new Bitmap(MyDrawingPlace.Size.Width, MyDrawingPlace.Size.Height);
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.DrawRectangle(new Pen(Color.LightGray, 2), 0, 0, MyDrawingPlace.Size.Width, MyDrawingPlace.Size.Height);

            if (IsGridOn)
            {
                for (int i = 10; i < MyDrawingPlace.Size.Width; i += 10)
                {
                    flagGraphics.DrawLine(WhiteSmokePen, i, 1, i, MyDrawingPlace.Size.Height - 2);
                }
                for (int i = 10; i < MyDrawingPlace.Size.Height; i += 10)
                {
                    flagGraphics.DrawLine(WhiteSmokePen, 1, i, MyDrawingPlace.Size.Width - 2, i);
                }

                flagGraphics.DrawLine(new Pen(Color.LightGray, 1), 0, MyDrawingPlace.Size.Height / 2, MyDrawingPlace.Size.Width, MyDrawingPlace.Size.Height / 2);
            }

            flagGraphics.DrawLines(new Pen(Color.Black, 1), pointList.ToArray());
            MyDrawingPlace.Image = flag;
        }

        private void labelClose_MouseHover(object sender, EventArgs e)
        {
            this.labelClose.BackColor = Color.Red;
            this.labelClose.ForeColor = Color.WhiteSmoke;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            this.labelClose.BackColor = Color.Transparent;
            this.labelClose.ForeColor = Color.DimGray;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelMinimize_MouseHover(object sender, EventArgs e)
        {
            this.labelMinimize.BackColor = Color.LightGray;
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            this.labelMinimize.BackColor = Color.Transparent;
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;

        }

        private void labelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void labelEq1_MouseHover(object sender, EventArgs e)
        {
            if (!firstEqSelected)
            {
                this.labelEq1.ForeColor = Color.Black;
            }
        }

        private void labelEq1_MouseLeave(object sender, EventArgs e)
        {
            if (!firstEqSelected)
            {
                this.labelEq1.ForeColor = Color.DimGray;
            }
        }

        private void checkBoxEquations_CheckedChanged(object sender, EventArgs e)
        {
            this.labelEq1Preview.Visible = this.checkBoxEquations.Checked;
            this.labelEq2Preview.Visible = this.checkBoxEquations.Checked;
            this.PaintGraphs();
            if (checkBoxEquations.Checked)
                this.Height = 750;
            else
                this.Height = 500;
            this.Refresh();
        }

        private void trackBarAmp_Scroll(object sender, EventArgs e)
        {
            this.textBoxAmpValue.Text = this.trackBarAmp.Value.ToString();
            this.GetData();
            this.UpdateEquationPreview();
            this.PaintGraphs();

        }

        private void trackBarFreq_Scroll(object sender, EventArgs e)
        {
            this.textBoxFreqValue.Text = this.trackBarFreq.Value.ToString();
            this.GetData();
            this.UpdateEquationPreview();
            this.PaintGraphs();
        }

        private void trackBarPhase_Scroll(object sender, EventArgs e)
        {
            this.textBoxPhaseValue.Text = this.trackBarPhase.Value.ToString();
            this.GetData();
            this.UpdateEquationPreview();
            this.PaintGraphs();
        }

        private void checkBoxAnimate_CheckedChanged(object sender, EventArgs e)
        {
            this.timerAnimate.Enabled = this.checkBoxAnimate.Checked;
            if (!firstEqSelected)
                this.trackBarPhase.Enabled = !this.checkBoxAnimate.Checked;
        }

        private void timerAnimate_Tick(object sender, EventArgs e)
        {
            if (YPhase < 360)
                YPhase++;
            else
                YPhase = 0;

            this.SetData();
            this.PaintGraphs();
            this.UpdateEquationPreview();
            this.UpdateTextBoxes();
        }

        private void labelEq2_MouseHover(object sender, EventArgs e)
        {
            if (firstEqSelected)
            {
                this.labelEq2.ForeColor = Color.Black;
            }
        }

        private void checkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            IsGridOn = checkBoxGrid.Checked;
            this.PaintGraphs();
        }

        private void labelEq2_MouseLeave(object sender, EventArgs e)
        {
            if (firstEqSelected)
            {
                this.labelEq2.ForeColor = Color.DimGray;
            }
        }

        private void labelEq1_Click(object sender, EventArgs e)
        {
            firstEqSelected = true;

            this.trackBarPhase.Enabled = false;

            this.labelEq1.ForeColor = Color.Black;
            this.labelEq1.Font = new Font(this.labelEq1.Font, FontStyle.Bold);
            this.labelEq1Preview.ForeColor = Color.Black;
            this.labelEq1Preview.Font = new Font(this.labelEq1Preview.Font, FontStyle.Bold);

            this.labelEq2.ForeColor = Color.DimGray;
            this.labelEq2.Font = new Font(this.labelEq1.Font, FontStyle.Regular);
            this.labelEq2Preview.ForeColor = Color.DimGray;
            this.labelEq2Preview.Font = new Font(this.labelEq1Preview.Font, FontStyle.Regular);

            this.SetData();
            this.UpdateTextBoxes();
        }

        private void labelEq2_Click(object sender, EventArgs e)
        {
            firstEqSelected = false;
            this.trackBarPhase.Enabled = !this.checkBoxAnimate.Checked;

            this.labelEq2.ForeColor = Color.Black;
            this.labelEq2.Font = new Font(this.labelEq1.Font, FontStyle.Bold);
            this.labelEq2Preview.ForeColor = Color.Black;
            this.labelEq2Preview.Font = new Font(this.labelEq2Preview.Font, FontStyle.Bold);

            this.labelEq1.ForeColor = Color.DimGray;
            this.labelEq1.Font = new Font(this.labelEq1.Font, FontStyle.Regular);
            this.labelEq1Preview.ForeColor = Color.DimGray;
            this.labelEq1Preview.Font = new Font(this.labelEq1Preview.Font, FontStyle.Regular);

            this.SetData();
            this.UpdateTextBoxes();
        }
    }
}
