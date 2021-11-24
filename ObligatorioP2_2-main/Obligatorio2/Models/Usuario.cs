using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Obligatorio2
{
    public class Usuario : IComparable<Usuario>
    {

        public enum Roles
        {
            Cliente, Operador
        }

        private static int UltimoID = 1;
        public int ID_usuario { get; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string nombreUsuario { get; set; }
        public string password { get; set; }
        public Roles rol { get; set; }

        //Constructor para un usuario cliente
        public Usuario(string nombre, string apellido, DateTime fecha_nacimiento, string nombreUsuario, string email, string password)
        {
            ID_usuario = UltimoID;
            UltimoID++;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.fecha_nacimiento = fecha_nacimiento;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.rol = Roles.Cliente;
        }

        //Constructor para usuarios OPERADOR
        public Usuario(string nombre, string apellido, DateTime fecha_nacimiento, string nombreUsuario, string email, string password, Roles rol)
        {
            ID_usuario = UltimoID;
            UltimoID++;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.fecha_nacimiento = fecha_nacimiento;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.rol = rol;
        }


        //Constructor para un usuario nuevo sin identificar
        public Usuario()
        {

        }

        public override string ToString()
        {
            return "\n" + " - ID: " + ID_usuario +
            "\n" + " - Ultimo ID " + UltimoID +
            "\n" + " - Nombre: " + nombre +
            "\n" + " - Apellido: " + apellido +
            "\n" + " - email --> " + email +
            "\n" + " - Edad Minima: " + fecha_nacimiento + "\n";
        }

        public int CompareTo([AllowNull] Usuario other)
        {
            if (this.apellido.CompareTo(other.apellido) > 0)
            {
                return 1;
            }
            else if (this.apellido.CompareTo(other.apellido) < 0)
            {
                return -1;

            }
            else
            {
                if (this.nombre.CompareTo(other.nombre) > 0)
                {
                    return 1;
                }
                else if (this.nombre.CompareTo(other.nombre) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}