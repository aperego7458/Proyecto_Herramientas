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
    public partial class InicoSesion : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-7ROJSEE;  database=Arrendamiento_PB; integrated security= true");
        public InicoSesion()
        {
            InitializeComponent();
        }

        public void logear (string Id, string Contrasena)
        {
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT ROL from Usuarios WHERE ID_DOCUMENTO = @p1 AND CONTRASENA = @p2 ", conn);
                comando.Parameters.AddWithValue("p1", Id);
                comando.Parameters.AddWithValue("p2", Contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][0].ToString() == 1.ToString())
                    {
                        new Opciones().Show();

                    }
                    else if (dt.Rows[0][0].ToString() == 2.ToString())
                    {
                        new Bienes().Show();
                    }

                }
                else
                {
                    MessageBox.Show("¡Usuario y/o Contraseña es incorrecta!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnResgistro_Click(object sender, EventArgs e)
        {
            RegistroUsuario v1 = new RegistroUsuario();
            v1.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            logear(this.txtId.Text, this.txtPass.Text);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
