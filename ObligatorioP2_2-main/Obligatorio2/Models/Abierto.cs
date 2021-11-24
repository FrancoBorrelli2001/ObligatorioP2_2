using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2
{
    class Abierto : Lugar
    {
        //El precio es estático, no varía según el objeto
        private static double PrecioButaca = 170;
        
        public static double GetPrecioButaca()
        {
            return PrecioButaca;
        }

        //Método para cambiar el precio de las butacas para todos los lugares
        public static void SetPrecioButaca(double nuevoPrecioButaca)
        {
            PrecioButaca = nuevoPrecioButaca;
        }


        public override double ObtenerDescuento(double precio)
        {
            if (Dimensiones > 1)
            {
                precio = precio*1.1;
            }
            return precio;
        }




        public Abierto(string nombre,double dimension): base(nombre,dimension) 
        {
           
        }

        //Constructor vacio
        public Abierto() { 

        }


        public override string ToString()
        {
            return base.ToString()+ " - Precio por butaca: "+PrecioButaca ;

        }

    }
}
