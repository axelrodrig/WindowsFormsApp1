using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1
{

    ///***
    // * Clase para los metodos de INSERT, UPDATE, DELETE, SELECT
    // * de la tabla Usuario_sistema
    ///***
    public class CD_Usuario
    {
        public DataTable leerUsuarioSistema(string nombre)
        {
            SqlDataAdapter adaptador;
            DataTable dtusuariosistema;

            using (SqlConnection oconexion = new SqlConnection(ConexionDB.cadena))
            {
                try
                {
                    string consulta = "SELECT clave FROM Usuario_sistema WHERE usuarios='" +nombre + "';";
                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = cmd;
                    dtusuariosistema = new DataTable();
                    adaptador.Fill(dtusuariosistema);
                    return dtusuariosistema;
                }
                catch (Exception)
                {

                    MessageBox.Show("Error en la consulta", "Error");
                    return null;
                }
            }
                
        }
    }
}
