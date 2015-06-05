namespace WindowsFormsApplication1
{
    partial class Juegos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juegos));
            this.dataGrid3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ant = new System.Windows.Forms.Button();
            this.btn_nxt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid3
            // 
            this.dataGrid3.AllowUserToAddRows = false;
            this.dataGrid3.AllowUserToDeleteRows = false;
            this.dataGrid3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid3.Location = new System.Drawing.Point(62, 81);
            this.dataGrid3.Name = "dataGrid3";
            this.dataGrid3.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid3.RowHeadersWidth = 43;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid3.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid3.RowTemplate.Height = 24;
            this.dataGrid3.Size = new System.Drawing.Size(420, 150);
            this.dataGrid3.TabIndex = 0;
            this.dataGrid3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid3_CellContentClick);
            this.dataGrid3.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid3_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::WindowsFormsApplication1.Properties.Resources._1409466531_183172;
            this.label1.Location = new System.Drawing.Point(228, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "   ";
            // 
            // btn_ant
            // 
            this.btn_ant.Image = global::WindowsFormsApplication1.Properties.Resources._1409463770_183320;
            this.btn_ant.Location = new System.Drawing.Point(148, 249);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(75, 37);
            this.btn_ant.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_ant, "Jugada Anterior");
            this.btn_ant.UseVisualStyleBackColor = true;
            this.btn_ant.Click += new System.EventHandler(this.btn_ant_Click);
            // 
            // btn_nxt
            // 
            this.btn_nxt.Image = global::WindowsFormsApplication1.Properties.Resources._1409463894_183321;
            this.btn_nxt.Location = new System.Drawing.Point(310, 249);
            this.btn_nxt.Name = "btn_nxt";
            this.btn_nxt.Size = new System.Drawing.Size(75, 37);
            this.btn_nxt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_nxt, "Siguente Jugada");
            this.btn_nxt.UseVisualStyleBackColor = true;
            this.btn_nxt.Click += new System.EventHandler(this.btn_nxt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reconstrucción del Juego";
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources._1409377594_1265851;
            this.button1.Location = new System.Drawing.Point(2, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 32);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "Volver al Menú de Mostrar Juegos.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Juegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ant);
            this.Controls.Add(this.btn_nxt);
            this.Controls.Add(this.dataGrid3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Juegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play by Play";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juegos_FormClosing);
            this.Load += new System.EventHandler(this.Juegos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid3;
        private System.Windows.Forms.Button btn_nxt;
        private System.Windows.Forms.Button btn_ant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}