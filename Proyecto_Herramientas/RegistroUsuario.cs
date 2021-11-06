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
        SqlConnection conn = new SqlConnection("server=DESKTOP-7ROJSEE;  database=Arrendamiento_PB; integrated security= true");
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
           
                conn.Open();
                int id_rol = 2;
                string consulta = "INSERT INTO Usuarios VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand comando = new SqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("p1", txtCedula.Text);
                comando.Parameters.AddWithValue("p2", txtNombre.Text);
                comando.Parameters.AddWithValue("p3", txtApellido.Text);
                comando.Parameters.AddWithValue("p4", txtDireccion.Text);
                comando.Parameters.AddWithValue("p5", txtTelefono.Text);
                comando.Parameters.AddWithValue("p6", txtEmail.Text);
                comando.Parameters.AddWithValue("p7", txtPass1.Text);
                comando.Parameters.AddWithValue("p8", id_rol.ToString());


                if (txtPass1.Text == txtCpass.Text)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El usuario se registró exitosamente!!");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                conn.Close();
        }
        

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCedula_Validated(object sender, EventArgs e)
        {
            if (txtCedula.Text.Trim() == "")
            {
                epError.SetError(txtCedula, "Introducir cédula...");
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
                epError.SetError(txtNombre, "Introducir el nombre...");
                txtNombre.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
