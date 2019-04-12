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
    public partial class ayuda : Form
    {
        public ayuda()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantallaInicio pi = new PantallaInicio();
            pi.Show();
            this.Hide();

        }
    }
}
