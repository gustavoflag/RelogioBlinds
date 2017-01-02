namespace Bandeira.RelogioBlinds.WindowsApp
{
    partial class FrmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBlind = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblFichasBB = new System.Windows.Forms.Label();
            this.lblFichasSB = new System.Windows.Forms.Label();
            this.lblFichasAnti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(237, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(32, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = ">";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRelogio
            // 
            this.lblRelogio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(149, 101);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(194, 73);
            this.lblRelogio.TabIndex = 1;
            this.lblRelogio.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBlind
            // 
            this.lblBlind.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBlind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlind.Location = new System.Drawing.Point(0, 0);
            this.lblBlind.Name = "lblBlind";
            this.lblBlind.Size = new System.Drawing.Size(487, 20);
            this.lblBlind.TabIndex = 2;
            this.lblBlind.Text = "Blind";
            this.lblBlind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(275, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Enabled = false;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(162, 226);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(31, 23);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "<<";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(199, 226);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "| |";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblFichasBB
            // 
            this.lblFichasBB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFichasBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichasBB.Location = new System.Drawing.Point(0, 20);
            this.lblFichasBB.Name = "lblFichasBB";
            this.lblFichasBB.Size = new System.Drawing.Size(487, 23);
            this.lblFichasBB.TabIndex = 6;
            this.lblFichasBB.Text = "FichasBB";
            this.lblFichasBB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFichasSB
            // 
            this.lblFichasSB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFichasSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichasSB.Location = new System.Drawing.Point(0, 43);
            this.lblFichasSB.Name = "lblFichasSB";
            this.lblFichasSB.Size = new System.Drawing.Size(487, 23);
            this.lblFichasSB.TabIndex = 7;
            this.lblFichasSB.Text = "FichasSB";
            this.lblFichasSB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFichasAnti
            // 
            this.lblFichasAnti.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFichasAnti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichasAnti.Location = new System.Drawing.Point(0, 66);
            this.lblFichasAnti.Name = "lblFichasAnti";
            this.lblFichasAnti.Size = new System.Drawing.Size(487, 23);
            this.lblFichasAnti.TabIndex = 8;
            this.lblFichasAnti.Text = "FichasAnti";
            this.lblFichasAnti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 261);
            this.Controls.Add(this.lblFichasAnti);
            this.Controls.Add(this.lblFichasSB);
            this.Controls.Add(this.lblFichasBB);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblBlind);
            this.Controls.Add(this.lblRelogio);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmMain";
            this.Text = "Relogio Blinds TQSOP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBlind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblFichasBB;
        private System.Windows.Forms.Label lblFichasSB;
        private System.Windows.Forms.Label lblFichasAnti;
    }
}

