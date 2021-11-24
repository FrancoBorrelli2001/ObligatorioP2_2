using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2
{
    public class Cerrado : Lugar
    {

        //Valor aforo máximo (0-100)
        private static int AforoMaximo = 100;

        public bool Accesibilidad_total { get; set; }
        public int Mantenimiento { get; set; }
        public double PrecioButaca { get; set; }

        public static int GetAforoMaximo()
        {
            return AforoMaximo;
        }

        public static void SetAforoMaximo(int nuevoAforo)
        {
            AforoMaximo = nuevoAforo;
        }

        public Cerrado(string nombre, double dimension, bool accesibilidad_total, int mantenimiento, double precioButaca) : base(nombre, dimension)
        {
            Accesibilidad_total = accesibilidad_total;
            Mantenimiento = mantenimiento;
            PrecioButaca = precioButaca;

        }

        public Cerrado()
        {

        }

        public override double ObtenerDescuento(double precio)
        {
            if (AforoMaximo < 50)
            {
                precio = precio * 1.3;
            }
            else if (AforoMaximo > 50 && AforoMaximo < 70)
            {
                precio = precio * 1.15;
            }
            return precio;
        }

        public override string ToString()
        {
            string tieneA;
            if (Accesibilidad_total)
            {
                tieneA = "Si";
            }
            else
            {
                tieneA = "No";
            }
            return base.ToString() + "- Precio butaca: " + PrecioButaca + "- Mantenimiento: " + Mantenimiento + "- Acessibilidad: " + tieneA + "- Aforo Máximo: " + AforoMaximo;
        }
    }
}
