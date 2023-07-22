using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public class ConexionDB
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();

    }
}
