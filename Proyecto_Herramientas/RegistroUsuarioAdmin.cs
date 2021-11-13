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
    public partial class RegistroUsuarioAdmin : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-U6MQJK7;  database=ProyectoHerramienta; integrated security= true");
        CUsuario usuario = new CUsuario();
        public int idUser = 0;
        public RegistroUsuarioAdmin()
        {
            InitializeComponent();
            Leer();
        }
        public void Leer()
        {
            conn.Open();
            string Consulta = "SELECT * FROM Usuarios";
            SqlCommand comando = new SqlCommand(Consulta, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable resultado = new DataTable();
            adapter.Fill(resultado);
            dgvUsuarios.DataSource = resultado;
            conn.Close();
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuario.ID = Convert.ToInt32(txtCedula.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Telefono = Convert.ToInt32(txtTelefono.Text);
            usuario.Email = txtEmail.Text;
            usuario.Contrasena = txtPass1.Text;
            usuario.Rol = Convert.ToInt32(txtRol.Text);

           
            usuario.GuardarUsuario();            
            Leer();
            conn.Close();         
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            usuario.ID = Convert.ToInt32(txtCedula.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Telefono = Convert.ToInt32(txtTelefono.Text);
            usuario.Email = txtEmail.Text;
            usuario.Contrasena = txtPass1.Text;
            usuario.Rol = Convert.ToInt32(txtRol.Text);

            usuario.ActualizarUsuarios();

            MessageBox.Show("Actualización correctamente!!");

            Leer();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string consulta = "DELETE FROM Usuarios WHERE ID_DOCUMENTO=@p1";
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("p1", idUser);
            comando.ExecuteNonQuery();
            conn.Close();
            Leer();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Leer();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.dgvUsuarios.Rows[e.RowIndex];

                idUser = Convert.ToInt32(fila.Cells[0].Value);
                txtCedula.Text = idUser.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtApellido.Text = fila.Cells[2].Value.ToString();
                txtDireccion.Text = fila.Cells[3].Value.ToString();
                txtTelefono.Text = fila.Cells[4].Value.ToString();
                txtEmail.Text = fila.Cells[5].Value.ToString();
                txtPass1.Text = fila.Cells[6].Value.ToString();
                txtRol.Text = fila.Cells[7].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int i = 0, n = dgvUsuarios.Rows.Count - 1;

            if (n > 0)
            {
                for (i = 0; i < n; i++)
                {
                    DataGridViewRow fila = this.dgvUsuarios.Rows[i];

                    if (txtCedula.Text == fila.Cells[0].Value.ToString())
                    {
                        idUser = Convert.ToInt32(fila.Cells[0].Value);
                        txtCedula.Text = idUser.ToString();
                        txtNombre.Text = fila.Cells[1].Value.ToString();
                        txtApellido.Text = fila.Cells[2].Value.ToString();
                        txtDireccion.Text = fila.Cells[3].Value.ToString();
                        txtTelefono.Text = fila.Cells[4].Value.ToString();
                        txtEmail.Text = fila.Cells[5].Value.ToString();
                        txtPass1.Text = fila.Cells[6].Value.ToString();
                        txtRol.Text = fila.Cells[7].Value.ToString();
                        break;
                    }
                }
                if (i == n)
                {
                    MessageBox.Show("ID no encontrado!!");
                }
            }
        }
        private void txtCedula_Validated(object sender, EventArgs e)
        {
            if (txtCedula.Text.Trim() == "")
            {
                epError.SetError(txtCedula, "Introducir la cédula...");
                txtCedula.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_Validated_1(object sender, EventArgs e)
        {
            if (txtCedula.Text.Trim() == "")
            {
                epError.SetError(txtCedula, "Introducir ciudad...");
                txtCedula.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                epError.SetError(txtNombre, "Introducir ciudad...");
                txtNombre.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtApellido_Validated(object sender, EventArgs e)
        {
            if (txtApellido.Text.Trim() == "")
            {
                epError.SetError(txtApellido, "Introducir ciudad...");
                txtApellido.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtDireccion_Validated(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim() == "")
            {
                epError.SetError(txtDireccion, "Introducir ciudad...");
                txtDireccion.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtTelefono_Validated(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                epError.SetError(txtTelefono, "Introducir ciudad...");
                txtTelefono.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                epError.SetError(txtEmail, "Introducir ciudad...");
                txtEmail.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtPass1_Validated(object sender, EventArgs e)
        {
            if (txtPass1.Text.Trim() == "")
            {
                epError.SetError(txtPass1, "Introducir ciudad...");
                txtPass1.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtRol_Validated(object sender, EventArgs e)
        {
            if (txtRol.Text.Trim() == "")
            {
                epError.SetError(txtRol, "Introducir ciudad...");
                txtRol.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtCedula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRol_KeyPress(object sender, KeyPressEventArgs e)
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
