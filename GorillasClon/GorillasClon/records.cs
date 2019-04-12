using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace GorillasClon
{
    public partial class records : Form
    {
        public List<Personaje> persona = new List<Personaje>();

        public records()
        {
            InitializeComponent();
            muestraRecord();
        }

        public void muestraRecord()
        {
            StreamReader sr = new StreamReader("Records.txt");
            String cad;

            while ((cad = sr.ReadLine()) != null)
            {
                Personaje p = new Personaje();
                p.ID = cad;

                cad = sr.ReadLine();//para leer una nueva linea
                p.rondas = int.Parse(cad);//guardar en el producto 

                label4.Text = p.ID;
                label5.Text = p.rondas.ToString();
            }
            sr.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantallaInicio pi = new PantallaInicio();
            pi.Show();
            this.Hide();
        }
    }
}
