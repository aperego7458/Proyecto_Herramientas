using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Herramientas
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuarioAdmin v1 = new RegistroUsuarioAdmin();
            v1.Show();
        }

        private void btnBienes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bienes v1 = new Bienes();
            v1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaAdmin v3 = new AgendaAdmin();
            v3.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            InicioSesion v2 = new InicioSesion();
            v2.Show();
            this.Hide();
        }
    }
}
