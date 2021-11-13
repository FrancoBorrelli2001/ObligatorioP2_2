 using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2
{
   public class Compra
    {
        public static int UltimoID = 1;
        public int ID_compra { get; }

        public Actividad actividad { get; set; }

        public int cant_Entradas { get; set; }

        public Usuario usuario { get; set; }

        public DateTime fecha_hora_compra { get; set; }

        public bool estado { get; set; }

        public double precio_final { get; set; }

        public Compra( Actividad actividad, int cant_Entradas, Usuario usuario, DateTime fecha_hora_compra)
        {
            ID_compra = UltimoID;
            UltimoID++;
            this.actividad = actividad;
            this.cant_Entradas = cant_Entradas;
            this.usuario = usuario;
            this.fecha_hora_compra = fecha_hora_compra;
            this.estado = true;
            this.precio_final = CalcularPrecioFinal();
        }

        public Compra()
        {

        }

        public override string ToString()
        {
            return "\n" + " - ID: " + ID_compra +
            "\n" + " - Ultimo ID " + UltimoID +
            "\n" + " - Actividad: " + actividad +
            "\n" + " - Cantidad de entradas: " + cant_Entradas +
            "\n" + " - Usuario --> " + usuario +
            "\n" + " - Fecha y hora: " + fecha_hora_compra +
            "\n" + " - Estado: " + estado +
            "\n" + " - Precio final: " + precio_final + "\n";
        }

        public double CalcularPrecioFinal()
        {
            double precioFinal = actividad.CalcularPrecioFinal() * cant_Entradas;
            if (cant_Entradas >= 5)
            {
                precioFinal = precioFinal * 0.85;
            }
            return precioFinal;
          

        }

    }
}