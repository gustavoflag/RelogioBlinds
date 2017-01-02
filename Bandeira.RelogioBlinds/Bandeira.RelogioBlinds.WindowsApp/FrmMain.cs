using Bandeira.RelogioBlinds.Business;
using System;
using System.Windows.Forms;

namespace Bandeira.RelogioBlinds.WindowsApp
{
    public partial class FrmMain : Form
    {
        Relogio relogioBlinds;

        public FrmMain()
        {
            InitializeComponent();

            relogioBlinds = new Relogio("BlindsConfig.xml");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnStop.Enabled = true;
            btnLast.Enabled = true;
            btnNext.Enabled = true;
            btnStart.Enabled = false;
            relogioBlinds.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            relogioBlinds.Stop();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            relogioBlinds.LastNivel();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            relogioBlinds.NextNivel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NivelBase nivel = relogioBlinds.GetCurrentNivel();

            lblBlind.Text = relogioBlinds.GetCurrentNivelString();
            lblFichasBB.Text = "BB:" + relogioBlinds.GetStringFichasBB();
            lblFichasSB.Text = "SB:" + relogioBlinds.GetStringFichasSB();
            lblFichasAnti.Text = "Anti:" + relogioBlinds.GetStringFichasAnti();
            lblRelogio.Text = relogioBlinds.GetCurrentTempo();

            if (nivel.AtEnd)
            {
                this.BackColor = System.Drawing.Color.Red;
                this.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
