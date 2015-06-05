namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.txtScoreA = new System.Windows.Forms.TextBox();
            this.txtScoreB = new System.Windows.Forms.TextBox();
            this.cbInCourtA = new System.Windows.Forms.ComboBox();
            this.lblInCourt = new System.Windows.Forms.Label();
            this.cbInCourtB = new System.Windows.Forms.ComboBox();
            this.lblAtBench = new System.Windows.Forms.Label();
            this.cbAtBenchA = new System.Windows.Forms.ComboBox();
            this.cbAtBenchB = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSeg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSwap2 = new System.Windows.Forms.Button();
            this.btnSwap1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBallA = new System.Windows.Forms.RadioButton();
            this.rbBallB = new System.Windows.Forms.RadioButton();
            this.btnSubs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFalta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMB = new System.Windows.Forms.Button();
            this.btnMA = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnEsq = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tiros = new System.Windows.Forms.ComboBox();
            this.pases = new System.Windows.Forms.ComboBox();
            this.btnDespeje = new System.Windows.Forms.Button();
            this.btnEjec1 = new System.Windows.Forms.Button();
            this.btnEjec2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPen = new System.Windows.Forms.Button();
            this.btnAdel = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.btnIni = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typingTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(579, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.Enabled = false;
            this.lblTeamA.Location = new System.Drawing.Point(95, 57);
            this.lblTeamA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(53, 17);
            this.lblTeamA.TabIndex = 1;
            this.lblTeamA.Text = "TeamA";
            this.lblTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.Enabled = false;
            this.lblTeamB.Location = new System.Drawing.Point(425, 57);
            this.lblTeamB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(53, 17);
            this.lblTeamB.TabIndex = 2;
            this.lblTeamB.Text = "TeamB";
            this.lblTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScoreA
            // 
            this.txtScoreA.Enabled = false;
            this.txtScoreA.Location = new System.Drawing.Point(99, 90);
            this.txtScoreA.Margin = new System.Windows.Forms.Padding(4);
            this.txtScoreA.Name = "txtScoreA";
            this.txtScoreA.ReadOnly = true;
            this.txtScoreA.Size = new System.Drawing.Size(49, 22);
            this.txtScoreA.TabIndex = 3;
            this.txtScoreA.Text = "0";
            this.txtScoreA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScoreB
            // 
            this.txtScoreB.Enabled = false;
            this.txtScoreB.Location = new System.Drawing.Point(429, 90);
            this.txtScoreB.Margin = new System.Windows.Forms.Padding(4);
            this.txtScoreB.Name = "txtScoreB";
            this.txtScoreB.ReadOnly = true;
            this.txtScoreB.Size = new System.Drawing.Size(49, 22);
            this.txtScoreB.TabIndex = 4;
            this.txtScoreB.Text = "0";
            this.txtScoreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbInCourtA
            // 
            this.cbInCourtA.Enabled = false;
            this.cbInCourtA.FormattingEnabled = true;
            this.cbInCourtA.Location = new System.Drawing.Point(43, 155);
            this.cbInCourtA.Margin = new System.Windows.Forms.Padding(4);
            this.cbInCourtA.Name = "cbInCourtA";
            this.cbInCourtA.Size = new System.Drawing.Size(160, 24);
            this.cbInCourtA.TabIndex = 5;
            this.cbInCourtA.SelectedIndexChanged += new System.EventHandler(this.cbInCourtA_SelectedIndexChanged);
            // 
            // lblInCourt
            // 
            this.lblInCourt.AutoSize = true;
            this.lblInCourt.Enabled = false;
            this.lblInCourt.Location = new System.Drawing.Point(252, 159);
            this.lblInCourt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInCourt.Name = "lblInCourt";
            this.lblInCourt.Size = new System.Drawing.Size(77, 17);
            this.lblInCourt.TabIndex = 6;
            this.lblInCourt.Text = "En Cancha";
            // 
            // cbInCourtB
            // 
            this.cbInCourtB.Enabled = false;
            this.cbInCourtB.FormattingEnabled = true;
            this.cbInCourtB.Location = new System.Drawing.Point(372, 155);
            this.cbInCourtB.Margin = new System.Windows.Forms.Padding(4);
            this.cbInCourtB.Name = "cbInCourtB";
            this.cbInCourtB.Size = new System.Drawing.Size(160, 24);
            this.cbInCourtB.TabIndex = 7;
            this.cbInCourtB.SelectedIndexChanged += new System.EventHandler(this.cbInCourtB_SelectedIndexChanged);
            // 
            // lblAtBench
            // 
            this.lblAtBench.AutoSize = true;
            this.lblAtBench.Enabled = false;
            this.lblAtBench.Location = new System.Drawing.Point(251, 225);
            this.lblAtBench.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtBench.Name = "lblAtBench";
            this.lblAtBench.Size = new System.Drawing.Size(69, 17);
            this.lblAtBench.TabIndex = 8;
            this.lblAtBench.Text = "En Banca";
            // 
            // cbAtBenchA
            // 
            this.cbAtBenchA.Enabled = false;
            this.cbAtBenchA.FormattingEnabled = true;
            this.cbAtBenchA.Location = new System.Drawing.Point(43, 217);
            this.cbAtBenchA.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtBenchA.Name = "cbAtBenchA";
            this.cbAtBenchA.Size = new System.Drawing.Size(160, 24);
            this.cbAtBenchA.TabIndex = 9;
            this.cbAtBenchA.SelectedIndexChanged += new System.EventHandler(this.cbAtBenchA_SelectedIndexChanged);
            // 
            // cbAtBenchB
            // 
            this.cbAtBenchB.Enabled = false;
            this.cbAtBenchB.FormattingEnabled = true;
            this.cbAtBenchB.Location = new System.Drawing.Point(372, 217);
            this.cbAtBenchB.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtBenchB.Name = "cbAtBenchB";
            this.cbAtBenchB.Size = new System.Drawing.Size(160, 24);
            this.cbAtBenchB.TabIndex = 10;
            this.cbAtBenchB.SelectedIndexChanged += new System.EventHandler(this.cbAtBenchB_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Enabled = false;
            this.lblMin.Location = new System.Drawing.Point(257, 57);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 17);
            this.lblMin.TabIndex = 11;
            this.lblMin.Text = "00";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeg
            // 
            this.lblSeg.AutoSize = true;
            this.lblSeg.Enabled = false;
            this.lblSeg.Location = new System.Drawing.Point(293, 57);
            this.lblSeg.Name = "lblSeg";
            this.lblSeg.Size = new System.Drawing.Size(24, 17);
            this.lblSeg.TabIndex = 12;
            this.lblSeg.Text = "00";
            this.lblSeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(281, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(219, 82);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 37);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Saque de Salida";
            this.toolTip1.SetToolTip(this.btnStart, "Saque de salida para iniciar.");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSwap2
            // 
            this.btnSwap2.Enabled = false;
            this.btnSwap2.Location = new System.Drawing.Point(372, 250);
            this.btnSwap2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwap2.Name = "btnSwap2";
            this.btnSwap2.Size = new System.Drawing.Size(161, 33);
            this.btnSwap2.TabIndex = 15;
            this.btnSwap2.Text = "Mandar al Campo";
            this.toolTip1.SetToolTip(this.btnSwap2, "Mandar al jugador en banca al terreno de juego.");
            this.btnSwap2.UseVisualStyleBackColor = true;
            this.btnSwap2.Visible = false;
            this.btnSwap2.Click += new System.EventHandler(this.btnSwap2_Click);
            // 
            // btnSwap1
            // 
            this.btnSwap1.Enabled = false;
            this.btnSwap1.Location = new System.Drawing.Point(43, 250);
            this.btnSwap1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwap1.Name = "btnSwap1";
            this.btnSwap1.Size = new System.Drawing.Size(161, 33);
            this.btnSwap1.TabIndex = 16;
            this.btnSwap1.Text = "Mandar al Campo";
            this.toolTip1.SetToolTip(this.btnSwap1, "Mandar al jugador en banca al terreno de juego.");
            this.btnSwap1.UseVisualStyleBackColor = true;
            this.btnSwap1.Visible = false;
            this.btnSwap1.Click += new System.EventHandler(this.btnSwap1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(260, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Anotar ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbBallA
            // 
            this.rbBallA.AutoSize = true;
            this.rbBallA.Enabled = false;
            this.rbBallA.Location = new System.Drawing.Point(187, 305);
            this.rbBallA.Margin = new System.Windows.Forms.Padding(4);
            this.rbBallA.Name = "rbBallA";
            this.rbBallA.Size = new System.Drawing.Size(17, 16);
            this.rbBallA.TabIndex = 18;
            this.toolTip1.SetToolTip(this.rbBallA, "Anotar al Equipo 1");
            this.rbBallA.UseVisualStyleBackColor = true;
            this.rbBallA.CheckedChanged += new System.EventHandler(this.rbBallA_CheckedChanged);
            // 
            // rbBallB
            // 
            this.rbBallB.AutoSize = true;
            this.rbBallB.Enabled = false;
            this.rbBallB.Location = new System.Drawing.Point(372, 305);
            this.rbBallB.Margin = new System.Windows.Forms.Padding(4);
            this.rbBallB.Name = "rbBallB";
            this.rbBallB.Size = new System.Drawing.Size(17, 16);
            this.rbBallB.TabIndex = 19;
            this.toolTip1.SetToolTip(this.rbBallB, "Anotar al Equipo 2");
            this.rbBallB.UseVisualStyleBackColor = true;
            this.rbBallB.CheckedChanged += new System.EventHandler(this.rbBallB_CheckedChanged);
            // 
            // btnSubs
            // 
            this.btnSubs.Enabled = false;
            this.btnSubs.Location = new System.Drawing.Point(239, 411);
            this.btnSubs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubs.Name = "btnSubs";
            this.btnSubs.Size = new System.Drawing.Size(97, 43);
            this.btnSubs.TabIndex = 20;
            this.btnSubs.Text = "Sustitucion";
            this.toolTip1.SetToolTip(this.btnSubs, "Sustituir Jugadores.");
            this.btnSubs.UseVisualStyleBackColor = true;
            this.btnSubs.Click += new System.EventHandler(this.btnSubs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(259, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tarjetas";
            // 
            // btnFalta
            // 
            this.btnFalta.Enabled = false;
            this.btnFalta.Location = new System.Drawing.Point(239, 641);
            this.btnFalta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFalta.Name = "btnFalta";
            this.btnFalta.Size = new System.Drawing.Size(97, 33);
            this.btnFalta.TabIndex = 24;
            this.btnFalta.Text = "Falta";
            this.toolTip1.SetToolTip(this.btnFalta, "Anotar una falta.");
            this.btnFalta.UseVisualStyleBackColor = true;
            this.btnFalta.Click += new System.EventHandler(this.btnFalta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(247, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tiros Libres";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(216, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "D";
            this.toolTip1.SetToolTip(this.button1, "Anotar un tiro libre directo.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(336, 540);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 31);
            this.button2.TabIndex = 27;
            this.button2.Text = "I";
            this.toolTip1.SetToolTip(this.button2, "Anotar un tiro libre indirecto.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMB
            // 
            this.btnMB.Enabled = false;
            this.btnMB.Location = new System.Drawing.Point(428, 436);
            this.btnMB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMB.Name = "btnMB";
            this.btnMB.Size = new System.Drawing.Size(76, 44);
            this.btnMB.TabIndex = 28;
            this.btnMB.Text = "Saque de Meta";
            this.toolTip1.SetToolTip(this.btnMB, "Anotar un saque de meta.");
            this.btnMB.UseVisualStyleBackColor = true;
            this.btnMB.Click += new System.EventHandler(this.btnMB_Click);
            // 
            // btnMA
            // 
            this.btnMA.Enabled = false;
            this.btnMA.Location = new System.Drawing.Point(72, 436);
            this.btnMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMA.Name = "btnMA";
            this.btnMA.Size = new System.Drawing.Size(76, 44);
            this.btnMA.TabIndex = 29;
            this.btnMA.Text = "Saque de Meta";
            this.toolTip1.SetToolTip(this.btnMA, "Anotar un saque de meta.");
            this.btnMA.UseVisualStyleBackColor = true;
            this.btnMA.Click += new System.EventHandler(this.btnMA_Click);
            // 
            // btnBan
            // 
            this.btnBan.Enabled = false;
            this.btnBan.Location = new System.Drawing.Point(423, 537);
            this.btnBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(81, 46);
            this.btnBan.TabIndex = 30;
            this.btnBan.Text = "Saque de Banda";
            this.toolTip1.SetToolTip(this.btnBan, "Anotar un saque de banda.");
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnEsq
            // 
            this.btnEsq.Enabled = false;
            this.btnEsq.Location = new System.Drawing.Point(72, 537);
            this.btnEsq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEsq.Name = "btnEsq";
            this.btnEsq.Size = new System.Drawing.Size(81, 46);
            this.btnEsq.TabIndex = 31;
            this.btnEsq.Text = "Saque de Esquina";
            this.toolTip1.SetToolTip(this.btnEsq, "Anotar un saque de esquina.");
            this.btnEsq.UseVisualStyleBackColor = true;
            this.btnEsq.Click += new System.EventHandler(this.btnEsq_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(45, 650);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Lanzamiento a Porteria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(437, 650);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Pase";
            // 
            // tiros
            // 
            this.tiros.Enabled = false;
            this.tiros.FormattingEnabled = true;
            this.tiros.Items.AddRange(new object[] {
            "Tiro frontal",
            "Tiro de cabeza",
            "Tiro tipo sombrero",
            "Tiro a bote pronto",
            "Tiro tipo tijera",
            "Tiro tipo chilena",
            "Tiro tipo volea"});
            this.tiros.Location = new System.Drawing.Point(48, 688);
            this.tiros.Margin = new System.Windows.Forms.Padding(4);
            this.tiros.Name = "tiros";
            this.tiros.Size = new System.Drawing.Size(151, 24);
            this.tiros.TabIndex = 33;
            this.tiros.SelectedIndexChanged += new System.EventHandler(this.tiros_SelectedIndexChanged);
            // 
            // pases
            // 
            this.pases.Enabled = false;
            this.pases.FormattingEnabled = true;
            this.pases.Items.AddRange(new object[] {
            "Pase Corto",
            "Pase a Media Distancia",
            "Pase Largo",
            "Pase de Cabeza",
            "Pase de Pared",
            "Pase a un Espacio",
            "Pase de Tacón",
            "Pase a Centro"});
            this.pases.Location = new System.Drawing.Point(375, 688);
            this.pases.Margin = new System.Windows.Forms.Padding(4);
            this.pases.Name = "pases";
            this.pases.Size = new System.Drawing.Size(160, 24);
            this.pases.TabIndex = 34;
            this.pases.SelectedIndexChanged += new System.EventHandler(this.pases_SelectedIndexChanged);
            // 
            // btnDespeje
            // 
            this.btnDespeje.Enabled = false;
            this.btnDespeje.Location = new System.Drawing.Point(239, 688);
            this.btnDespeje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDespeje.Name = "btnDespeje";
            this.btnDespeje.Size = new System.Drawing.Size(97, 34);
            this.btnDespeje.TabIndex = 35;
            this.btnDespeje.Text = "Despeje";
            this.toolTip1.SetToolTip(this.btnDespeje, "Anotar un despeje.");
            this.btnDespeje.UseVisualStyleBackColor = true;
            this.btnDespeje.Click += new System.EventHandler(this.btnDespeje_Click);
            // 
            // btnEjec1
            // 
            this.btnEjec1.Enabled = false;
            this.btnEjec1.Location = new System.Drawing.Point(79, 719);
            this.btnEjec1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEjec1.Name = "btnEjec1";
            this.btnEjec1.Size = new System.Drawing.Size(75, 33);
            this.btnEjec1.TabIndex = 36;
            this.btnEjec1.Text = "Ejecutar";
            this.toolTip1.SetToolTip(this.btnEjec1, "Anotar un lanzamiento al equipo seleccionado.");
            this.btnEjec1.UseVisualStyleBackColor = true;
            this.btnEjec1.Click += new System.EventHandler(this.btnEjec1_Click);
            // 
            // btnEjec2
            // 
            this.btnEjec2.Enabled = false;
            this.btnEjec2.Location = new System.Drawing.Point(424, 719);
            this.btnEjec2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEjec2.Name = "btnEjec2";
            this.btnEjec2.Size = new System.Drawing.Size(75, 33);
            this.btnEjec2.TabIndex = 37;
            this.btnEjec2.Text = "Ejecutar";
            this.toolTip1.SetToolTip(this.btnEjec2, "Anotar un pase al equipo seleccionado.");
            this.btnEjec2.UseVisualStyleBackColor = true;
            this.btnEjec2.Click += new System.EventHandler(this.btnEjec2_Click);
            // 
            // btnPen
            // 
            this.btnPen.Enabled = false;
            this.btnPen.Location = new System.Drawing.Point(237, 593);
            this.btnPen.Margin = new System.Windows.Forms.Padding(4);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(97, 28);
            this.btnPen.TabIndex = 40;
            this.btnPen.Text = "Penal";
            this.toolTip1.SetToolTip(this.btnPen, "Anotar un Tiro Penal");
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnAdel
            // 
            this.btnAdel.Enabled = false;
            this.btnAdel.Location = new System.Drawing.Point(239, 743);
            this.btnAdel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdel.Name = "btnAdel";
            this.btnAdel.Size = new System.Drawing.Size(97, 54);
            this.btnAdel.TabIndex = 41;
            this.btnAdel.Text = "Pos. Adelantada";
            this.toolTip1.SetToolTip(this.btnAdel, "Anotar posicion adelantada.");
            this.btnAdel.UseVisualStyleBackColor = true;
            this.btnAdel.Click += new System.EventHandler(this.btnAdel_Click);
            // 
            // clean
            // 
            this.clean.Enabled = false;
            this.clean.Location = new System.Drawing.Point(239, 342);
            this.clean.Margin = new System.Windows.Forms.Padding(4);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(97, 28);
            this.clean.TabIndex = 39;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // btnIni
            // 
            this.btnIni.Image = global::WindowsFormsApplication1.Properties.Resources._1409377594_126585;
            this.btnIni.Location = new System.Drawing.Point(0, 794);
            this.btnIni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(51, 39);
            this.btnIni.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnIni, "Volver al Menú de Inicio\r\n.");
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // btnRed
            // 
            this.btnRed.Enabled = false;
            this.btnRed.Image = global::WindowsFormsApplication1.Properties.Resources._1409373916_131641;
            this.btnRed.Location = new System.Drawing.Point(216, 479);
            this.btnRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(24, 39);
            this.btnRed.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnRed, "Tarjeta Roja.");
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Enabled = false;
            this.btnYellow.Image = global::WindowsFormsApplication1.Properties.Resources._1409374071_34207;
            this.btnYellow.Location = new System.Drawing.Point(336, 479);
            this.btnYellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(24, 39);
            this.btnYellow.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnYellow, "Tarjeta Amarilla.");
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.CheckOnClick = true;
            this.fileToolStripMenuItem.DoubleClickEnabled = true;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1409535852_274895;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.fileToolStripMenuItem.Text = "Opciones";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DoubleClickEnabled = true;
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typingTemplateToolStripMenuItem,
            this.defaultTemplateToolStripMenuItem});
            this.newGameToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1408999137_48755;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.newGameToolStripMenuItem.Text = "Nuevo Juego";
            // 
            // typingTemplateToolStripMenuItem
            // 
            this.typingTemplateToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1409535982_127813;
            this.typingTemplateToolStripMenuItem.Name = "typingTemplateToolStripMenuItem";
            this.typingTemplateToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.typingTemplateToolStripMenuItem.Text = "Digitar Plantilla";
            this.typingTemplateToolStripMenuItem.Click += new System.EventHandler(this.typingTemplateToolStripMenuItem_Click);
            // 
            // defaultTemplateToolStripMenuItem
            // 
            this.defaultTemplateToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1409536045_7634;
            this.defaultTemplateToolStripMenuItem.Name = "defaultTemplateToolStripMenuItem";
            this.defaultTemplateToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.defaultTemplateToolStripMenuItem.Text = "Plantilla Predeterminada";
            this.defaultTemplateToolStripMenuItem.Click += new System.EventHandler(this.defaultTemplateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1408999482_28363;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._1409536127_211674;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(579, 834);
            this.Controls.Add(this.btnAdel);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.btnIni);
            this.Controls.Add(this.btnEjec2);
            this.Controls.Add(this.btnEjec1);
            this.Controls.Add(this.btnDespeje);
            this.Controls.Add(this.pases);
            this.Controls.Add(this.tiros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEsq);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnMA);
            this.Controls.Add(this.btnMB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFalta);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubs);
            this.Controls.Add(this.rbBallB);
            this.Controls.Add(this.rbBallA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSwap1);
            this.Controls.Add(this.btnSwap2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeg);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.cbAtBenchB);
            this.Controls.Add(this.cbAtBenchA);
            this.Controls.Add(this.lblAtBench);
            this.Controls.Add(this.cbInCourtB);
            this.Controls.Add(this.lblInCourt);
            this.Controls.Add(this.cbInCourtA);
            this.Controls.Add(this.txtScoreB);
            this.Controls.Add(this.txtScoreA);
            this.Controls.Add(this.lblTeamB);
            this.Controls.Add(this.lblTeamA);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Juego";
            this.toolTip1.SetToolTip(this, "Volver al Menú de Inicio");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Label lblTeamA;
        private System.Windows.Forms.Label lblTeamB;
        private System.Windows.Forms.TextBox txtScoreA;
        private System.Windows.Forms.TextBox txtScoreB;
        private System.Windows.Forms.ComboBox cbInCourtA;
        private System.Windows.Forms.Label lblInCourt;
        private System.Windows.Forms.ComboBox cbInCourtB;
        private System.Windows.Forms.Label lblAtBench;
        private System.Windows.Forms.ComboBox cbAtBenchA;
        private System.Windows.Forms.ComboBox cbAtBenchB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSwap2;
        private System.Windows.Forms.Button btnSwap1;
        private System.Windows.Forms.ToolStripMenuItem typingTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultTemplateToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbBallA;
        private System.Windows.Forms.RadioButton rbBallB;
        private System.Windows.Forms.Button btnSubs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnFalta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMB;
        private System.Windows.Forms.Button btnMA;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnEsq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tiros;
        private System.Windows.Forms.ComboBox pases;
        private System.Windows.Forms.Button btnDespeje;
        private System.Windows.Forms.Button btnEjec1;
        private System.Windows.Forms.Button btnEjec2;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnAdel;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

