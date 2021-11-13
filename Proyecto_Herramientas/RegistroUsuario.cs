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
    public partial class RegistroUsuario : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-U6MQJK7;  database=ProyectoHerramienta; integrated security= true");
        CUsuario usuario = new CUsuario();
    
        public RegistroUsuario()
        {
            InitializeComponent();
            
        }

        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtPass1.Clear();
            txtCpass.Clear();
            txtEmail.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            int id_rol = 2;
            usuario.ID = Convert.ToInt32(txtCedula.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Telefono = Convert.ToInt32(txtTelefono.Text);
            usuario.Email = txtEmail.Text;
            usuario.Contrasena = txtPass1.Text;
            usuario.Rol = id_rol;

            if (usuario.Contrasena == txtCpass.Text)
            {
                usuario.GuardarUsuario();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden!!");
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

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                epError.SetError(txtNombre, "Introducir el nombre...");
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
                epError.SetError(txtApellido, "Introducir el apellido...");
                txtApellido.Focus();
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
                epError.SetError(txtTelefono, "Introducir el telefono...");
                txtTelefono.Focus();
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
                epError.SetError(txtDireccion, "Introducir la dirección...");
                txtDireccion.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                epError.SetError(txtEmail, "Introducir el email...");
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
                epError.SetError(txtPass1, "Introducir la contraseña...");
                txtPass1.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtCpass_Validated(object sender, EventArgs e)
        {
            if (txtCpass.Text.Trim() == "")
            {
                epError.SetError(txtCpass, "Introducir la contraseña...");
                txtCpass.Focus();
            }
            else
            {
                epError.Clear();
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
    }
}
