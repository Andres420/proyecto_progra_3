using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;
namespace CapaNegocio
{
    public class Codigo_CRUD_Hoteles
    {
        /// <summary>
        /// This method charge information of the combobox of countries and places
        /// </summary>
        /// <param name="cBox_Pais"></param>
        /// <param name="cBox_Lugar"></param>
        public void Cargar_Combos(ComboBox cBox_Pais, ComboBox cBox_Lugar)
        {
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            List<string> lista_paises = db_hoteles.Info_Combo_Pais();
            foreach (string name in lista_paises)
            {
                cBox_Pais.Items.Add(name);
            }
            List<string> lista_lugar = db_hoteles.Info_Combo_Lugares();
            foreach (string name in lista_lugar)
            {
                cBox_Pais.Items.Add(name);
            }
        }

        public bool Agregar_Hotel(string nombre, string imagen, string pais, string lugar, string habitaciones,  string costo)
        {
            bool agregado;
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            int cod_tarifa = db_hoteles.Buscar_Tarifa(costo);
            if (cod_tarifa == 0)
            {
                cod_tarifa = db_hoteles.Agregar_Tarifa(costo);
                agregado = db_hoteles.Agregar_Hotel(nombre, imagen, pais, lugar, habitaciones, cod_tarifa);
            }
            else
            {
                agregado = db_hoteles.Agregar_Hotel(nombre, imagen, pais, lugar, habitaciones, cod_tarifa);
            }
            return agregado;
        }
    }
}
