﻿namespace WindowsFormsApplication1
{
    partial class score
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JugadorT1 = new System.Windows.Forms.ComboBox();
            this.JugadorT2 = new System.Windows.Forms.ComboBox();
            this.JugadorT1_2 = new System.Windows.Forms.ComboBox();
            this.JugadorT2_2 = new System.Windows.Forms.ComboBox();
            this.Team1 = new System.Windows.Forms.RadioButton();
            this.Team2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tiros = new System.Windows.Forms.ComboBox();
            this.pases = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saques = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accion = new System.Windows.Forms.Button();
            this.jugadas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.faltas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSeg = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtScoreB = new System.Windows.Forms.TextBox();
            this.txtScoreA = new System.Windows.Forms.TextBox();
            this.txtTeamB = new System.Windows.Forms.Label();
            this.txtTeamA = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(857, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Team2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // JugadorT1
            // 
            this.JugadorT1.Enabled = false;
            this.JugadorT1.FormattingEnabled = true;
            this.JugadorT1.Items.AddRange(new object[] {
            "Portero",
            "centre back_L",
            "centre back_R",
            "full back_L",
            "full back_R",
            "DM",
            "SM_L",
            "SM_R",
            "MO",
            "CL",
            "CR",
            "-------",
            "banca1",
            "banca2",
            "banca3"});
            this.JugadorT1.Location = new System.Drawing.Point(-4, 114);
            this.JugadorT1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JugadorT1.Name = "JugadorT1";
            this.JugadorT1.Size = new System.Drawing.Size(160, 24);
            this.JugadorT1.TabIndex = 21;
            this.JugadorT1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // JugadorT2
            // 
            this.JugadorT2.Enabled = false;
            this.JugadorT2.FormattingEnabled = true;
            this.JugadorT2.Items.AddRange(new object[] {
            "Portero",
            "centre back_L",
            "centre back_R",
            "full back_L",
            "full back_R",
            "DM",
            "SM_L",
            "SM_R",
            "MO",
            "CL",
            "CR",
            "-------",
            "banca1",
            "banca2",
            "banca3"});
            this.JugadorT2.Location = new System.Drawing.Point(812, 114);
            this.JugadorT2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JugadorT2.Name = "JugadorT2";
            this.JugadorT2.Size = new System.Drawing.Size(160, 24);
            this.JugadorT2.TabIndex = 22;
            this.JugadorT2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // JugadorT1_2
            // 
            this.JugadorT1_2.Enabled = false;
            this.JugadorT1_2.FormattingEnabled = true;
            this.JugadorT1_2.Items.AddRange(new object[] {
            "Portero",
            "centre back_L",
            "centre back_R",
            "full back_L",
            "full back_R",
            "DM",
            "SM_L",
            "SM_R",
            "MO",
            "CL",
            "CR",
            "-------",
            "banca1",
            "banca2",
            "banca3"});
            this.JugadorT1_2.Location = new System.Drawing.Point(-4, 164);
            this.JugadorT1_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JugadorT1_2.Name = "JugadorT1_2";
            this.JugadorT1_2.Size = new System.Drawing.Size(160, 24);
            this.JugadorT1_2.TabIndex = 23;
            this.JugadorT1_2.SelectedIndexChanged += new System.EventHandler(this.JugadorT1_2_SelectedIndexChanged);
            // 
            // JugadorT2_2
            // 
            this.JugadorT2_2.Enabled = false;
            this.JugadorT2_2.FormattingEnabled = true;
            this.JugadorT2_2.Items.AddRange(new object[] {
            "Portero",
            "centre back_L",
            "centre back_R",
            "full back_L",
            "full back_R",
            "DM",
            "SM_L",
            "SM_R",
            "MO",
            "CL",
            "CR",
            "-------",
            "banca1",
            "banca2",
            "banca3"});
            this.JugadorT2_2.Location = new System.Drawing.Point(812, 164);
            this.JugadorT2_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JugadorT2_2.Name = "JugadorT2_2";
            this.JugadorT2_2.Size = new System.Drawing.Size(160, 24);
            this.JugadorT2_2.TabIndex = 24;
            this.JugadorT2_2.SelectedIndexChanged += new System.EventHandler(this.JugadorT2_2_SelectedIndexChanged);
            // 
            // Team1
            // 
            this.Team1.AutoSize = true;
            this.Team1.Location = new System.Drawing.Point(8, 73);
            this.Team1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(17, 16);
            this.Team1.TabIndex = 25;
            this.Team1.UseVisualStyleBackColor = true;
            this.Team1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Team2
            // 
            this.Team2.AutoSize = true;
            this.Team2.Location = new System.Drawing.Point(831, 78);
            this.Team2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(17, 16);
            this.Team2.TabIndex = 26;
            this.Team2.TabStop = true;
            this.Team2.UseVisualStyleBackColor = true;
            this.Team2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tiros";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tiros
            // 
            this.tiros.Enabled = false;
            this.tiros.FormattingEnabled = true;
            this.tiros.Items.AddRange(new object[] {
            "Volea",
            "Saque de esquina",
            "Chilena",
            "Tijera",
            "sombrero",
            "Tiro a bote pronto",
            "Tiro raso",
            "Tiro cruzado",
            "Lanzamiento de falta",
            "Penalti",
            "frontal",
            "hacia atrás",
            "En plancha"});
            this.tiros.Location = new System.Drawing.Point(168, 244);
            this.tiros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tiros.Name = "tiros";
            this.tiros.Size = new System.Drawing.Size(160, 24);
            this.tiros.TabIndex = 28;
            this.tiros.SelectedIndexChanged += new System.EventHandler(this.tiros_SelectedIndexChanged);
            // 
            // pases
            // 
            this.pases.Enabled = false;
            this.pases.FormattingEnabled = true;
            this.pases.Items.AddRange(new object[] {
            "Pase corto",
            "Pase a media distancia",
            "Pase largo",
            "Pases de cabeza",
            "Pase de pared",
            "Pase a un espacio",
            "pase de Tacón"});
            this.pases.Location = new System.Drawing.Point(427, 240);
            this.pases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pases.Name = "pases";
            this.pases.Size = new System.Drawing.Size(160, 24);
            this.pases.TabIndex = 30;
            this.pases.SelectedIndexChanged += new System.EventHandler(this.pases_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "pases";
            // 
            // saques
            // 
            this.saques.Enabled = false;
            this.saques.FormattingEnabled = true;
            this.saques.Items.AddRange(new object[] {
            "Saque Lateral",
            "Saque Campo",
            "Saque Esquina",
            "Saque de Falta",
            "Saque de Penal",
            "Saque de Comienzo"});
            this.saques.Location = new System.Drawing.Point(655, 240);
            this.saques.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saques.Name = "saques";
            this.saques.Size = new System.Drawing.Size(160, 24);
            this.saques.TabIndex = 32;
            this.saques.SelectedIndexChanged += new System.EventHandler(this.saques_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(687, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 32);
            this.label6.TabIndex = 31;
            this.label6.Text = "saques";
            // 
            // accion
            // 
            this.accion.Enabled = false;
            this.accion.Location = new System.Drawing.Point(393, 306);
            this.accion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accion.Name = "accion";
            this.accion.Size = new System.Drawing.Size(100, 28);
            this.accion.TabIndex = 33;
            this.accion.Text = "accion";
            this.accion.UseVisualStyleBackColor = true;
            this.accion.Click += new System.EventHandler(this.accion_Click);
            // 
            // jugadas
            // 
            this.jugadas.Enabled = false;
            this.jugadas.Location = new System.Drawing.Point(655, 309);
            this.jugadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jugadas.Name = "jugadas";
            this.jugadas.Size = new System.Drawing.Size(160, 22);
            this.jugadas.TabIndex = 34;
            this.jugadas.TextChanged += new System.EventHandler(this.jugadas_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(687, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 32);
            this.label7.TabIndex = 35;
            this.label7.Text = "jugadas";
            // 
            // faltas
            // 
            this.faltas.Enabled = false;
            this.faltas.FormattingEnabled = true;
            this.faltas.Items.AddRange(new object[] {
            "Tiro libre indirecto",
            "Tarjeta amarilla",
            "Tarjeta roja",
            "Tiro libre indirecto dentro del área"});
            this.faltas.Location = new System.Drawing.Point(168, 309);
            this.faltas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.faltas.Name = "faltas";
            this.faltas.Size = new System.Drawing.Size(160, 24);
            this.faltas.TabIndex = 37;
            this.faltas.SelectedIndexChanged += new System.EventHandler(this.faltas_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 32);
            this.label8.TabIndex = 36;
            this.label8.Text = "faltas";
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(517, 306);
            this.clean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(100, 28);
            this.clean.TabIndex = 38;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(467, 91);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(59, 37);
            this.btnStart.TabIndex = 46;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeg
            // 
            this.lblSeg.AutoSize = true;
            this.lblSeg.Location = new System.Drawing.Point(504, 58);
            this.lblSeg.Name = "lblSeg";
            this.lblSeg.Size = new System.Drawing.Size(24, 17);
            this.lblSeg.TabIndex = 44;
            this.lblSeg.Text = "00";
            this.lblSeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(464, 58);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 17);
            this.lblMin.TabIndex = 43;
            this.lblMin.Text = "43";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScoreB
            // 
            this.txtScoreB.Enabled = false;
            this.txtScoreB.Location = new System.Drawing.Point(640, 91);
            this.txtScoreB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScoreB.Name = "txtScoreB";
            this.txtScoreB.Size = new System.Drawing.Size(49, 22);
            this.txtScoreB.TabIndex = 42;
            // 
            // txtScoreA
            // 
            this.txtScoreA.Enabled = false;
            this.txtScoreA.Location = new System.Drawing.Point(309, 91);
            this.txtScoreA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScoreA.Name = "txtScoreA";
            this.txtScoreA.Size = new System.Drawing.Size(49, 22);
            this.txtScoreA.TabIndex = 41;
            // 
            // txtTeamB
            // 
            this.txtTeamB.AutoSize = true;
            this.txtTeamB.Enabled = false;
            this.txtTeamB.Location = new System.Drawing.Point(636, 58);
            this.txtTeamB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTeamB.Name = "txtTeamB";
            this.txtTeamB.Size = new System.Drawing.Size(53, 17);
            this.txtTeamB.TabIndex = 40;
            this.txtTeamB.Text = "TeamB";
            this.txtTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTeamA
            // 
            this.txtTeamA.AutoSize = true;
            this.txtTeamA.Enabled = false;
            this.txtTeamA.Location = new System.Drawing.Point(305, 58);
            this.txtTeamA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTeamA.Name = "txtTeamA";
            this.txtTeamA.Size = new System.Drawing.Size(53, 17);
            this.txtTeamA.TabIndex = 39;
            this.txtTeamA.Text = "TeamA";
            this.txtTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(899, 428);
            this.inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(100, 28);
            this.inicio.TabIndex = 47;
            this.inicio.Text = "inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 471);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeg);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtScoreB);
            this.Controls.Add(this.txtScoreA);
            this.Controls.Add(this.txtTeamB);
            this.Controls.Add(this.txtTeamA);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.faltas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.jugadas);
            this.Controls.Add(this.accion);
            this.Controls.Add(this.saques);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pases);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tiros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Team2);
            this.Controls.Add(this.Team1);
            this.Controls.Add(this.JugadorT2_2);
            this.Controls.Add(this.JugadorT1_2);
            this.Controls.Add(this.JugadorT2);
            this.Controls.Add(this.JugadorT1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "partido de futbol";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox JugadorT1;
        private System.Windows.Forms.ComboBox JugadorT2;
        private System.Windows.Forms.ComboBox JugadorT1_2;
        private System.Windows.Forms.ComboBox JugadorT2_2;
        private System.Windows.Forms.RadioButton Team1;
        private System.Windows.Forms.RadioButton Team2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tiros;
        private System.Windows.Forms.ComboBox pases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox saques;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button accion;
        private System.Windows.Forms.TextBox jugadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox faltas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSeg;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtScoreB;
        private System.Windows.Forms.TextBox txtScoreA;
        private System.Windows.Forms.Label txtTeamB;
        private System.Windows.Forms.Label txtTeamA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button inicio;


    }
}