using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Codigo_Interfaz_Vuelo
    {
        public string Cantidad_Habitaciones(int adultos, int ninos)
        {
            int habitaciones = 0;
            int personas = (adultos + ninos);
            while(true)
            {
                if (personas <= 0)
                {
                    break;
                }
                else if (personas > 0)
                {
                    habitaciones += 1;
                    personas -= 4;
                }
            }
            return habitaciones.ToString();
        }
    }
}
