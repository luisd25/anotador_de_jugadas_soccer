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
    public partial class Elegir : Form
    {
        public Elegir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score f = new score();
            f.Show();
            this.Hide();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Inicio f = new Inicio();
           
            f.Show();
            this.Hide();
        }
    }
}
