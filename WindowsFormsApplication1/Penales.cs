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
    public partial class Penales : Form
        
    {
        private int ronda =1;
        private DB r = new DB();
        private string Name= "";
        public Penales(string name ,string e1, string e2,ComboBox x, ComboBox y, ComboBox a, ComboBox b)
        {
            InitializeComponent();
            Name = name;
            label5.Text = e1;
            label4.Text = e2;
            for (int i = 0; i < x.Items.Count; i++)
            {
                comboBox1.Items.Add(x.Items[i]);
            }
            for (int i = 0; i < y.Items.Count; i++)
            {
                comboBox1.Items.Add(y.Items[i]);
            }
            for (int i = 0; i < a.Items.Count; i++)
            {
                comboBox2.Items.Add(a.Items[i]);
            }
            for (int i = 0; i < b.Items.Count; i++)
            {
                comboBox2.Items.Add(b.Items[i]);
            }
        }

        private void Penales_Load(object sender, EventArgs e)
        {
            r.Connect();
            radioButton2.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox2.Enabled = true;
                comboBox1.Enabled = false;
                radioButton1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = false;
                radioButton2.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
                button1.Enabled=true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
                button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string equipo = "";
            string jugador = "";
            string tiempo = "Ronda No."+ronda;
            string jugada = "Penalti"; 
            TextBox a = new TextBox();
            if (radioButton2.Checked)
            {
                equipo = label5.Text;
                jugador = comboBox2.SelectedItem.ToString();
                comboBox2.Items.Remove(jugador);
                radioButton2.Enabled = radioButton2.Checked = false;
                radioButton1.Enabled = radioButton1.Checked = true;
                a=textBox1;
   
            }
            else
            {
                equipo = label4.Text;
                jugador = comboBox1.SelectedItem.ToString();
                comboBox1.Items.Remove(jugador);
                radioButton2.Enabled = radioButton2.Checked = true;
                radioButton1.Enabled = radioButton1.Checked = false;
                a = textBox2;
                ronda++;
            }
            button1.Enabled = false;
            
            if (MessageBox.Show("¿Anotó con el tiro penal?", "Tiro Penal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                jugada += " (Anota)";
                a.Text= (Convert.ToInt32(a.Text)+1).ToString();
                comboBox1.Text = comboBox2.Text = " ";
    

            }

            r.regJugada(Name, jugador, tiempo, equipo, jugada, ("["+textBox1.Text+"-"+textBox2.Text+"]"));
            if (ronda == 6)
                this.Close();

            label1.Text = ronda.ToString();
                
        }

        private void Penales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ronda != 6)
            {
                MessageBox.Show("Finalice la ronda de penales...");
                e.Cancel = true;
            }
        }
    }
}
