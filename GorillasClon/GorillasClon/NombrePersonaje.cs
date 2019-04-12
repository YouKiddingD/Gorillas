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
    public partial class NombrePersonaje : Form
    {
        public String nomPersona1;
        public String nomPersona2;
        public int numRondas;

        public NombrePersonaje()
        {
            InitializeComponent();
        }

        private void NombrePersonaje_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomPersona1 = textBox1.Text;
            nomPersona2 = textBox2.Text;

            Personaje p = new Personaje(nomPersona1, 20, 262);
            Personaje p2 = new Personaje(nomPersona2, 500, 262);
            this.Hide();

            numRondas = Int32.Parse(textBox3.Text);
            Form1 juego = new Form1(p, p2,numRondas);
            juego.ShowDialog();
        }
    }
}
