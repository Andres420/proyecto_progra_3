﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Objetos
{
    public class Compra_Reserva
    {
        public Compra_Reserva(int id_reser,int id_usuario, string pais_origen_nom, string pais_destino_nom, string pais_escala_nom, string duracion, int precio_vuelo, DateTime fecha_inicio, DateTime fecha_final, 
            int adultos, int ninos, int habitaciones, int hotel_cod, int hotel_precio, int vehiculo_cod, int vehiculo_precio,bool vuelos,bool hotel,bool vehiculo, bool reserva_compra)
        {
            this.id_reser = id_reser;
            this.id_usuario = id_usuario;
            if (vuelos)
            {
                this.pais_origen_cod = Buscar_cod(pais_origen_nom).ToString();
                this.pais_destino_cod = Buscar_cod(pais_destino_nom).ToString();
                this.pais_escala = Buscar_cod(pais_escala_nom).ToString();
                this.duracion = "'"+duracion+"'";
                this.precio_vuelo = ((precio_vuelo * adultos) + (precio_vuelo * ninos)).ToString();
                this.puntuacion = 1;
            }
            else
            {
                this.pais_origen_cod = "null";
                this.pais_destino_cod = "null";
                this.pais_escala = "null";
                this.duracion = "null";
                this.precio_vuelo = "null";
            }

            this.adultos = adultos.ToString();
            this.ninos = ninos.ToString();
            if (hotel)
            {
                this.hotel_cod = hotel_cod.ToString();
                int dias = (((fecha_final - fecha_inicio).Days) * hotel_precio);
                this.precio_hotel = dias.ToString();
                this.habitaciones = habitaciones.ToString();
                
            }
            else
            {
                this.hotel_cod = "null";
                this.precio_hotel = "null";
                this.habitaciones = "null";
            }
            if (vehiculo)
            {
                int dias = (fecha_final - fecha_inicio).Days * vehiculo_precio;
                this.precio_vehiculo = (dias).ToString();
                this.vehiculo_cod = vehiculo_cod.ToString();

            }
            else
            {
                this.precio_vehiculo = "null";
                this.vehiculo_cod = "null";
            }
            this.fecha_inicio = fecha_inicio.ToString("yyyyMMdd"); 
            this.fecha_final = fecha_final.ToString("yyyyMMdd");
            this.reserva_compra = reserva_compra;
        }

        public int id_reser { get; set; }
        public int id_usuario { get; set; }
        public string pais_origen_cod { get; set; }
        public string pais_destino_cod { get; set; }
        public string pais_escala { get; set; }
        public string duracion { get; set; }
        public string precio_vuelo { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_final { get; set; }
        public string adultos { get; set; }
        public string ninos { get; set; }
        public string habitaciones { get; set; }
        public string hotel_cod { get; set; }
        public string vehiculo_cod { get; set; }
        public bool reserva_compra { get; set; }
        public int puntuacion { get; set; }
        public string precio_vehiculo { get; set; }
        public string precio_hotel { get; set; }

        public string Buscar_cod(string pais_nom)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
            NpgsqlCommand cmd;
            NpgsqlDataReader dr;
            int cod = 0;
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT pa.id_paises FROM paises AS pa WHERE pa.nombre_pais = '" + pais_nom + "';", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    cod = dr.GetInt32(0);
                    dr.Close();
                    conn.Close();
                    return cod.ToString();
                }
                else
                {
                    dr.Close();
                    conn.Close();
                    return "null";
                }
                
            }
            catch (Exception ex)
            {
                conn.Close();
                return "null";
            }
            
        }
    }
}