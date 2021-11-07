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

namespace Proyecto_Herramientas
{
    public partial class Bienes : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-U6MQJK7;  database=ProyectoHerramienta; integrated security= true");
        CBienes bienes = new CBienes();

        public Bienes()
        {
            InitializeComponent();
            Leer();
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
            dgvBienes.DataSource = resultado;           
            conn.Close();
        }


        private void label7_Click(object sender, EventArgs e)
        {
            //nuevo ingreso
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id_agencia = 11111;
            bienes.Ciudad = txtPCiudad.Text;
            bienes.Direccion = txtPDireccion.Text;
            bienes.CHabitaciones = Convert.ToInt32(txtChabitaciones.Text);
            bienes.CBanos = Convert.ToInt32(txtCbanos.Text);
            bienes.Precio = Convert.ToInt32(txtPPrecio.Text);
            bienes.Fotos = txtPFotos.Text;
            bienes.Agencia = id_agencia;


            bienes.GuardarBienes();
            MessageBox.Show("Registro completado!!");

            Leer();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Leer();
            bienes.Ciudad = dgvBienes.CurrentRow.Cells[1].Value.ToString();
            bienes.Direccion = dgvBienes.CurrentRow.Cells[2].Value.ToString();
            bienes.CHabitaciones = Convert.ToInt32(dgvBienes.CurrentRow.Cells[3].Value);
            bienes.CBanos = Convert.ToInt32(dgvBienes.CurrentRow.Cells[4].Value);
            bienes.Precio = Convert.ToInt32(dgvBienes.CurrentRow.Cells[5].Value);
            bienes.Fotos = dgvBienes.   CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvBienes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.dgvBienes.Rows[e.RowIndex];

                
                txtPCiudad.Text = fila.Cells[1].Value.ToString();
                txtPDireccion.Text = fila.Cells[2].Value.ToString();
                txtChabitaciones.Text = fila.Cells[3].Value.ToString();
                txtCbanos.Text = fila.Cells[4].Value.ToString();
                txtPPrecio.Text = fila.Cells[5].Value.ToString();
                txtPFotos.Text = fila.Cells[6].Value.ToString();
               
            }
        }
    }
}
