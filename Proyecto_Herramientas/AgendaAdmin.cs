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
    public partial class AgendaAdmin : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-7ROJSEE;  " +
            "database=ProyectoHerramienta; " +
            "integrated security= true");

        public int id_agenda = 0;
        public AgendaAdmin()
        {
            InitializeComponent();
            Leer();
            LeerPropiedad();
            LeerCitas();
        }

        public void limpiar()
        {
            txtIdAgenda.Clear();
            txtIDBienes.Clear();
            txtIdlog.Clear();
        }

        public void LeerCitas()
        {
            conn.Open();
            string Consulta = "SELECT * FROM Agenda";
            SqlCommand comando = new SqlCommand(Consulta, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable resultado = new DataTable();
            adapter.Fill(resultado);
            dgvCitas.DataSource = resultado;
            conn.Close();
            limpiar();
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
            dgvClientes.DataSource = resultado;
            conn.Close();
        } 

        public void LeerPropiedad()
        {
            conn.Open();
            string Consulta = "SELECT * FROM Propiedades";
            SqlCommand comando = new SqlCommand(Consulta, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable resultado = new DataTable();
            adapter.Fill(resultado);
            dgvInmuebles.DataSource = resultado;
            conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int i = 0, n = dgvClientes.Rows.Count - 1;

            if (n > 0)
            {
                for (i = 0; i < n; i++)
                {
                    DataGridViewRow fila = this.dgvClientes.Rows[i];

                    if (txtIdlog.Text == fila.Cells[0].Value.ToString())
                    {
                        txtIdlog.Text = fila.Cells[0].Value.ToString();
                        MessageBox.Show("ID encontrado!!");
                        break;
                    }
                }
                if (i == n)
                {
                    MessageBox.Show("ID no encontrado!!");
                }
            }
           
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            int i = 0, n = dgvInmuebles.Rows.Count - 1;

            if (n > 0)
            {
                for (i = 0; i < n; i++)
                {
                    DataGridViewRow fila = this.dgvInmuebles.Rows[i];

                    if (txtIDBienes.Text == fila.Cells[0].Value.ToString())
                    {
                        txtIDBienes.Text = fila.Cells[0].Value.ToString();
                        MessageBox.Show("ID encontrado!!");
                        break;
                    }
                }
                if (i == n)
                {
                    MessageBox.Show("ID no encontrado!!");
                }
            }
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.dgvCitas.Rows[e.RowIndex];

                txtIdAgenda.Text = fila.Cells[0].Value.ToString();
                txtIdlog.Text = fila.Cells[1].Value.ToString();
                txtIDBienes.Text = fila.Cells[2].Value.ToString();
                dtpCita.Text = fila.Cells[3].Value.ToString();
                cbHora.Text = fila.Cells[4].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
            LeerCitas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string consulta = "DELETE FROM Agenda WHERE ID_AGENDA=@p1";
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("p1", txtIdAgenda.Text);
            comando.ExecuteNonQuery();
            conn.Close();
            LeerCitas();
        }

        private void btnBuscarAgenda_Click(object sender, EventArgs e)
        {
            int i = 0, n = dgvCitas.Rows.Count - 1;

            if (n > 0)
            {
                for (i = 0; i < n; i++)
                {
                    DataGridViewRow fila = this.dgvCitas.Rows[i];

                    if (txtIdAgenda.Text == fila.Cells[0].Value.ToString())
                    {
                        id_agenda = Convert.ToInt32(fila.Cells[0].Value);
                        txtIdAgenda.Text = id_agenda.ToString();
                        txtIdlog.Text = fila.Cells[1].Value.ToString();
                        txtIDBienes.Text = fila.Cells[2].Value.ToString();
                        dtpCita.Text = fila.Cells[3].Value.ToString();
                        cbHora.Text = fila.Cells[4].Value.ToString();
                        break;
                    }
                }
                if (i == n)
                {
                    MessageBox.Show("ID no encontrado!!");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string consulta = "UPDATE Agenda SET CLIENTE=@p1, " +
                "ID_BIENES=@p2, FECHA=@p3, HORA=@p4 " +
                "WHERE ID_AGENDA=@p5";
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("p1", txtIdlog.Text);
            comando.Parameters.AddWithValue("p2", txtIDBienes.Text);
            comando.Parameters.AddWithValue("p3", dtpCita.Text);
            comando.Parameters.AddWithValue("p4", cbHora.Text);
            comando.Parameters.AddWithValue("p5", txtIdAgenda.Text);
            comando.ExecuteNonQuery();
            conn.Close();
            LeerCitas();

            MessageBox.Show("Agenda modificada correctamente...");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Opciones v1 = new Opciones();
            v1.Show();
            this.Hide();
        }

        private void txtIdlog_Validated(object sender, EventArgs e)
        {
            if (txtIdlog.Text.Trim() == "")
            {
                epError.SetError(txtIdlog, "Introducir el id...");
                txtIdlog.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtIDBienes_Validated(object sender, EventArgs e)
        {
            if (txtIDBienes.Text.Trim() == "")
            {
                epError.SetError(txtIDBienes, "Introducir el id...");
                txtIDBienes.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void cbHora_Validated(object sender, EventArgs e)
        {
            if (cbHora.Text.Trim() == "")
            {
                epError.SetError(cbHora, "Introducir la hora...");
                cbHora.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
