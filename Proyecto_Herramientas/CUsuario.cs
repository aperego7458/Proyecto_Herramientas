using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Herramientas
{
    class CUsuario
    {
        
        SqlConnection conn = new SqlConnection("server=DESKTOP-7ROJSEE;  " +
            "database=ProyectoHerramienta; " +
            "integrated security= true");

        private int _id = 0;
        private string _nombre = "";
        private string _apellido = "";
        private string _direccion = "";
        private int _telefono = 0;
        private string _email = "";
        private string _contrasena = "";
        private int _rol = 0;

        public int ID { get { return _id; } set{ _id = value;} }
        public string Nombre { get { return _nombre; } set{ _nombre = value;} }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public int Telefono { get { return _telefono; } set { _telefono = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Contrasena { get { return _contrasena; } set { _contrasena = value; } }
        public int Rol { get { return _rol; } set { _rol = value; } }
     

        public void GuardarUsuario()
        {
            try
            {
                conn.Open();
                string consulta = "INSERT INTO Usuarios VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand comando = new SqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("p1", ID);
                comando.Parameters.AddWithValue("p2", Nombre);
                comando.Parameters.AddWithValue("p3", Apellido);
                comando.Parameters.AddWithValue("p4", Direccion);
                comando.Parameters.AddWithValue("p5", Telefono);
                comando.Parameters.AddWithValue("p6", Email);
                comando.Parameters.AddWithValue("p7", Contrasena);
                comando.Parameters.AddWithValue("p8", Rol);

                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado!!");
            }
            catch
            {
                MessageBox.Show("Usuario ya existente");
            }
            finally
            {
                conn.Close();
            }
            
        }
        public void ActualizarUsuarios()
        {
            conn.Open();
            string consulta = "UPDATE Usuarios SET ID_DOCUMENTO=@p1, " +
                "NOMBRE=@p2, APELLIDO=@p3, DIRECCION=@p4, " +
                "TELEFONO=@p5, EMAIL=@p6, CONTRASENA=@p7, ROL=@p8 " +
                "WHERE ID_DOCUMENTO=@p9";

            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("p1", ID);
            comando.Parameters.AddWithValue("p2", Nombre);
            comando.Parameters.AddWithValue("p3", Apellido);
            comando.Parameters.AddWithValue("p4", Direccion);
            comando.Parameters.AddWithValue("p5", Telefono);
            comando.Parameters.AddWithValue("p6", Email);
            comando.Parameters.AddWithValue("p7", Contrasena);
            comando.Parameters.AddWithValue("p8", Rol);
            comando.Parameters.AddWithValue("p9", ID);
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}