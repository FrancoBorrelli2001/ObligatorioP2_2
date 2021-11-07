using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2
{
    public abstract class Lugar
    {
        private static int UltimoID = 1;
        public int IdLugar { get; }
        public string Nombre { get; set; }
        public double Dimensiones { get; set; }






         public Lugar(string nombre, double dimension)
        {

            IdLugar = UltimoID;
            UltimoID++;
            Nombre = nombre;
            Dimensiones = dimension;
        }

        //Constructor vacio de Lugar, IMPORTANTE para crear constructores vacios en Objetos Abierto y Cerrado
        public Lugar()
        {

        }

        public override string ToString()
        {
            return "ID de lugar: " + IdLugar + "- Nombre: " + Nombre + "- Dimensiones: " + Dimensiones + "mt2";
        }

      
        public abstract double ObtenerDescuento(double precio);
        
        

    }
}
