﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;
using Objetos;

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
        public void Cargar_AutoCompletar(TextBox txtBuscador_Origen, TextBox txtBuscador_Destino)
        {
            DB_Interfaz_Vuelo db_vuelo = new DB_Interfaz_Vuelo();
            db_vuelo.Cargar_TextBox(txtBuscador_Origen, txtBuscador_Destino);
        }

        public void Buscar_Vuelos(DataGridView dataAeropuertos, string origen, string destino)
        {
            DB_Interfaz_Vuelo db_vuelo = new DB_Interfaz_Vuelo();
            String[] origen_db = origen.Split(',');
            String[] destino_db = destino.Split(',');
            List<Vuelo> list =db_vuelo.Cargar_Vuelos(origen_db[0].ToString(),destino_db[0].ToString());
            dataAeropuertos.DataSource = list;
        }
    }
}
