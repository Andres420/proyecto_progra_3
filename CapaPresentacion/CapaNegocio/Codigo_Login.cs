using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos;
using Capadbo;
using Npgsql;

namespace CapaNegocio
{
    public class Codigo_Login
    {
        public Usuario Buscar_Usuario(string cuenta, string clave)
        {
            Usuario usuario = null;
            DB_Login DB_log = new DB_Login();
            object[] arreglo = DB_log.Buscar_Usuario_db(cuenta, clave);
            if(arreglo != null)
            {
                usuario = new Usuario((int)arreglo[0], (string)arreglo[1], (string)arreglo[2], (bool)arreglo[3]);
                return usuario;
            }
            else
            {
                return usuario;
            }
                
        }
    }
}
