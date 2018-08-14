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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblValorSB = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblFichaSB5 = new System.Windows.Forms.Label();
            this.lblFichaSB4 = new System.Windows.Forms.Label();
            this.lblFichaSB3 = new System.Windows.Forms.Label();
            this.lblFichaSB2 = new System.Windows.Forms.Label();
            this.lblFichaSB1 = new System.Windows.Forms.Label();
            this.lblSB = new System.Windows.Forms.Label();
            this.lblBB = new System.Windows.Forms.Label();
            this.lblFichaBB5 = new System.Windows.Forms.Label();
            this.lblFichaBB4 = new System.Windows.Forms.Label();
            this.lblFichaBB3 = new System.Windows.Forms.Label();
            this.lblFichaBB2 = new System.Windows.Forms.Label();
            this.lblFichaBB1 = new System.Windows.Forms.Label();
            this.lblAnti = new System.Windows.Forms.Label();
            this.lblAnti5 = new System.Windows.Forms.Label();
            this.lblAnti4 = new System.Windows.Forms.Label();
            this.lblAnti3 = new System.Windows.Forms.Label();
            this.lblAnti2 = new System.Windows.Forms.Label();
            this.lblAnti1 = new System.Windows.Forms.Label();
            this.lblValorBB = new System.Windows.Forms.Label();
            this.lblValorAnti = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblProx = new System.Windows.Forms.Label();
            this.lblProximoBlind = new System.Windows.Forms.Label();
            this.lbl3BB = new System.Windows.Forms.Label();
            this.lblValor3xBB = new System.Windows.Forms.Label();
            this.lblValor10xBB = new System.Windows.Forms.Label();
            this.lbl10BB = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Chartreuse;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(209, 383);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(43, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = ">";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRelogio.Location = new System.Drawing.Point(-23, 125);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(477, 181);
            this.lblRelogio.TabIndex = 1;
            this.lblRelogio.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblValorSB
            // 
            this.lblValorSB.BackColor = System.Drawing.Color.Transparent;
            this.lblValorSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSB.Location = new System.Drawing.Point(55, 48);
            this.lblValorSB.Name = "lblValorSB";
            this.lblValorSB.Size = new System.Drawing.Size(289, 119);
            this.lblValorSB.TabIndex = 2;
            this.lblValorSB.Text = "Blind";
            this.lblValorSB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(258, 383);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(43, 33);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Enabled = false;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLast.Location = new System.Drawing.Point(111, 383);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(43, 33);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "<<";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Location = new System.Drawing.Point(160, 383);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(43, 33);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "| |";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblFichaSB5
            // 
            this.lblFichaSB5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaSB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaSB5.Location = new System.Drawing.Point(271, 127);
            this.lblFichaSB5.Name = "lblFichaSB5";
            this.lblFichaSB5.Size = new System.Drawing.Size(40, 40);
            this.lblFichaSB5.TabIndex = 17;
            this.lblFichaSB5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaSB5.Visible = false;
            // 
            // lblFichaSB4
            // 
            this.lblFichaSB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaSB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaSB4.Location = new System.Drawing.Point(248, 127);
            this.lblFichaSB4.Name = "lblFichaSB4";
            this.lblFichaSB4.Size = new System.Drawing.Size(40, 40);
            this.lblFichaSB4.TabIndex = 16;
            this.lblFichaSB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaSB4.Visible = false;
            // 
            // lblFichaSB3
            // 
            this.lblFichaSB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaSB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaSB3.Location = new System.Drawing.Point(225, 127);
            this.lblFichaSB3.Name = "lblFichaSB3";
            this.lblFichaSB3.Size = new System.Drawing.Size(40, 40);
            this.lblFichaSB3.TabIndex = 15;
            this.lblFichaSB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaSB3.Visible = false;
            // 
            // lblFichaSB2
            // 
            this.lblFichaSB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaSB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaSB2.Location = new System.Drawing.Point(202, 127);
            this.lblFichaSB2.Name = "lblFichaSB2";
            this.lblFichaSB2.Size = new System.Drawing.Size(40, 40);
            this.lblFichaSB2.TabIndex = 14;
            this.lblFichaSB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaSB2.Visible = false;
            // 
            // lblFichaSB1
            // 
            this.lblFichaSB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaSB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaSB1.Location = new System.Drawing.Point(179, 127);
            this.lblFichaSB1.Name = "lblFichaSB1";
            this.lblFichaSB1.Size = new System.Drawing.Size(40, 40);
            this.lblFichaSB1.TabIndex = 13;
            this.lblFichaSB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaSB1.Visible = false;
            // 
            // lblSB
            // 
            this.lblSB.AutoSize = true;
            this.lblSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSB.Location = new System.Drawing.Point(243, 19);
            this.lblSB.Name = "lblSB";
            this.lblSB.Size = new System.Drawing.Size(45, 29);
            this.lblSB.TabIndex = 19;
            this.lblSB.Text = "SB";
            // 
            // lblBB
            // 
            this.lblBB.AutoSize = true;
            this.lblBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBB.Location = new System.Drawing.Point(45, 17);
            this.lblBB.Name = "lblBB";
            this.lblBB.Size = new System.Drawing.Size(45, 29);
            this.lblBB.TabIndex = 25;
            this.lblBB.Text = "BB";
            // 
            // lblFichaBB5
            // 
            this.lblFichaBB5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaBB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaBB5.Location = new System.Drawing.Point(132, 125);
            this.lblFichaBB5.Name = "lblFichaBB5";
            this.lblFichaBB5.Size = new System.Drawing.Size(40, 40);
            this.lblFichaBB5.TabIndex = 24;
            this.lblFichaBB5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaBB5.Visible = false;
            // 
            // lblFichaBB4
            // 
            this.lblFichaBB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaBB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaBB4.Location = new System.Drawing.Point(109, 125);
            this.lblFichaBB4.Name = "lblFichaBB4";
            this.lblFichaBB4.Size = new System.Drawing.Size(40, 40);
            this.lblFichaBB4.TabIndex = 23;
            this.lblFichaBB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaBB4.Visible = false;
            // 
            // lblFichaBB3
            // 
            this.lblFichaBB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaBB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaBB3.Location = new System.Drawing.Point(86, 125);
            this.lblFichaBB3.Name = "lblFichaBB3";
            this.lblFichaBB3.Size = new System.Drawing.Size(40, 40);
            this.lblFichaBB3.TabIndex = 22;
            this.lblFichaBB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaBB3.Visible = false;
            // 
            // lblFichaBB2
            // 
            this.lblFichaBB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaBB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaBB2.Location = new System.Drawing.Point(63, 125);
            this.lblFichaBB2.Name = "lblFichaBB2";
            this.lblFichaBB2.Size = new System.Drawing.Size(40, 40);
            this.lblFichaBB2.TabIndex = 21;
            this.lblFichaBB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaBB2.Visible = false;
            // 
            // lblFichaBB1
            // 
            this.lblFichaBB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFichaBB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaBB1.Location = new System.Drawing.Point(41, 125);
            this.lblFichaBB1.Name = "lblFichaBB1";
            this.lblFichaBB1.Size = new System.Drawing.Size(40, 40);
            this.lblFichaBB1.TabIndex = 20;
            this.lblFichaBB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFichaBB1.Visible = false;
            // 
            // lblAnti
            // 
            this.lblAnti.AutoSize = true;
            this.lblAnti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnti.Location = new System.Drawing.Point(179, 10);
            this.lblAnti.Name = "lblAnti";
            this.lblAnti.Size = new System.Drawing.Size(56, 25);
            this.lblAnti.TabIndex = 31;
            this.lblAnti.Text = "Ante";
            // 
            // lblAnti5
            // 
            this.lblAnti5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnti5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnti5.Location = new System.Drawing.Point(224, 94);
            this.lblAnti5.Name = "lblAnti5";
            this.lblAnti5.Size = new System.Drawing.Size(30, 30);
            this.lblAnti5.TabIndex = 30;
            this.lblAnti5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnti5.Visible = false;
            // 
            // lblAnti4
            // 
            this.lblAnti4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnti4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnti4.Location = new System.Drawing.Point(206, 94);
            this.lblAnti4.Name = "lblAnti4";
            this.lblAnti4.Size = new System.Drawing.Size(30, 30);
            this.lblAnti4.TabIndex = 29;
            this.lblAnti4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnti4.Visible = false;
            // 
            // lblAnti3
            // 
            this.lblAnti3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnti3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnti3.Location = new System.Drawing.Point(188, 94);
            this.lblAnti3.Name = "lblAnti3";
            this.lblAnti3.Size = new System.Drawing.Size(30, 30);
            this.lblAnti3.TabIndex = 28;
            this.lblAnti3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnti3.Visible = false;
            // 
            // lblAnti2
            // 
            this.lblAnti2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnti2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnti2.Location = new System.Drawing.Point(170, 94);
            this.lblAnti2.Name = "lblAnti2";
            this.lblAnti2.Size = new System.Drawing.Size(30, 30);
            this.lblAnti2.TabIndex = 27;
            this.lblAnti2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnti2.Visible = false;
            // 
            // lblAnti1
            // 
            this.lblAnti1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnti1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnti1.Location = new System.Drawing.Point(152, 94);
            this.lblAnti1.Name = "lblAnti1";
            this.lblAnti1.Size = new System.Drawing.Size(30, 30);
            this.lblAnti1.TabIndex = 26;
            this.lblAnti1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnti1.Visible = false;
            // 
            // lblValorBB
            // 
            this.lblValorBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBB.Location = new System.Drawing.Point(-8, 46);
            this.lblValorBB.Name = "lblValorBB";
            this.lblValorBB.Size = new System.Drawing.Size(297, 119);
            this.lblValorBB.TabIndex = 32;
            this.lblValorBB.Text = "Blind";
            this.lblValorBB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorAnti
            // 
            this.lblValorAnti.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAnti.Location = new System.Drawing.Point(102, 35);
            this.lblValorAnti.Name = "lblValorAnti";
            this.lblValorAnti.Size = new System.Drawing.Size(200, 90);
            this.lblValorAnti.TabIndex = 33;
            this.lblValorAnti.Text = "Blind";
            this.lblValorAnti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMensagem.Location = new System.Drawing.Point(12, 307);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(1031, 59);
            this.lblMensagem.TabIndex = 35;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProx
            // 
            this.lblProx.AutoSize = true;
            this.lblProx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProx.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProx.Location = new System.Drawing.Point(101, 180);
            this.lblProx.Name = "lblProx";
            this.lblProx.Size = new System.Drawing.Size(90, 25);
            this.lblProx.TabIndex = 34;
            this.lblProx.Text = "Proximo";
            // 
            // lblProximoBlind
            // 
            this.lblProximoBlind.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximoBlind.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProximoBlind.Location = new System.Drawing.Point(0, 214);
            this.lblProximoBlind.Name = "lblProximoBlind";
            this.lblProximoBlind.Size = new System.Drawing.Size(292, 101);
            this.lblProximoBlind.TabIndex = 36;
            this.lblProximoBlind.Text = "ProximoBlind";
            this.lblProximoBlind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl3BB
            // 
            this.lbl3BB.AutoSize = true;
            this.lbl3BB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3BB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl3BB.Location = new System.Drawing.Point(82, 182);
            this.lbl3BB.Name = "lbl3BB";
            this.lbl3BB.Size = new System.Drawing.Size(58, 25);
            this.lbl3BB.TabIndex = 37;
            this.lbl3BB.Text = "3 BB";
            // 
            // lblValor3xBB
            // 
            this.lblValor3xBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor3xBB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblValor3xBB.Location = new System.Drawing.Point(48, 207);
            this.lblValor3xBB.Name = "lblValor3xBB";
            this.lblValor3xBB.Size = new System.Drawing.Size(134, 40);
            this.lblValor3xBB.TabIndex = 38;
            this.lblValor3xBB.Text = "3xBB";
            this.lblValor3xBB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblValor10xBB
            // 
            this.lblValor10xBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor10xBB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblValor10xBB.Location = new System.Drawing.Point(174, 207);
            this.lblValor10xBB.Name = "lblValor10xBB";
            this.lblValor10xBB.Size = new System.Drawing.Size(138, 40);
            this.lblValor10xBB.TabIndex = 40;
            this.lblValor10xBB.Text = "10xBB";
            this.lblValor10xBB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl10BB
            // 
            this.lbl10BB.AutoSize = true;
            this.lbl10BB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10BB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl10BB.Location = new System.Drawing.Point(207, 182);
            this.lbl10BB.Name = "lbl10BB";
            this.lbl10BB.Size = new System.Drawing.Size(70, 25);
            this.lbl10BB.TabIndex = 39;
            this.lbl10BB.Text = "10 BB";
            // 
            // lblNumero
            // 
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNumero.Location = new System.Drawing.Point(13, 43);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(101, 60);
            this.lblNumero.TabIndex = 41;
            this.lblNumero.Text = "NN";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nivel";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(203, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 88);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.lblNumero);
            this.panel2.Controls.Add(this.lblValorSB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblFichaSB1);
            this.panel2.Controls.Add(this.lblFichaSB2);
            this.panel2.Controls.Add(this.lblFichaSB3);
            this.panel2.Controls.Add(this.lblValor10xBB);
            this.panel2.Controls.Add(this.lblFichaSB4);
            this.panel2.Controls.Add(this.lbl10BB);
            this.panel2.Controls.Add(this.lblFichaSB5);
            this.panel2.Controls.Add(this.lblValor3xBB);
            this.panel2.Controls.Add(this.lblSB);
            this.panel2.Controls.Add(this.lbl3BB);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 247);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.lblRelogio);
            this.panel3.Controls.Add(this.lblValorAnti);
            this.panel3.Controls.Add(this.lblAnti1);
            this.panel3.Controls.Add(this.lblAnti2);
            this.panel3.Controls.Add(this.lblAnti3);
            this.panel3.Controls.Add(this.lblAnti4);
            this.panel3.Controls.Add(this.lblAnti5);
            this.panel3.Controls.Add(this.lblAnti);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnLast);
            this.panel3.Location = new System.Drawing.Point(358, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 419);
            this.panel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.lblProximoBlind);
            this.panel4.Controls.Add(this.lblValorBB);
            this.panel4.Controls.Add(this.lblFichaBB1);
            this.panel4.Controls.Add(this.lblFichaBB2);
            this.panel4.Controls.Add(this.lblFichaBB3);
            this.panel4.Controls.Add(this.lblProx);
            this.panel4.Controls.Add(this.lblFichaBB4);
            this.panel4.Controls.Add(this.lblBB);
            this.panel4.Controls.Add(this.lblFichaBB5);
            this.panel4.Location = new System.Drawing.Point(824, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 315);
            this.panel4.TabIndex = 47;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1125, 426);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relogio Blinds TQSOP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblValorSB;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblFichaSB5;
        private System.Windows.Forms.Label lblFichaSB4;
        private System.Windows.Forms.Label lblFichaSB3;
        private System.Windows.Forms.Label lblFichaSB2;
        private System.Windows.Forms.Label lblFichaSB1;
        private System.Windows.Forms.Label lblSB;
        private System.Windows.Forms.Label lblBB;
        private System.Windows.Forms.Label lblFichaBB5;
        private System.Windows.Forms.Label lblFichaBB4;
        private System.Windows.Forms.Label lblFichaBB3;
        private System.Windows.Forms.Label lblFichaBB2;
        private System.Windows.Forms.Label lblFichaBB1;
        private System.Windows.Forms.Label lblAnti;
        private System.Windows.Forms.Label lblAnti5;
        private System.Windows.Forms.Label lblAnti4;
        private System.Windows.Forms.Label lblAnti3;
        private System.Windows.Forms.Label lblAnti2;
        private System.Windows.Forms.Label lblAnti1;
        private System.Windows.Forms.Label lblValorBB;
        private System.Windows.Forms.Label lblValorAnti;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblProx;
        private System.Windows.Forms.Label lblProximoBlind;
        private System.Windows.Forms.Label lbl3BB;
        private System.Windows.Forms.Label lblValor3xBB;
        private System.Windows.Forms.Label lblValor10xBB;
        private System.Windows.Forms.Label lbl10BB;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

