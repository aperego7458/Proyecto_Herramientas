using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_Herramientas
{
    class CBienes
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-U6MQJK7;  database=ProyectoHerramienta; integrated security= true");

        private string _ciudad = "";
        private string _direccion = "";
        private int _Chabitaciones = 0;
        private int _Cbanos = 0;
        private int _precio = 0;
        private string _fotos = "";
        private int _agencia = 0;


        public string Ciudad { get { return _ciudad; } set { _ciudad = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public int CHabitaciones { get { return _Chabitaciones; } set { _Chabitaciones = value; } }
        public int CBanos { get { return _Cbanos; } set { _Cbanos = value; } }
        public int Precio { get { return _precio; } set { _precio = value; } }
        public string Fotos { get { return _fotos; } set { _fotos = value; } }
        public int Agencia { get { return _agencia; } set { _agencia = value; } }

        public void GuardarBienes()
        {
            conn.Open();
            string consulta = "INSERT INTO Propiedades VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("p1", Ciudad);
            comando.Parameters.AddWithValue("p2", Direccion);
            comando.Parameters.AddWithValue("p3", CHabitaciones);
            comando.Parameters.AddWithValue("p4", CBanos);
            comando.Parameters.AddWithValue("p5", Precio);
            comando.Parameters.AddWithValue("p6", Fotos);
            comando.Parameters.AddWithValue("p7", Agencia);
            comando.ExecuteNonQuery();

            conn.Close();
        }




    }
}
