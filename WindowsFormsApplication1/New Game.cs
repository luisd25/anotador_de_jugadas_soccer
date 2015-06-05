using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Game g;
        DB r=new DB();
        bool Finished;
        
        public Form1()
        {
            InitializeComponent();
         
            r.Connect();
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
                Button confirmation = new Button() { Text = "Ok", Left = 220, Width = 80, Top = 50 };
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
                Label textLabel = new Label() { Left = 20, Top = 25, Width = 50, Text = "Nombre: " };
                TextBox textBox = new TextBox() { Left = 70, Top = 20, Width = 100, Text = "" };
                Label textLabel2 = new Label() { Left = 20, Top = 50, Width = 50, Text = "Jugadores: " };
                ComboBox comboBox = new ComboBox() { Left = 70, Top = 50, Width = 300 };
                Button add = new Button() { Text = "Add", Left = 380, Width = 80, Top = 48 };
                Button ok = new Button() { Text = "OK", Left = 380, Width = 80, Top = 78 };
                add.Click += (sender, e) =>
                {
                    string n = "";
                    bool f = true; ;
                    while (n.Length == 0)
                    {

                        string t = Prompt.RecoveryTime("Numero de Jugadores: ", "Añadir Jugadores");
                        if (t=="")
                        {
                            f = false;
                        }
                        
                        for (int i = 0; i < t.Length; i++)
                        {
                            if (!Char.IsDigit(t[i]) )
                                f = false;
                           
                        }
                        
                        
                            if (f)
                                n = t;
                            else
                            {
                                MessageBox.Show("Indicar el numero de jugadores");
                                f = true;
                            }
                        
                    }
                    int lim = Convert.ToInt32(n);
                    for (int i = 0; i < lim; )
                    {
                        string[] t= Prompt.PlayerTemplate();
                        if (t.Length!=0)
                        {
                            s.Add(t);
                            comboBox.Items.Add(t[0]);
                            i++;
                        }
                        else
                            MessageBox.Show("Introduzca los datos del Jugador");
                     
                    }
                };
                
                
                
                ok.Click += (sender, e) =>
                {
                    if (textBox.Text == "")
                        MessageBox.Show("Digite el nombre del Equipo.");

                    else 
                        if(comboBox.Items.Count<7)
                          
                                MessageBox.Show("Debe hber por lo menos siete jugadores.");
                   
                    else
                    {
                        prompt.Close();
                    }

                };

                prompt.FormClosing += (sender, e) =>
                {
                    if (textBox.Text == "")
                    {
                        MessageBox.Show("Digite el nombre del Equipo");
                        e.Cancel = true;
                    }

                    else
                        if (comboBox.Items.Count == 0)
                        {
                            MessageBox.Show("Añada a los jugadores.");
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
            public static string Pase(string text, string caption, ComboBox x)
        {
            Form prompt = new Form();
           prompt.Width = 330;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 20, Top = 25, Width = 300, Text = text };
            ComboBox hola = new ComboBox() { Enabled = true, Left = 150, Top = 20, Width = 150 };
            for (int i = 0; i < x.Items.Count; i++)
            {
                hola.Items.Add(x.Items[i]);
            }
           
            Button confirmation = new Button() { Text = "Ok", Left = 220, Width = 80, Top = 50, Enabled = false, };
            hola.SelectedIndexChanged += (sender, e) => { confirmation.Enabled = true; };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(hola);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            return hola.SelectedItem.ToString();
        }

            public static string[] PlayerTemplate()
            {
                List<string> s=new List<string>();
                
                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 200;
                prompt.Text = "Plantilla del Jugaador";
                prompt.StartPosition = FormStartPosition.CenterScreen;
                Label textLabel = new Label() { Left = 20, Top = 25, Width = 50, Text = "Name: " };
                TextBox textBox = new TextBox() { Left = 70, Top = 20, Width = 100, Text = "" };
                Label textLabel2 = new Label() { Left = 20, Top = 55, Width = 50, Text = "NO.: " };
                TextBox textBox2 = new TextBox() { Left = 70, Top = 50, Width = 40 };
                Label textLabel3 = new Label() { Left = 20, Top = 85, Width = 50, Text = "Pos: " };
                ComboBox cbpos = new ComboBox() { Left = 70, Top = 80, Width = 100, };
                cbpos.Items.Add("Portero");
                cbpos.Items.Add("Defensa");
                cbpos.Items.Add("Medio-Campista");
                cbpos.Items.Add("Delantero");
                Label textLabel4 = new Label() { Left = 20, Top = 115, Width = 200, Text = "Irá a cancha: " };
                RadioButton yes = new RadioButton() { Left = 160, Top = 110, Width=70, Text="Si"};
                RadioButton no = new RadioButton() { Left = 230, Top = 110, Width=70, Text="No"};
                Button add = new Button() { Text = "Add", Left = 380, Width = 80, Top = 48};
                add.Click += (sender, e) =>
                {
                    bool f = true;
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    {
                        if (!Char.IsDigit(textBox2.Text[i]))
                            f = false;
                    }

                    if (textBox.Text.Length > 0 && f && cbpos.Text.Length > 0)
                    {
                        s.Add(textBox.Text);
                        s.Add(textBox2.Text);
                        s.Add(cbpos.Text);
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
                    prompt.Controls.Add(cbpos);
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

        private void Form1_Closing(object sender, EventArgs e)
        {
            Application.Exit();
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
                Limpiar();
                timer1.Stop();
                btnStart.Visible = true;
                btnStart.Enabled = false;
                
                if (g.getFirst())
                {
                    g.goToSecond();
                    
                }
                else{
                    if (true && !g.getExtra())
                    {
                        DialogResult result = MessageBox.Show("Tiempo extra?", "Tiempo Extra", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Tiempo Extra");
                            
                            g.goToExtra();
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Juego Finalizado");
                            r.endGame(lblMin.Text + ":" + lblSeg.Text, g.getName(), g.getScore());
                            btnStart.Enabled = false;
                            Finished=true;
                            Finalizar();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            MessageBox.Show("Indique si el juego termino o no.");
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Penaltis?", "Penaltis", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            Penales penales = new Penales(g.getName(), lblTeamA.Text, lblTeamB.Text, cbInCourtA, cbAtBenchA, cbInCourtB, cbAtBenchB);
                            penales.ShowDialog();
                            MessageBox.Show("Juego Finalizado");
                            r.endGame(lblMin.Text + ":" + lblSeg.Text, g.getName(), g.getScore());
                            btnStart.Enabled = false;
                            Finished = true;
                            Finalizar();

                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Juego Finalizado");
                            r.endGame(lblMin.Text + ":" + lblSeg.Text, g.getName(), g.getScore());
                            btnStart.Enabled = false;
                            Finished = true;
                            Finalizar();
                            
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
            
            if (cbInCourtA.Items.Count < 7)
            {
                btnSwap1.Visible = true;
                MessageBox.Show(g.getTeamA().getName() + " no tiene suficientes jugadores en cancha.");
            }
            else if (cbInCourtB.Items.Count < 7)
            {
                btnSwap2.Visible = true;
                MessageBox.Show(g.getTeamB().getName() + " no tiene suficientes jugadores en cancha.");
            }
            else
            {
                timer1.Start();
                string jugador = "";
                btnStart.Visible = btnSwap1.Visible = btnSwap2.Visible = false;
                
                cbAtBenchB.Enabled = cbAtBenchA.Enabled = cbInCourtA.Enabled = cbInCourtB.Enabled = false;
                label2.Enabled = label3.Enabled = label4.Enabled = label5.Enabled = label6.Enabled = rbBallA.Enabled = true;
                string equipo = "";
                if (rbBallA.Checked)
                {
                    jugador = cbInCourtA.SelectedItem.ToString();
                    equipo = lblTeamA.Text;
                    rbBallA.Checked = false;
                }
                else
                {
                    jugador = cbInCourtB.SelectedItem.ToString();
                    equipo = lblTeamB.Text;
                    rbBallB.Checked = false;
                }

                r.regJugada(g.getName(), jugador, "00:00", equipo, "Saque de Salida", g.getScore());
                btnStart.Text = "Continuar";
            }
            Limpiar();
            
        }

        private void cbAtBenchA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnStart.Visible && cbAtBenchA.SelectedIndex >= 0)
                btnSwap1.Visible = true;
            btnSubs.Enabled = true;


        }

        private void cbAtBenchB_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(btnStart.Visible && cbAtBenchB.SelectedIndex>=0)
               btnSwap2.Visible = true;
           btnSubs.Enabled = true;
        }

        private void btnSwap1_Click(object sender, EventArgs e)
        {
            Player x=g.getTeamA().getPlayer(cbAtBenchA.SelectedItem.ToString());
            g.getTeamA().inPlayer(x);
            cbActualizeA();
            cbAtBenchA.Text = "";
            btnSwap1.Visible = false;
        }

        public void cbActualizeA()
        {
            cbAtBenchA.Items.Clear();
            cbAtBenchB.Items.Clear();
            cbInCourtA.Items.Clear();
            cbInCourtB.Items.Clear();
            Player[] f = g.getTeamA().getInCourt().ToArray();
            for (int i = 0; i < f.Length; i++)
            {
                cbInCourtA.Items.Add(f[i].getName());

            }
            f = g.getTeamA().getAtBench().ToArray();
            for (int i = 0; i < f.Length; i++)
            {
                cbAtBenchA.Items.Add(f[i].getName());

            }

            f = g.getTeamB().getInCourt().ToArray();
            for (int i = 0; i < f.Length; i++)
            {
                cbInCourtB.Items.Add(f[i].getName());

            }
            f = g.getTeamB().getAtBench().ToArray();
            for (int i = 0; i < f.Length; i++)
            {
                cbAtBenchB.Items.Add(f[i].getName());

            }
            cbAtBenchA.Text = cbAtBenchB.Text = cbInCourtA.Text = cbInCourtB.Text = "";
        }

        private void btnSwap2_Click(object sender, EventArgs e)
        {
            Player x = g.getTeamB().getPlayer(cbAtBenchB.SelectedItem.ToString());
            g.getTeamB().inPlayer(x);
            cbActualizeA();
            cbAtBenchB.Text = "";
            btnSwap2.Visible = false;
        }

        private void typingTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            btnStart.Enabled = false;
            timer1.Stop();
            txtScoreA.Text = txtScoreB.Text = "0";
            lblMin.Text = lblSeg.Text = "00";
            g = new Game();
            List<string[]> s = Prompt.TeamTemplate("Plantilla del Equipo A");
            string[] t;
            Team x = new Team();
            Team y = new Team();
            for (int i = 0; i < s.Count - 1; i++)
            {
                t = s[i];
                Player a = new Player(t[0], Convert.ToInt32(t[1]), t[2]);
                if (t[3] == "Si" && x.getINC() < 11)
                {

                    x.goToCourt(a);
                }
                else
                    x.goToBench(a);
            }

            t = s[s.Count - 1];
            x.setName(t[0]);
            lblTeamA.Text = t[0];
            g.addTeamA(x);

            s = Prompt.TeamTemplate("Plantilla del Equipo B");
            
            for (int i = 0; i < s.Count - 1; i++)
            {
                t = s[i];
                if (t[3] == "Si" && x.getINC() < 11)
                {
                    y.goToCourt(new Player(t[0], Convert.ToInt32(t[1]), t[2]));
                }
                else
                    y.goToBench(new Player(t[0], Convert.ToInt32(t[1]), t[2]));
            }

            t = s[s.Count - 1];
            y.setName(t[0]);
            lblTeamB.Text = t[0];
            g.addTeamB(y);

            txtScoreA.Enabled = txtScoreB.Enabled = lblMin.Enabled = lblSeg.Enabled = lblTeamA.Enabled = lblTeamB.Enabled = lblInCourt.Enabled = lblAtBench.Enabled = true;
            rbBallA.Enabled = rbBallB.Enabled = true;
            cbActualizeA();
            g.startGame();
            Limpiar();
            Finished = false;

        }

        private void defaultTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            g = new Game();
            Team x = new Team();
            Team y = new Team();
            for (int i = 0; i < 14; i++)
            {
                string pos = "Utiliy";
                if(i==0) pos = "Portero";
                else if(i<5) pos = "Defensa";
                else if(i<8) pos = "Medio-Campista";
                else if(i<11) pos = "Delantero";
                Player a = new Player("Jugador " + (i+1), (i+1), pos);
                Player b = new Player("Jugador " + (i + 1), (i + 1), pos);
                if (i < 11)
                {

                    x.goToCourt(a);
                    y.goToCourt(b);
                }
                else
                {
                    x.goToBench(a);
                    y.goToBench(b);
                }
            }

            x.setName("Equipo A");
            lblTeamA.Text = "Equipo A";
            g.addTeamA(x);
            y.setName("Equipo B");
            lblTeamB.Text = "Equipo B";
            g.addTeamB(y);
            lblMin.Enabled=lblSeg.Enabled=txtScoreA.Enabled = label2.Enabled = txtScoreB.Enabled = lblTeamA.Enabled = lblTeamB.Enabled = lblInCourt.Enabled = lblAtBench.Enabled = true;
            rbBallA.Enabled = rbBallB.Enabled = true;
            cbActualizeA();
            g.startGame();
            Limpiar();
            Finished = false;

        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            string equipo = "";
            string jugador = "";
            string aux ="";
            if (rbBallA.Checked)
            {
                Player x = g.getTeamA().getPlayer(cbInCourtA.SelectedItem.ToString());
                Player y = g.getTeamA().getPlayer(cbAtBenchA.SelectedItem.ToString());
                g.getTeamA().subsPlayer(x, y);
                equipo= lblTeamA.Text;
                jugador=x.getName();
                aux =y.getName();
                rbBallA.Checked = false;
            }else
            {
                Player x = g.getTeamB().getPlayer(cbInCourtB.SelectedItem.ToString());
                Player y = g.getTeamB().getPlayer(cbAtBenchB.SelectedItem.ToString());
                g.getTeamB().subsPlayer(x, y);
                equipo= lblTeamA.Text;
                jugador=x.getName();
                aux=y.getName();
                rbBallB.Checked = false;
            }
            r.regJugada(g.getName(),(jugador + " (out)"), (lblMin.Text+ ":" + lblSeg.Text), equipo, ("Sustitucion: \n" + aux + " (in)"), g.getScore() );
            cbActualizeA();
        }

        private void rbBallA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBallA.Checked == true)
            {
                
                cbInCourtA.Enabled = true;
                cbInCourtB.Enabled = false;
                cbAtBenchA.Enabled = false;
                cbAtBenchB.Enabled = false;
                
            }
            Limpiar();
            
        }

        private void cbInCourtA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!btnStart.Visible && cbInCourtA.SelectedIndex >= 0)
            {
                cbAtBenchA.Enabled = btnDespeje.Enabled = btnFalta.Enabled = btnRed.Enabled = btnYellow.Enabled = true;
                btnPen.Enabled= btnAdel.Enabled= btnMA.Enabled = btnEsq.Enabled = btnBan.Enabled = pases.Enabled = tiros.Enabled = true;
                button1.Enabled = button2.Enabled = true;
                clean.Enabled = true;
            }
            else if (btnStart.Visible)
                btnStart.Enabled = true;

        }

        

        private void cbInCourtB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!btnStart.Visible&&cbInCourtB.SelectedIndex>=0)
            {
                cbAtBenchB.Enabled = btnDespeje.Enabled = btnFalta.Enabled = btnRed.Enabled = btnYellow.Enabled = true;
                btnPen.Enabled = btnAdel.Enabled = btnMB.Enabled = btnEsq.Enabled = btnBan.Enabled = pases.Enabled = tiros.Enabled = true;
                button1.Enabled = button2.Enabled = true;
                clean.Enabled = true;
            }
            else if (btnStart.Visible)
                btnStart.Enabled = true;
        }

        

        private void clean_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        
        


        public void Limpiar()
        {
            cbInCourtA.SelectedIndex = -1;
            cbInCourtB.SelectedIndex = -1;
            cbAtBenchA.SelectedIndex = -1;
            cbAtBenchB.SelectedIndex = -1;
            tiros.SelectedIndex = -1;
            pases.SelectedIndex = -1;
            btnPen.Enabled= btnAdel.Enabled=btnBan.Enabled=btnDespeje.Enabled=btnEjec1.Enabled=btnEjec2.Enabled=btnEsq.Enabled=btnFalta.Enabled=btnMA.Enabled=btnMB.Enabled=btnRed.Enabled=btnSubs.Enabled=btnYellow.Enabled=button1.Enabled=button2.Enabled = false;
            tiros.Enabled = false;
            pases.Enabled = false;
          //  rbBallA.Checked =rbBallB.Checked= false;

            cbAtBenchA.Enabled = false;
            cbAtBenchB.Enabled = false;

        }

        private void rbBallB_CheckedChanged(object sender, EventArgs e)
        {

            if (rbBallB.Checked == true)
            {
                
                cbInCourtB.Enabled = true;
                cbInCourtA.Enabled = false;
                cbAtBenchA.Enabled = false;
                cbAtBenchB.Enabled = false;

            }
            Limpiar();
        }

        private void btnMA_Click(object sender, EventArgs e)
        {
            r.regJugada(g.getName(), cbInCourtA.SelectedItem.ToString(), (lblMin.Text + ":" + lblSeg.Text), lblTeamA.Text, ("Saque de Meta"), g.getScore());
            Limpiar();
        }

        private void btnMB_Click(object sender, EventArgs e)
        {
            r.regJugada(g.getName(), cbInCourtB.SelectedItem.ToString(), (lblMin.Text + ":" + lblSeg.Text), lblTeamB.Text, ("Saque de Meta"), g.getScore());
            Limpiar();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            string equipo="";
            string jugador="";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                jugador = cbInCourtB.SelectedItem.ToString();
            }

            r.regJugada(g.getName(), jugador, (lblMin.Text + ":" + lblSeg.Text), equipo, "Tarjeta Roja", g.getScore());
            Limpiar();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            string equipo = "";
            string jugador = "";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                jugador = cbInCourtB.SelectedItem.ToString();
            }

            r.regJugada(g.getName(), jugador, (lblMin.Text + ":" + lblSeg.Text), equipo, "Tarjeta Amarilla", g.getScore());
            Limpiar();
        }

        private void btnEsq_Click(object sender, EventArgs e)
        {
            string tiempo = lblMin.Text + ":" + lblSeg.Text;
            string equipo = "";
            string jugador = "";
            Team t = new Team();
            Team t2 = new Team();

            string jugada = "Saque de Esquina ";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                t = g.getTeamA();
                t2 = g.getTeamB();
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                t = g.getTeamB();
                t2 = g.getTeamA();
                jugador = cbInCourtB.SelectedItem.ToString();

            }
            Player p = t.getPlayer(jugador);
            if (MessageBox.Show("¿Anotó con el saque de esquina?", "Saque de Esquina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                g.gol(t, p);

                jugada += " (Anota)";
                txtScoreA.Text = g.getTeamA().getScore().ToString();
                txtScoreB.Text = g.getTeamB().getScore().ToString();
            }

            r.regJugada(g.getName(), jugador, (tiempo), equipo, jugada, g.getScore());
            Limpiar();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            string equipo = "";
            string jugador = "";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                jugador = cbInCourtB.SelectedItem.ToString();
            }

            r.regJugada(g.getName(), jugador, (lblMin.Text + ":" + lblSeg.Text), equipo, "Saque de Banda", g.getScore());
            Limpiar();
        }

        private void btnFalta_Click(object sender, EventArgs e)
        {
            string tiempo = lblMin.Text + ":" + lblSeg.Text;
            string falta = "";
            string equipo = "";
            string jugador = "";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                jugador = cbInCourtA.SelectedItem.ToString();
                falta = Prompt.Pase("Sobre quien?", "Falta", cbInCourtB);
            }
            else
            {
                equipo = lblTeamB.Text;
                jugador = cbInCourtB.SelectedItem.ToString();
                falta = Prompt.Pase("Sobre quien?", "Falta", cbInCourtA);
            }

            r.regJugada(g.getName(), jugador, (tiempo), equipo, "Falta: A "+falta, g.getScore());
            Limpiar();
        }

        private void btnDespeje_Click(object sender, EventArgs e)
        {
            string equipo = "";
            string jugador = "";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                jugador = cbInCourtB.SelectedItem.ToString();
            }

            r.regJugada(g.getName(), jugador, (lblMin.Text + ":" + lblSeg.Text), equipo, "Despeje", g.getScore());
            Limpiar();
        }

        private void btnEjec1_Click(object sender, EventArgs e)
        {
            string tiempo = lblMin.Text + ":" + lblSeg.Text;
            string equipo = "";
            string jugador = "";
            Team t = new Team();
            Team t2 = new Team();

            string jugada = "Tiro Libre Directo";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                t = g.getTeamA();
                t2 = g.getTeamB();
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                t = g.getTeamB();
                t2 = g.getTeamA();
                jugador = cbInCourtB.SelectedItem.ToString();

            }
            Player p = t.getPlayer(jugador);
            if (MessageBox.Show("¿Anotó con el lanzamiento?", "Lanzamiento a Porteria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                g.gol(t, p);
                jugada += " (Anota)";
                txtScoreA.Text = g.getTeamA().getScore().ToString();
                txtScoreB.Text = g.getTeamB().getScore().ToString();

            }

            r.regJugada(g.getName(), jugador, (tiempo), equipo, jugada,g.getScore());
            Limpiar();
        }

        private void btnEjec2_Click(object sender, EventArgs e)
        {
            string tiempo = lblMin.Text + ":" + lblSeg.Text;
            string pase = "";
            
            string equipo = "";
            string jugador = "";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                jugador = cbInCourtA.SelectedItem.ToString();
                pase = Prompt.Pase("A quie se la pasó?", "Pase", cbInCourtA);
            }
            else
            {
                equipo = lblTeamB.Text;
                jugador = cbInCourtB.SelectedItem.ToString();
                pase = Prompt.Pase("A quie se la pasó?", "Pase", cbInCourtB);
            }

            r.regJugada(g.getName(), jugador, (tiempo), equipo, pases.SelectedItem.ToString()+": A "+ pase , g.getScore());
            Limpiar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string tiempo = lblMin.Text + ":" + lblSeg.Text;
            string equipo = "";
            string jugador = "";
            Team t = new Team();
            Team t2 = new Team();
            
            string jugada = "Tiro Libre Directo";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                t = g.getTeamA();
                t2 = g.getTeamB();
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                t = g.getTeamB();
                t2 = g.getTeamA();
                jugador = cbInCourtB.SelectedItem.ToString();
                
            }
            Player p = t.getPlayer(jugador);
            if (MessageBox.Show("¿Anotó con el tiro libre?", "Tiro Libre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                g.gol(t,p);
                jugada += " (Anota)";
                txtScoreA.Text = g.getTeamA().getScore().ToString();
                txtScoreB.Text = g.getTeamB().getScore().ToString();

            }

            r.regJugada(g.getName(), jugador, (tiempo), equipo, jugada, g.getScore());
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string equipo = "";
            string jugador = "";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                jugador = cbInCourtB.SelectedItem.ToString();
            }

            r.regJugada(g.getName(), jugador, (lblMin.Text + ":" + lblSeg.Text), equipo, "Tiro Libre Indirecto", g.getScore());
            Limpiar();
        }

        private void tiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tiros.SelectedIndex >= 0)
                btnEjec1.Enabled = true;
        }

        private void pases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pases.SelectedIndex >= 0)
                btnEjec2.Enabled = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Finished && lblMin.Text != "00" && lblSeg.Text != "00")
            {
                if (MessageBox.Show("¿Esta seguro que desea salir?\nEl partido actual se guardara como incompleto y no podra registrar lo que pase despues.", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();

                }

            }
            else
                this.Close();
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            
            if (!Finished && btnStart.Text == "Continuar")
            {
                timer1.Stop();
                if (MessageBox.Show("¿Esta seguro que desea salir al Menu de Inicio?\nEl partido actual se guardara como incompleto y no podra registrar lo que pase despues.", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                   timer1.Start();
                else{
                    Inicio ini = new Inicio();
                ini.Show();
                this.Hide();
            }
                
                    
            }
            else
            {
                Inicio ini = new Inicio();
                ini.Show();
                this.Hide();
            }
        }

        public void Finalizar() {
            timer1.Stop();
            btnStart.Visible = true;
            btnStart.Enabled = false;
            txtScoreA.Text = txtScoreB.Text = "0";
            lblMin.Text = lblSeg.Text = "00";
            rbBallA.Enabled = rbBallB.Enabled= false;
            
            Limpiar();
        }

        private void btnAdel_Click(object sender, EventArgs e)
        {
            string equipo = "";
            string jugador = "";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                jugador = cbInCourtB.SelectedItem.ToString();
            }

            r.regJugada(g.getName(), jugador, (lblMin.Text + ":" + lblSeg.Text), equipo, "Posicion Adelantada", g.getScore());
            Limpiar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!Finished && btnStart.Text == "Continuar")
            {
                timer1.Stop();
                if (MessageBox.Show("¿Esta seguro que desea salir?\nEl partido actual se guardara como incompleto y no podra registrar lo que pase despues.", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    timer1.Start();

                }
                else
                Application.ExitThread();
            }
            else Application.Exit();
            
           
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            string tiempo = lblMin.Text + ":" + lblSeg.Text;
            string equipo = "";
            string jugador = "";
            Team t = new Team();
            Team t2 = new Team();

            string jugada = "Tiro Penal";
            if (rbBallA.Checked)
            {
                equipo = lblTeamA.Text;
                t = g.getTeamA();
                t2 = g.getTeamB();
                jugador = cbInCourtA.SelectedItem.ToString();
            }
            else
            {
                equipo = lblTeamB.Text;
                t = g.getTeamB();
                t2 = g.getTeamA();
                jugador = cbInCourtB.SelectedItem.ToString();

            }
            Player p = t.getPlayer(jugador);
            if (MessageBox.Show("¿Anotó con el tiro penal?", "Tiro Penal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                g.gol(t, p);
                jugada += " (Anota)";
                txtScoreA.Text = g.getTeamA().getScore().ToString();
                txtScoreB.Text = g.getTeamB().getScore().ToString();

            }

            r.regJugada(g.getName(), jugador, (tiempo), equipo, jugada, g.getScore());
            Limpiar();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Penales hola = new Penales(g.getName(),lblTeamA.Text, lblTeamB.Text,cbInCourtA,cbAtBenchA, cbInCourtB,cbAtBenchB );
            hola.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda a = new Ayuda();
            a.ShowDialog();
        }

        

        
        
        

      

        
    }
}
