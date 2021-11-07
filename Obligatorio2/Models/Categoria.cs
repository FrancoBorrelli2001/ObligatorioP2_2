using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2
{
    public class Categoria
    {
        public enum TiposCategoria
        {
            cine, teatro,concierto,feria_gastronomica
        }

        public static int UltimoID = 1;
        public int ID { get; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TiposCategoria TipoCategoria { get; set; }

        
        
        
        public Categoria(string nombre, string descripcion, TiposCategoria tipo)
        {
            ID = UltimoID;
            UltimoID++;
            Nombre = nombre;
            Descripcion = descripcion;
            TipoCategoria = tipo;
        }

        public Categoria()
        {

        }
        public override string ToString()
        {
            return "ID: "+ ID+ " Nombre: " + Nombre + "- Descripcion: " + Descripcion + "- Tipo Categoria: " + TipoCategoria; 
        }

    }
}
