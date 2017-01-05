using Bandeira.RelogioBlinds.Business;
using System;
using System.Drawing;
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
            limpaFichasBlind();

            //lblValorSB.Text = relogioBlinds.GetCurrentNivelString();

            NivelBase current = relogioBlinds.GetCurrentNivel();

            if (current is Nivel)
            {
                lblValorSB.Text = ((Nivel)current).SmallBlind.ToString();
                lblValorBB.Text = ((Nivel)current).BigBlind.ToString();
                lblValorAnti.Text = ((Nivel)current).Anti.ToString();
                lblValor3xBB.Text = (((Nivel)current).BigBlind * 3).ToString();
                lblValor10xBB.Text = (((Nivel)current).BigBlind * 10).ToString();

                lblValor3xBB.Visible = true;
                lbl3BB.Visible = true;
                lblValor10xBB.Visible = true;
                lbl10BB.Visible = true;
            }
            else if (current is Break)
            {
                lblValor3xBB.Visible = false;
                lbl3BB.Visible = false;
                lblValor10xBB.Visible = false;
                lbl10BB.Visible = false;
            }

            lblNumero.Text = current.Numero.ToString();

            lblMensagem.Text = current.Mensagem;

            lblProximoBlind.Text = relogioBlinds.GetStringNextBlind();

            if (relogioBlinds.FichasBB != null)
            {
                lblBB.Visible = true;
                lblValorBB.Visible = true;

                for (int i = 1; i < relogioBlinds.FichasBB.Count + 1; i++)
                {
                    if (i == 1)
                    {
                        ExibeFicha(lblFichaBB1, relogioBlinds.FichasBB[i - 1]);
                    }
                    else if (i == 2)
                    {
                        ExibeFicha(lblFichaBB2, relogioBlinds.FichasBB[i - 1]);
                    }
                    else if (i == 3)
                    {
                        ExibeFicha(lblFichaBB3, relogioBlinds.FichasBB[i - 1]);
                    }
                    else if (i == 4)
                    {
                        ExibeFicha(lblFichaBB4, relogioBlinds.FichasBB[i - 1]);
                    }
                    else if (i == 5)
                    {
                        ExibeFicha(lblFichaBB5, relogioBlinds.FichasBB[i - 1]);
                    }
                }
            }
            else
            {
                lblBB.Visible = false;
                lblValorBB.Visible = false;
            }

            if (relogioBlinds.FichasSB != null)
            {
                lblSB.Visible = true;
                lblValorSB.Visible = true;

                for (int i = 1; i < relogioBlinds.FichasSB.Count + 1; i++)
                {
                    if (i == 1)
                    {
                        ExibeFicha(lblFichaSB1, relogioBlinds.FichasSB[i - 1]);
                    }
                    else if (i == 2)
                    {
                        ExibeFicha(lblFichaSB2, relogioBlinds.FichasSB[i - 1]);
                    }
                    else if (i == 3)
                    {
                        ExibeFicha(lblFichaSB3, relogioBlinds.FichasSB[i - 1]);
                    }
                    else if (i == 4)
                    {
                        ExibeFicha(lblFichaSB4, relogioBlinds.FichasSB[i - 1]);
                    }
                    else if (i == 5)
                    {
                        ExibeFicha(lblFichaSB5, relogioBlinds.FichasSB[i - 1]);
                    }
                }
            }
            else
            {
                lblSB.Visible = false;
                lblValorSB.Visible = false;
            }

            if (relogioBlinds.FichasAnti != null && relogioBlinds.FichasAnti.Count > 0)
            {
                lblAnti.Visible = true;
                lblValorAnti.Visible = true;

                for (int i = 1; i < relogioBlinds.FichasAnti.Count + 1; i++)
                {
                    if (i == 1)
                    {
                        ExibeFicha(lblAnti1, relogioBlinds.FichasAnti[i - 1]);
                    }
                    else if (i == 2)
                    {
                        ExibeFicha(lblAnti2, relogioBlinds.FichasAnti[i - 1]);
                    }
                    else if (i == 3)
                    {
                        ExibeFicha(lblAnti3, relogioBlinds.FichasAnti[i - 1]);
                    }
                    else if (i == 4)
                    {
                        ExibeFicha(lblAnti4, relogioBlinds.FichasAnti[i - 1]);
                    }
                    else if (i == 5)
                    {
                        ExibeFicha(lblAnti5, relogioBlinds.FichasAnti[i - 1]);
                    }
                }
            }
            else
            {
                lblAnti.Visible = false;
                lblValorAnti.Visible = false;
            }

            lblRelogio.Text = relogioBlinds.GetCurrentTempo();

            if (relogioBlinds.GetCurrentNivel() != null && relogioBlinds.GetCurrentNivel().AtEnd)
            {
                this.BackColor = Color.Red;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.LightGray;
                this.ForeColor = Color.Black;
            }
        }

        private void ExibeFicha(Label lbl, Ficha ficha)
        {
            lbl.Text = ficha.Valor.ToString();
            lbl.BackColor = ColorTranslator.FromHtml(ficha.NumeroCor);
            lbl.Visible = true;

            if (ficha.NumeroCor == "#FFFFFF")
            {
                lbl.ForeColor = ColorTranslator.FromHtml("#000000");
            }
            else
            {
                lbl.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            }
        }

        private void limpaFichasBlind()
        {
            lblFichaBB1.Visible = false;
            lblFichaBB2.Visible = false;
            lblFichaBB3.Visible = false;
            lblFichaBB4.Visible = false;
            lblFichaBB5.Visible = false;

            lblFichaSB1.Visible = false;
            lblFichaSB2.Visible = false;
            lblFichaSB3.Visible = false;
            lblFichaSB4.Visible = false;
            lblFichaSB5.Visible = false;

            lblAnti1.Visible = false;
            lblAnti2.Visible = false;
            lblAnti3.Visible = false;
            lblAnti4.Visible = false;
            lblAnti5.Visible = false;
        }
    }
}
