using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
    public partial class juegos_jugados : Form
    {
        private string SQLSelectC = "SELECT DISTINCT  Juego FROM score Where Terminado = 1";
        private string SQLSelectI = "SELECT DISTINCT  Juego FROM score Where Terminado = 0";


        private string p = "SELECT *  FROM score";
     
        DB r = new DB();
        public juegos_jugados()
        {
            
            r.Connect();
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
           
            dataGrid.RowEnter -= dataGridView1_RowEnter;

            if (r.connect.State != ConnectionState.Open)
                r.connect.Open();

            SQLiteCommand command = r.connect.CreateCommand();
            command.CommandText = SQLSelectC;

         
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
           
               
            
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
        
            dataGrid.DataSource = bs;

       
            
            command = r.connect.CreateCommand();
            command.CommandText = p;
            SQLiteDataReader dr;
            dr = command.ExecuteReader();
            string name;
            
            List<string> l = new List<string>();
            while (dr.Read())
            {
                name = dr.GetString(5);
                l.Add(name);
            }
           
            r.connect.Close();
            dataGrid.RowEnter += dataGridView1_RowEnter;
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }

       

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
     
            String jg = (String)dataGrid.Rows[e.RowIndex].Cells[0].Value;
            

            txt_bd.Text = jg;
          

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Juegos j=new Juegos(txt_bd.Text);
            j.Show();
            this.Hide();
        }
       

        private void txt_bd_TextChanged(object sender, EventArgs e)
        {
            if(txt_bd.Text!="")
                button2.Enabled=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGrid.RowEnter -= dataGridView1_RowEnter;

            if (r.connect.State != ConnectionState.Open)
                r.connect.Open();

           
            SQLiteCommand command = r.connect.CreateCommand();
            command.CommandText = SQLSelectI;

           
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);



            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            dataGrid.DataSource = bs;


            command = r.connect.CreateCommand();
            command.CommandText = p;
            SQLiteDataReader dr;
            dr = command.ExecuteReader();
            string name;
            
            List<string> l = new List<string>();
            while (dr.Read())
            {
                name = dr.GetString(5);
                l.Add(name);
            }
           
            r.connect.Close();
            dataGrid.RowEnter += dataGridView1_RowEnter;
        }

        private void juegos_jugados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
               

            }
            else
            Application.ExitThread();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir al Menu de Inicio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Inicio ini = new Inicio();
                ini.Show();
                this.Hide();
            }
        }

        private void juegos_jugados_Load(object sender, EventArgs e)
        {

        }
    }
}
