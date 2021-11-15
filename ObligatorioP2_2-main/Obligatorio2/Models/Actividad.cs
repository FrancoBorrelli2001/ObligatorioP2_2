using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2
{


    
    public class Actividad
    {

        public enum edad_minima
        {
            P, C13, C16, C18
        }

 

        //Método para cambiar el precio base de todas las actividades
        public static double GetPrecioBase()
        {
            return PrecioBase;
        }

        public static void SetPrecioBase(double nuevoPrecioBase)
        {
            PrecioBase = nuevoPrecioBase;
        }

        //Precio base, el cual es el mismo para todas las actividades
        private static double PrecioBase = 100;

       


        public static int UltimoID=1;
        public int Id_actividad { get; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime Fecha_y_hora { get; set; }
        public Lugar Lugar { get; set; }
        public edad_minima Edad_minima { get; set; }
        public int Cantidad_me_gusta { get; set; }

      


        public Actividad(string nombre, Categoria categoria, DateTime fecha_y_hora, Lugar lugar, edad_minima edad_minima, int cantidad_me_gusta)
        {


            Id_actividad = UltimoID;
            UltimoID++;

            Nombre = nombre;
            Categoria = categoria;
           Fecha_y_hora = fecha_y_hora;
            Lugar = lugar;
            Edad_minima = edad_minima;
            Cantidad_me_gusta = cantidad_me_gusta;
         

        }

        public Actividad()
        {

        }

        public double CalcularPrecioFinal()
        {
            double precioFinal = Lugar.ObtenerDescuento(PrecioBase);
            return Math.Floor(precioFinal);
        }
       


        public override string ToString()
        {
            return  "\n" +
            "\n" + " - ID: " + Id_actividad +
            "\n" + " - Nombre: " + Nombre +
            "\n" + " - Categoría --> " + Categoria.ToString() +
            "\n" + " - Fecha: " + Fecha_y_hora +
            "\n" + " - Lugar --> " + Lugar.ToString() +
            "\n" + " - Edad Minima: " + Edad_minima +            
            "\n" + " - Cantidad de me gusta: " + Cantidad_me_gusta + "\n";
        }




    }
}
