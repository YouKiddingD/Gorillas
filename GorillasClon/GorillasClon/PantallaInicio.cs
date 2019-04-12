using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillasClon
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ayuda yd = new ayuda();
            yd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NombrePersonaje nP = new NombrePersonaje();
            nP.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            records rc = new records();
            rc.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
