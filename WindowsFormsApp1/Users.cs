using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Users
    {
        public int Id_usuario { get; set; }
        public string nombres { get; set; }
        public string apellidos{ get; set; }
        public string identificacion { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int id_tipoUsuario { get; set; }
        public string carrera { get; set; }
        public string turno { get; set; }
    }
}
