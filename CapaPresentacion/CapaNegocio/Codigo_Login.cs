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
            NpgsqlDataReader dr = DB_log.Buscar_Usuario_db(cuenta, clave);
            if (dr.HasRows)
            {
                dr.Read();
                int cedula = dr.GetInt32(0);
                string nombre = dr.GetString(1);
                string clave_usu = dr.GetString(2);
                bool tipo = dr.GetBoolean(3);
                usuario = new Usuario(cedula, nombre, clave_usu, tipo);
                return usuario;
            }
            else
            {
                return usuario;
            }
        }
    }
}
