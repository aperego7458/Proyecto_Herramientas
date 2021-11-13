using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Proyecto_Herramientas
{
    public partial class Agenda : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-U6MQJK7;  database=ProyectoHerramienta; integrated security= true");
        public Agenda(string idUsuario)
        {
            InitializeComponent();
            txtIdlog.Text = idUsuario.ToString();
            Leer();
        }
        public void Limpiar()
        {
            txtIDBienes.Clear();
        }
        public void Leer()
        {
            conn.Open();
            string Consulta = "SELECT * FROM Propiedades";
            SqlCommand comando = new SqlCommand(Consulta, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable resultado = new DataTable();
            adapter.Fill(resultado);
            dgvInmueble.DataSource = resultado;
            conn.Close();
            Limpiar();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            var FechaActual = DateTime.Now;

            dtpCita.MinDate = FechaActual;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string consulta = "INSERT INTO Agenda VALUES (@p1,@p2,@p3,@p4)";
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("p1", txtIdlog.Text);
            comando.Parameters.AddWithValue("p2", txtIDBienes.Text);
            comando.Parameters.AddWithValue("p3", dtpCita.Text);
            comando.Parameters.AddWithValue("p4", cbHora.Text);
            comando.ExecuteNonQuery();

            conn.Close();

            
            Leer();
        }

        private void dgvInmueble_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Leer();
        }

        private void dgvInmueble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.dgvInmueble.Rows[e.RowIndex];

                txtIDBienes.Text = fila.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion v1 = new InicioSesion();
            v1.Show();
            this.Hide();
        }
    }
}
