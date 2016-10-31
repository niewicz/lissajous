using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCG
{
    public partial class controlEq1 : UserControl
    {
        public controlEq1()
        {
            InitializeComponent();
        }

        public int Amplitude
        {
            get { return this.trackBarAmp.Value; }
            set
            {
                this.trackBarAmp.Value = value;
                this.textBoxAmpValue.Text = value.ToString();
            }
        }

        public int Frequency
        {
            get { return this.trackBarFreq.Value; }
            set
            {
                this.trackBarFreq.Value = value;
                this.textBoxFreqValue.Text = value.ToString();
            }
        }

        public int Phase
        {
            get { return this.trackBarPhase.Value; }
            set
            {
                this.trackBarPhase.Value = value;
                this.textBoxPhaseValue.Text = value.ToString();
            }
        }

        private void trackBarAmp_Scroll(object sender, EventArgs e)
        {
            this.textBoxAmpValue.Text = this.trackBarAmp.Value.ToString();
        }

        private void trackBarFreq_Scroll(object sender, EventArgs e)
        {
            this.textBoxFreqValue.Text = this.trackBarFreq.Value.ToString();
        }

        private void trackBarPhase_Scroll(object sender, EventArgs e)
        {
            this.textBoxPhaseValue.Text = this.trackBarPhase.Value.ToString();
        }
    }
}
