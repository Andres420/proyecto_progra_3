using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capadbo;

namespace CapaNegocio
{
    public class Codigo_Reportes
    {

        /// <summary>
        /// This method search in database each of the times hotels have been reserved
        /// </summary>
        /// <returns>And return a list with hotels have been reserved name</returns>
        public ArrayList reporte1()
        {
            DB_Reportes rep = new DB_Reportes();
            ArrayList rep1 = rep.reporte1();
            return rep1;
        }

        /// <summary>
        /// This method search in database the number of people by hotel
        /// </summary>
        /// <returns>And return a list with the number of people by hotel</returns>
        public ArrayList reporte2()
        {
            DB_Reportes rep = new DB_Reportes();
            ArrayList rep2 = rep.reporte2();
            return rep2;
        }

         /// <summary>
        /// This method search in database the number of people by country
        /// </summary>
        /// <returns>And return a list with the number of people by country</returns>
        public ArrayList reporte3()
        {
            DB_Reportes rep = new DB_Reportes();
            ArrayList rep3 = rep.reporte3();
            return rep3;
        }
        /// <summary>
        /// This method search in database the number of adults who have traveled in a range of dates
        /// </summary>
        /// <param name="fechainicio"></param>
        /// <param name="fecha_final"></param>
        /// <returns>And return a list with the number of adults who have traveled in a range of dates</returns>
        public ArrayList reporte4(string fechainicio, string fecha_final)
        {
            DB_Reportes rep = new DB_Reportes();
            ArrayList rep4 = rep.reporte4(fechainicio, fecha_final);
            return rep4;
        }
        /// <summary>
        /// This method search in database the number of children who have traveled in a range of dates
        /// </summary>
        /// <param name="fechainicio"></param>
        /// <param name="fecha_final"></param>
        /// <returns>And return a list with the number of children who have traveled in a range of dates</returns>
        public ArrayList reporte5(string fechainicio, string fecha_final)
        {
            DB_Reportes rep = new DB_Reportes();
            ArrayList rep5 = rep.reporte5(fechainicio, fecha_final);
            return rep5;
        }
        /// <summary>
        /// This method search in database the brands of the most rented vehicles.
        /// </summary>
        /// <returns>And return a list with the brands of the most rented vehicles.</returns>
        public ArrayList reporte6()
        {
            DB_Reportes rep = new DB_Reportes();
            ArrayList rep6 = rep.reporte6();
            return rep6;
        }
        /// <summary>
        /// This method search in database the names of the countries that have been scaled
        /// </summary>
        /// <returns>And return a list with the names of the countries that have been scaled</returns>
        public ArrayList reporte7()
        {
            DB_Reportes rep = new DB_Reportes();
            ArrayList rep7 = rep.reporte7();
            return rep7;
        }
    }
}
