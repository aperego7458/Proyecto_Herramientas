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
        SqlConnection conn = new SqlConnection("server=DESKTOP-7ROJSEE;  " +
            "database=ProyectoHerramienta; " +
            "integrated security= true");

        CBienes bienes = new CBienes();
        public int idBien = 0;

        public Bienes()
        {
            InitializeComponent();
            Leer();
        }
        public void Limpiar()
        {
            txtPCiudad.Clear();
            txtPDireccion.Clear();
            txtChabitaciones.Clear();
            txtCbanos.Clear();
            txtPPrecio.Clear();
            txtPFotos.Clear();
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
            Limpiar();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id_agencia = 1111;
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
        }

        private void dgvBienes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.dgvBienes.Rows[e.RowIndex];

                idBien = Convert.ToInt32(fila.Cells[0].Value);
                txtIdPropiedad.Text = idBien.ToString();
                txtPCiudad.Text = fila.Cells[1].Value.ToString();
                txtPDireccion.Text = fila.Cells[2].Value.ToString();
                txtChabitaciones.Text = fila.Cells[3].Value.ToString();
                txtCbanos.Text = fila.Cells[4].Value.ToString();
                txtPPrecio.Text = fila.Cells[5].Value.ToString();
                txtPFotos.Text = fila.Cells[6].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bienes.Ciudad = txtPCiudad.Text;
            bienes.Direccion = txtPDireccion.Text;
            bienes.CHabitaciones = Convert.ToInt32(txtChabitaciones.Text);
            bienes.CBanos = Convert.ToInt32(txtCbanos.Text);
            bienes.Precio = Convert.ToInt32(txtPPrecio.Text);
            bienes.Fotos = txtPFotos.Text;
            bienes.IdBienes = idBien;

            bienes.ActualizarBienes();
            MessageBox.Show("Actualización correctamente!!");
            Leer();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int i = 0, n = dgvBienes.Rows.Count - 1;

            if (n > 0)
            {
                for(i =0; i < n ; i++)
                {
                    DataGridViewRow fila = this.dgvBienes.Rows[i];
                    
                    if(txtIdPropiedad.Text == fila.Cells[0].Value.ToString())
                    {
                        idBien = Convert.ToInt32(fila.Cells[0].Value);
                        txtIdPropiedad.Text = idBien.ToString();
                        txtPCiudad.Text = fila.Cells[1].Value.ToString();
                        txtPDireccion.Text = fila.Cells[2].Value.ToString();
                        txtChabitaciones.Text = fila.Cells[3].Value.ToString();
                        txtCbanos.Text = fila.Cells[4].Value.ToString();
                        txtPPrecio.Text = fila.Cells[5].Value.ToString();
                        txtPFotos.Text = fila.Cells[6].Value.ToString();
                        break;
                    }
                }
                if (i == n)
                {
                    MessageBox.Show("ID no encontrado!!");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string consulta = "DELETE FROM Propiedades WHERE ID_PROPIEDAD=@p1";
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("p1", idBien);
            comando.ExecuteNonQuery();
            conn.Close();
            Leer();
        }

        private void txtPCiudad_Validated(object sender, EventArgs e)
        {
            if (txtPCiudad.Text.Trim() == "")
            {
                epError1.SetError(txtPCiudad, "Introducir ciudad...");
                txtPCiudad.Focus();
            }
            else
            {
                epError1.Clear();
            }
        }

        private void txtPDireccion_Validated(object sender, EventArgs e)
        {
            if (txtPDireccion.Text.Trim() == "")
            {
                epError1.SetError(txtPDireccion, "Introducir la dirección...");
                txtPDireccion.Focus();
            }
            else
            {
                epError1.Clear();
            }
        }

        private void txtChabitaciones_Validated(object sender, EventArgs e)
        {
            if (txtChabitaciones.Text.Trim() == "")
            {
                epError1.SetError(txtChabitaciones, "Introducir la  cantidad...");
                txtChabitaciones.Focus();
            }
            else
            {
                epError1.Clear();
            }
        }

        private void txtCbanos_Validated(object sender, EventArgs e)
        {
            if (txtCbanos.Text.Trim() == "")
            {
                epError1.SetError(txtCbanos, "Introducir la  cantidad...");
                txtCbanos.Focus();
            }
            else
            {
                epError1.Clear();
            }
        }

        private void txtPPrecio_Validated(object sender, EventArgs e)
        {
            if (txtPPrecio.Text.Trim() == "")
            {
                epError1.SetError(txtPPrecio, "Introducir la  cantidad...");
                txtPPrecio.Focus();
            }
            else
            {
                epError1.Clear();
            }
        }

        private void txtPFotos_Validated(object sender, EventArgs e)
        {
            if (txtPFotos.Text.Trim() == "")
            {
                epError1.SetError(txtPFotos, "Introducir la  cantidad...");
                txtPFotos.Focus();
            }
            else
            {
                epError1.Clear();
            }
        }

        private void txtChabitaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCbanos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdPropiedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Opciones op = new Opciones();
            op.Show();
            this.Hide();
        }
    }
}
