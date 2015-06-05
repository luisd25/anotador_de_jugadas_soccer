using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;


namespace WindowsFormsApplication1
{
   

    public partial class score : Form
    {
        private Game g = new Game();
        private DB reg;
      


      

        public score()
        {
            InitializeComponent();
            reg  =new DB();
            reg.Connect();
            
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (Team1.Checked == true)
            {
                JugadorT1.Enabled = true;
                JugadorT2.Enabled = false;
                JugadorT2_2.Enabled = false;
                JugadorT1_2.Enabled = false;
            }
            Limpiar();
           

            
            
            
        }

        private void accion_Click(object sender, EventArgs e)
        {

            int x = 0;
            string jugada="";
            
            string equipo = "";
            string jugador="";
            string tiempo = lblMin.Text + ":" + lblSeg.Text;
            if (tiros.Enabled == true) { x = 1; jugada = tiros.SelectedItem.ToString(); }
            else if (pases.Enabled == true) { 
                jugada = pases.SelectedItem.ToString();
                if (Team1.Checked == true) jugada += " a " + JugadorT1_2;
                else jugada += " a " + JugadorT2_2;
            }
            else if(jugadas.Enabled==true){jugada=jugadas.Text;}
            else if(faltas.Enabled==true){jugada=faltas.SelectedItem.ToString();}
            else if(saques.Enabled==true){jugada=saques.SelectedItem.ToString();}
            
            if (Team1.Checked == true) {equipo = label1.Text;jugador=JugadorT1.SelectedItem.ToString();}
            if (Team2.Checked == true) { equipo = label3.Text; jugador = JugadorT2.SelectedItem.ToString(); }
            
     
            
           if(x==1)
            if (MessageBox.Show("¿Anotó con el tiro?", "Tiro Libre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                jugada += " y anoto un gol!";     
                
            }
            
            Limpiar();
            
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Team2.Checked == true)
            {                            
                JugadorT2.Enabled = true;
                JugadorT1.Enabled = false;
                JugadorT1_2.Enabled = false;
                JugadorT2_2.Enabled = false;
            }
            Limpiar();
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (JugadorT1.Items.Count > 0)
            {
                tiros.Enabled = true;
                pases.Enabled = true;
                saques.Enabled = true;
                jugadas.Enabled = true;
                faltas.Enabled = true;
                
                
             }
        }

        private void tiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tiros.Items.Count > 0)
            {
                accion.Enabled = true;
                tiros.Enabled = true;
                pases.Enabled = false;
                faltas.Enabled = false;
                saques.Enabled = false;
                jugadas.Enabled = false;
              
            }
        }

        private void faltas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (faltas.Items.Count > 0 )
            {
                accion.Enabled = true;
                tiros.Enabled = false;
                pases.Enabled = false;
                saques.Enabled = false;
                jugadas.Enabled = false;
                

            }
        }

        private void pases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pases.Items.Count > 0)
            {
                    
                    tiros.Enabled = false;
                    faltas.Enabled = false;
                    saques.Enabled = false;
                    jugadas.Enabled = false;
                   
                    if (Team1.Checked == true) JugadorT1_2.Enabled = true;
                    if (Team2.Checked == true) JugadorT2_2.Enabled = true;
                    
                

            }
        }

        private void saques_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saques.Items.Count > 0)
            {
                accion.Enabled = true;
                tiros.Enabled = false;
                pases.Enabled = false;
                faltas.Enabled = false;
                jugadas.Enabled = false;
           
            }
        }

        private void jugadas_TextChanged(object sender, EventArgs e)
        {
            if ( jugadas.TextLength > 0 )
            {
                accion.Enabled = true;
                tiros.Enabled = false;
                pases.Enabled = false;
                saques.Enabled = false;
                faltas.Enabled = false;
                
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            JugadorT1.SelectedIndex = -1;
            JugadorT2.SelectedIndex = -1;
            JugadorT1_2.SelectedIndex = -1;
            JugadorT2_2.SelectedIndex = -1;
            tiros.SelectedIndex = -1;
            saques.SelectedIndex = -1;
            pases.SelectedIndex = -1;
            faltas.SelectedIndex = -1;
            jugadas.Text = "";
            faltas.Enabled = false;
            tiros.Enabled = false;
            pases.Enabled = false;
            saques.Enabled = false;
            jugadas.Enabled = false;
            JugadorT2_2.Enabled = false;
            JugadorT1_2.Enabled = false;


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JugadorT2.Items.Count > 0)
            {
                tiros.Enabled = true;
                pases.Enabled = true;
                saques.Enabled = true;
                jugadas.Enabled = true;
                faltas.Enabled = true;
               
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       

        private void gol_Click(object sender, EventArgs e)
        {
            int gol = 0;
            gol++;

        }

        private void JugadorT1_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JugadorT1_2.Items.Count > 0) accion.Enabled = true;
        }
        public void guardar()
        {
            
            
          
           
        }
        public class Prompt
        {
            public static string RecoveryTime(string text, string caption)
            {
                Form prompt = new Form();
                prompt.Width = 350;
                prompt.Height = 150;
                prompt.Text = caption;
                prompt.StartPosition = FormStartPosition.CenterScreen;
                Label textLabel = new Label() { Left = 20, Top = 25, Width = 300, Text = text };
                TextBox textBox = new TextBox() { Left = 260, Top = 20, Width = 40, Text = "" };
                Button confirmation = new Button() { Text = "Add", Left = 220, Width = 80, Top = 50 };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;
                prompt.ShowDialog();
                return textBox.Text;
            }

            public static List<string[]> TeamTemplate(string caption)
            {
                List<string[]> s = new List<string[]>();
                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 150;
                prompt.Text = caption;
                prompt.StartPosition = FormStartPosition.CenterScreen;
                Label textLabel = new Label() { Left = 20, Top = 25, Width = 50, Text = "Name: " };
                TextBox textBox = new TextBox() { Left = 70, Top = 20, Width = 100, Text = "" };
                Label textLabel2 = new Label() { Left = 20, Top = 50, Width = 50, Text = "Players: " };
                ComboBox comboBox = new ComboBox() { Left = 70, Top = 50, Width = 300 };
                Button add = new Button() { Text = "Add", Left = 380, Width = 80, Top = 48 };
                Button ok = new Button() { Text = "OK", Left = 380, Width = 80, Top = 78 };
                add.Click += (sender, e) =>
                {
                    string n = "";
                    bool f = true; ;
                    while (n.Length == 0)
                    {

                        string t = Prompt.RecoveryTime("Numbers of players: ", "Add Players");
                        if (t == "")
                        {
                            f = false;
                        }

                        for (int i = 0; i < t.Length; i++)
                        {
                            if (!Char.IsDigit(t[i]))
                                f = false;

                        }
                        if (comboBox.Items.Count == 0)
                        {
                            if (f && (Convert.ToInt32(t) >= 7))
                                n = t;
                            else
                            {
                                MessageBox.Show("Must add at least seven players.");
                                f = true;
                            }
                        }
                        else
                        {
                            if (f)
                                n = t;
                            else
                            {
                                MessageBox.Show("Indicate the number of players");
                                f = true;
                            }
                        }
                    }
                    int lim = Convert.ToInt32(n);
                    for (int i = 0; i < lim; )
                    {
                        string[] t = Prompt.PlayerTemplate();
                        if (t.Length != 0)
                        {
                            s.Add(t);
                            comboBox.Items.Add(t[0]);
                            i++;
                        }
                        else
                            MessageBox.Show("Enter player data.");

                    }
                };



                ok.Click += (sender, e) =>
                {
                    if (textBox.Text == "")
                        MessageBox.Show("Enter Team's Name.");

                    else
                        if (comboBox.Items.Count == 0)
                            MessageBox.Show("Enter Player's info.");
                        else
                        {
                            prompt.Close();
                        }

                };

                prompt.FormClosing += (sender, e) =>
                {
                    if (textBox.Text == "")
                    {
                        MessageBox.Show("Enter Team's Name.");
                        e.Cancel = true;
                    }

                    else
                        if (comboBox.Items.Count == 0)
                        {
                            MessageBox.Show("Enter Player's info.");
                            e.Cancel = true;
                        }
                        else
                        {
                            string[] t = { textBox.Text };
                            s.Add(t);

                        }

                };

                prompt.Controls.Add(textBox);

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textLabel2);
                prompt.Controls.Add(comboBox);
                prompt.Controls.Add(add);
                prompt.Controls.Add(ok);
                prompt.ShowDialog();
                return s;
            }

            public static string[] PlayerTemplate()
            {
                List<string> s = new List<string>();

                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 200;
                prompt.Text = "Player Template";
                prompt.StartPosition = FormStartPosition.CenterScreen;
                Label textLabel = new Label() { Left = 20, Top = 25, Width = 50, Text = "Name: " };
                TextBox textBox = new TextBox() { Left = 70, Top = 20, Width = 100, Text = "" };
                Label textLabel2 = new Label() { Left = 20, Top = 55, Width = 50, Text = "NO.: " };
                TextBox textBox2 = new TextBox() { Left = 70, Top = 50, Width = 40 };
                Label textLabel3 = new Label() { Left = 20, Top = 85, Width = 50, Text = "Pos: " };
                TextBox textBox3 = new TextBox() { Left = 70, Top = 80, Width = 50 };
                Label textLabel4 = new Label() { Left = 20, Top = 115, Width = 200, Text = "Starts in LineUp: " };
                RadioButton yes = new RadioButton() { Left = 160, Top = 110, Width = 70, Text = "Yes" };
                RadioButton no = new RadioButton() { Left = 230, Top = 110, Width = 70, Text = "No" };
                Button add = new Button() { Text = "Add", Left = 380, Width = 80, Top = 48 };
                add.Click += (sender, e) =>
                {
                    bool f = true;
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    {
                        if (!Char.IsDigit(textBox2.Text[i]))
                            f = false;
                    }

                    if (textBox.Text.Length > 0 && f && textBox3.Text.Length > 0)
                    {
                        s.Add(textBox.Text);
                        s.Add(textBox2.Text);
                        s.Add(textBox3.Text);
                        if (yes.Checked)
                            s.Add(yes.Text);
                        else
                            s.Add(no.Text);
                        prompt.Close();

                    }
                    else
                        MessageBox.Show("Llene adecuadamente cada campo.");
                };


                prompt.Controls.Add(textBox);

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textLabel2);
                prompt.Controls.Add(textBox2);
                prompt.Controls.Add(textLabel3);
                prompt.Controls.Add(textBox3);
                prompt.Controls.Add(yes);
                prompt.Controls.Add(no);
                prompt.Controls.Add(textLabel4);
                prompt.Controls.Add(add);
                prompt.ShowDialog();

                return s.ToArray();

            }

            public static string Ask(string text, string caption)
            {
                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 200;
                prompt.Text = caption;
                prompt.StartPosition = FormStartPosition.CenterScreen;
                Label textLabel = new Label() { Left = 50, Top = 20, Width = 300, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 50, Text = "" };
                Button confirmation = new Button() { Text = "Ok", Left = 50, Width = 100, Top = 80, Height = 40 };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;
                prompt.ShowDialog();
                return textBox.Text;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             int min = Convert.ToInt32(lblMin.Text);
            int seg = Convert.ToInt32(lblSeg.Text) + 1;

            if (seg == 60)
            {

                min += 1;
                seg = 0;
                if (min < 10)
                    lblMin.Text = '0' + min.ToString();
                else
                    lblMin.Text = min.ToString();
            }
            if (seg < 10)
                lblSeg.Text = '0' + seg.ToString();
            else
                lblSeg.Text = seg.ToString();

            if (min == (g.getTiempo() - 1) && seg == 0)
            {
                string n = "";
                bool f = true;
                while (n.Length == 0)
                {


                    string t = Prompt.Ask("Minutos de Recuperacion:", "Tiempo de Recuperacion");

                    for (int i = 0; i < t.Length; i++)
                    {
                        if (!Char.IsDigit(t[i]))
                            f = false;
                    }

                    if (f)
                        n = t;
                    else
                    {
                        MessageBox.Show("Introduzca los minutos..");
                        f = true;
                    }
                }
                g.setRecovery(Convert.ToInt32(n));

            }

            if (min == g.getRealTime())
            {
                timer1.Stop();
                if (g.getFirst())
                {
                    g.goToSecond();

                }
                else
                {
                    if (true && !g.getExtra())
                    {
                        DialogResult result = MessageBox.Show("OverTime?", "Over Time", MessageBoxButtons.YesNoCancel);

                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Tiempo Extra");

                            g.goToExtra();
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Juego Finalizado");
                            btnStart.Enabled = false;
                        }
                        else if (result == DialogResult.Cancel)
                        {
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Penaltis?", "Penaltis", MessageBoxButtons.YesNoCancel);

                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Estamos en Penales");
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Juego Finalizado");
                        }
                        else if (result == DialogResult.Cancel)
                        {
                        }
                    }
                }
                g.setRecovery(0);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void JugadorT2_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JugadorT2_2.Items.Count>0 )
            {
                accion.Enabled = true;
            }
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Inicio f = new Inicio();
            f.Show();
            this.Hide();
        }
      
    }
}
