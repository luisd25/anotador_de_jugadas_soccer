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
    public partial class Juegos : Form
    {
        private string name;
        private int i = 1;
        SQLiteCommand command;
        DB r = new DB();
        
        public Juegos(string n)
        {
            name = n;
            r.Connect();
            InitializeComponent();
            command = r.connect.CreateCommand();
            btn_nxt.Enabled = true;
            btn_ant.Enabled = false;
            
        }

        private void btn_nxt_Click(object sender, EventArgs e)
        {

            string SQLSelect = "SELECT Tiempo,Jugador,Equipo,Jugada, Puntuacion from score WHERE Juego = '" + name + "' limit '" + i + "' ";
            
          
            dataGrid3.RowEnter -= dataGrid3_RowEnter;

            if (r.connect.State != ConnectionState.Open)
                r.connect.Open();

             command = r.connect.CreateCommand();    
            command.CommandText = SQLSelect;

         
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);

            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            dataGrid3.DataSource = bs;
           
           
            r.connect.Close();

            
            dataGrid3.RowEnter += dataGrid3_RowEnter;
            actualizar();
            i++;
            System.Int32 i_NotDisplayableRowCount = dataGrid3.RowCount - dataGrid3.DisplayedRowCount(false);
            if (i_NotDisplayableRowCount > 0)
                dataGrid3.FirstDisplayedScrollingRowIndex = i_NotDisplayableRowCount;
        }

        private void dataGrid3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            

           
        }
        private void actualizar()
        {
            if (r.connect.State != ConnectionState.Open)
                r.connect.Open();
            SQLiteDataReader dr;
            string sqlp = "SELECT COUNT(Tiempo) AS tamano FROM score WHERE Juego='"+name+"'";
            if (i == 1) btn_ant.Enabled = false;
            else btn_ant.Enabled = true;
            command = r.connect.CreateCommand();
            command.CommandText = sqlp;
            
            dr = command.ExecuteReader();
            dr.Read();
            int j = dr.GetInt32(0);
            dr.Close();
            r.connect.Close();
            if (i == j) btn_nxt.Enabled = false;
            dataGrid3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           
        }

        private void btn_ant_Click(object sender, EventArgs e)
        {
            i -= 2;
            btn_nxt_Click(sender, e);
          
            actualizar();
            btn_nxt.Enabled = true;
           
        }

        private void Juegos_Load(object sender, EventArgs e)
        {
            
        }

        private void Juegos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                

            }
            else
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir a Mostar Juegos?","Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                juegos_jugados ver = new juegos_jugados();
                ver.Show();
                this.Hide();
            }
        }

        private void dataGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

       
        }
    }

