using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio2
{
    class Sistema
    {

        //Listas de objetos a usar en el sistema

        public List<Lugar> ListaLugares = new List<Lugar>();
        public List<Actividad> ListaActividades = new List<Actividad>();
        public List<Categoria> ListaCategorias = new List<Categoria>();
        public List<Compra> ListaCompras = new List<Compra>();
        public List<Usuario> ListaUsuarios = new List<Usuario>();

        //Metodos para retornar listas

        public List<Lugar> GetLugares()
        {
            return ListaLugares;
        }

        public List<Actividad> GetActividades()
        {
            return ListaActividades;
        }

        public List<Categoria> GetCategorias()
        {
            return ListaCategorias;
        }

        public List<Usuario> GetUsuarios()
        {
            return ListaUsuarios;
        }

        //Retorna usuarios con rol cliente
        internal List<Usuario> GetClientes()
        {
            List<Usuario> Clientes = new List<Usuario>();

            foreach (Usuario usu in ListaUsuarios)
            {
                if (usu.rol == Usuario.Roles.Cliente)
                {
                    Clientes.Add(usu);
                }
            }
            return Clientes;
        }


        //Singleton
        private static Sistema instancia = null;

        public static Sistema GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Sistema();
            }
            return instancia;
        }



        //Métodos para agregar objetos a la lista, validando sus datos previamente

        //Lugares ABIERTOS
        public Lugar AltaLugar(string nombre, double dimensiones)
        {
            Lugar resu = null;
            bool OK = true;

            //Validaciones de parametros
            if (nombre == null) { OK = false; }
            if (dimensiones == 0) { OK = false; }

            //Si ya existe un lugar con el mismo nombre, no crea el objeto
            foreach (Lugar a in ListaLugares)
            {
                if (a.Nombre == nombre)
                {
                    OK = false;
                }
            }

            //Si todo es correcto agrega el objeto a la lista y lo retorna
            if (OK)
            {
                Abierto l = new Abierto(nombre, dimensiones);
                ListaLugares.Add(l);
                return l;
            }
            else
            {
                return resu;
            }
        }


        //Lugares Cerrados
        public Lugar AltaLugar(string nombre, double dimensiones, bool accesibilidadTotal, int mantenimiento, double precio_butaca)
        {
            Lugar resu = null;
            bool OK = true;

            //Validaciones de parametros
            if (nombre == null) { OK = false; }
            if (dimensiones == 0) { OK = false; }
            if (mantenimiento == 0) { OK = false; }
            if (precio_butaca == 0) { OK = false; }

            //Validación de existencia de lugar con mismo nombre
            foreach (Lugar c in ListaLugares)
            {
                if (c.Nombre == nombre)
                {
                    OK = false;

                }
            }

            //Si todo es correcto agrega el objeto a la lista y lo retorna
            if (OK)
            {
                Cerrado c = new Cerrado(nombre, dimensiones, accesibilidadTotal, mantenimiento, precio_butaca);
                ListaLugares.Add(c);
                return c;
            }
            //Si hay un error NO crea el objeto y retorna null
            else
            {
                return resu;
            }
        }


        public Categoria AltaCategoria(string nombre, string descripcion, Categoria.TiposCategoria tipoCategoria)
        {
            Categoria resu = null;
            bool OK = true;

            if (nombre == null) { OK = false; }
            if (descripcion == null) { OK = false; }

            //Validacion de existencia de dos categorias con el mismo nombre
            foreach (Categoria c in ListaCategorias)
            {
                if (c.Nombre == nombre)
                {
                    OK = false;
                }
            }


            if (OK)
            {
                Categoria c = new Categoria(nombre, descripcion, tipoCategoria);
                ListaCategorias.Add(c);
                return c;
            }
            else
            {
                return resu;
            }
        }

        public Actividad AltaActividad(string nombre, Categoria categoria, DateTime fecha, Lugar lugar, Actividad.edad_minima edadMinima, int cantMG)
        {
            Actividad resu = null;
            bool OK = true;

            if (nombre == null) { OK = false; }
            if (fecha == null) { OK = false; }

            if (fecha < DateTime.Now)
            {
                OK = false;
            }


            if (OK)
            {
                Actividad a = new Actividad(nombre, categoria, fecha, lugar, edadMinima, cantMG);
                ListaActividades.Add(a);
                return a;
            }
            else
            {
                return resu;
            }

        }

        //Alta usuario Cliente
        public Usuario AltaUsuario(string nombre, string apellido, string email, DateTime fechaNacimiento, string nombreUsuario, string password)
        {
            Usuario resu = null;
            bool OK = true;

            if (nombre == null) { OK = false; }
            if (apellido == null) { OK = false; }
            if (email == null) { OK = false; }
            if (fechaNacimiento == null) { OK = false; }
            if (nombreUsuario == null) { OK = false; }
            if (password == null) { OK = false; }

            //Nombre y Apellido con 2 caracteres
            if (nombre.Length <= 2 || apellido.Length <= 2) { OK = false; }

            //Contraseña con mas de 6 caracteres
            if (password.Length <= 6) { OK = false; }

            //Validamos que la fecha de nacimiento sea anterior a la actual
            if (fechaNacimiento > DateTime.Now) { OK = false; }

            //Validacion si el nombre de usuario y el email son unicos
            foreach (Usuario usu in ListaUsuarios)
            {
                if (usu.nombreUsuario == nombreUsuario || usu.email == email)
                {
                    OK = false;
                }
            }

            //Si no hay atributos nulos entra 
            if (OK)
            {
                //Si el email esta correcto crea el usuario
                if (ValidarPassword(password))
                {
                    Usuario u = new Usuario(nombre, apellido, fechaNacimiento, nombreUsuario, email, password);
                    ListaUsuarios.Add(u);
                    return u;
                }
                else
                {
                    //Sino retorna null
                    return resu;
                }
            }
            else
            {
                //Sino retorna null
                return resu;
            }
        }

        //Segunda validacion de contraseña. Letra mayuscula, letra minuscula, digito
        internal bool ValidarPassword(string pass)
        {
            bool resu = true;

            if (!pass.Any(char.IsUpper) || !pass.Any(char.IsLower) || !pass.Any(char.IsDigit))
            {
                resu = false;
            }
            return resu;
        }


        public Compra AltaCompra(Actividad actividad, int cantEntradas, Usuario usuario, DateTime fechaCompra)
        {
            Compra resu = null;
            bool OK = true;

            if (cantEntradas <= 0) { OK = false; }


            if (OK)
            {
                Compra c = new Compra(actividad, cantEntradas, usuario, fechaCompra);
                ListaCompras.Add(c);
                return c;
            }
            else
            {
                return resu;
            }
        }


        //Metodos del sistema

        //Obtener Precio Base de Actividades
        internal double GetPrecioBaseActividad()
        {
            return Actividad.GetPrecioBase();
        }


        //Cambiar Precio Base Actividades
        internal bool SetPrecioBaseActividad(double nuevoPrecio)
        {
            if (nuevoPrecio >= 0)
            {
                Actividad.SetPrecioBase(nuevoPrecio);
                return true;
            }
            else
            {
                return false;
            }
        }


        //Obtener Compras segun cliente
        internal List<Compra> ObtenerComprasSegunCliente(int? id)
        {
            List<Compra> resu = new List<Compra>();
            foreach (Compra com in ListaCompras)
            {
                if (com.usuario.ID_usuario.Equals(id))
                {
                    resu.Add(com);
                }
            }
            return resu;
        }

        //Obtener compras a cancelar
        internal List<Compra> ObtenerComprasACancelar()
        {
            List<Compra> resu = new List<Compra>();
            foreach (Compra com in ListaCompras)
            {
                var hours = (com.actividad.Fecha_y_hora - DateTime.Now).TotalHours;
                //Solo agregra las actividades que tienen una diferencia de 24 horas
                if (hours > 24)
                {
                    resu.Add(com);
                }
            }
            return resu;
        }

        internal void DarMG(int id)
        {
            foreach (Actividad act in ListaActividades)
            {
                if (act.Id_actividad.Equals(id))
                {
                    act.Cantidad_me_gusta++;
                }
            }
        }


        //Cambia el aforo máximo
        public bool CambiarAforoMaximo(int nuevoAforo)
        {
            bool resu = false;

            if (nuevoAforo >= 0 && nuevoAforo <= 100)
            {
                Cerrado.SetAforoMaximo(nuevoAforo);
                resu = true;
            }
            return resu;
        }


        //Cambiar el precio de las butacas
        public bool CambiarPrecioButacas(double nuevoPrecioButacas)
        {
            bool resu = false;
            if (nuevoPrecioButacas > 0)
            {
                Abierto.SetPrecioButaca(nuevoPrecioButacas);
                resu = true;
            }
            return resu;
        }



        //Retorna las actividades asociadas a una categoria y en un rango de fechas
        public List<Actividad> ListarActividadesSegunCategoriaYFecha(string nombreCategoria, DateTime fecha1, DateTime fecha2)
        {
            List<Actividad> resu = new List<Actividad>();

            foreach (Actividad a in ListaActividades)
            {
                if (a.Categoria.Nombre == nombreCategoria && a.Fecha_y_hora > fecha1 && a.Fecha_y_hora < fecha2)
                {
                    resu.Add(a);
                }
            }
            return resu;
        }


        //Retorna las compras realizadas en un rango de fechas
        internal List<Compra> ListarComprasSegunFechas(DateTime fecha1, DateTime fecha2)
        {
            List<Compra> resu = new List<Compra>();

            foreach (Compra c in ListaCompras)
            {
                if (c.fecha_hora_compra > fecha1 && c.fecha_hora_compra < fecha2)
                {
                    resu.Add(c);
                }
            }
            return resu;
        }

        internal double ObtenerPrecioTotalDeCompras(List<Compra> compras)
        {
            double resu = 0;
            foreach (Compra com in compras)
            {
                resu = resu + com.CalcularPrecioFinal();
            }
            return resu;

        }


        //Retorna las actividades que coincidan con un lugar
        internal List<Actividad> ObtenerActividadesSegunLugar(string nombre)
        {
            List<Actividad> resu = new List<Actividad>();

            foreach (Actividad act in ListaActividades)
            {
                if (act.Lugar.Nombre == nombre)
                {
                    resu.Add(act);
                }
            }
            return resu;
        }



        //Retorna las actividades para todo publico
        public List<Actividad> ObtenerActividadesTodoPublico()
        {
            List<Actividad> resu = new List<Actividad>();

            foreach (Actividad a in ListaActividades)
            {
                if (a.Edad_minima == Actividad.edad_minima.P)
                {
                    resu.Add(a);
                }
            }
            return resu;
        }

        //Retorna la o las compras de mayor valor
        public List<Compra> ObtenerComprasMayorValor()
        {
            double mayor = 0;
            List<Compra> resu = new List<Compra>();

            foreach (Compra compra in ListaCompras)
            {
                if (compra.CalcularPrecioFinal() > mayor)
                {
                    mayor = compra.CalcularPrecioFinal();
                    resu.Clear();
                    resu.Add(compra);

                }
                else if (compra.CalcularPrecioFinal() == mayor)
                {
                    resu.Add(compra);
                }
            }
            return resu;
        }

        //Obtiene el aforo máximo actual
        internal int GetAforoMaximo()
        {
            return Cerrado.GetAforoMaximo();
        }


        //Cambia el Aforo máximo
        internal bool SetAforoMaximo(int nuevoAforo)
        {
            bool resu = false;

            if (nuevoAforo >= 0 && nuevoAforo <= 100)
            {
                Cerrado.SetAforoMaximo(nuevoAforo);
                resu = true;
            }
            return resu;
        }


        //Obtiene el precio de las butacas al aire libre
        internal double GetPrecioButacas()
        {
            return Abierto.GetPrecioButaca();
        }

        //Cambia el precio de las butacas al aire libre

        internal bool SetPrecioButacas(double nuevoPrecio)
        {
            if (nuevoPrecio >= 0)
            {
                Abierto.SetPrecioButaca(nuevoPrecio);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Buscar actividades por ID
        internal Actividad BuscarActividad(int id)
        {
            Actividad resu = null;
            foreach (Actividad a in ListaActividades)
            {
                if (a.Id_actividad.Equals(id))
                {
                    resu = a;
                }
            }
            return resu;
        }


        //Buscar usuario por ID
        internal Usuario BuscarUsuario(int? id)
        {
            Usuario resu = null;
            foreach (Usuario usu in ListaUsuarios)
            {
                if (usu.ID_usuario.Equals(id))
                {
                    resu = usu;
                }
            }
            return resu;
        }

        //Buscar compra por ID
        internal Compra BuscarCompra(int? id)
        {
            Compra resu = null;
            foreach (Compra com in ListaCompras)
            {
                if (com.ID_compra.Equals(id))
                {
                    resu = com;
                }
            }
            return resu;
        }

        //Elimina la compra
        internal bool CancelarCompra(int id)
        {
            bool eliminado = false;

            for (int i = 0; i < ListaCompras.Count; i++)
            {
                if (ListaCompras[i].ID_compra.Equals(id))
                {
                    ListaCompras.RemoveAt(i);
                    eliminado = true;
                }
            }
            return eliminado;
        }


        //Obtener usuario segun su email y password
        internal Usuario LoginUsuario(string nombreUsuario, string password)
        {
            Usuario resu = null;

            //Buscamos si el usuario esta en la lista de usuarios 
            foreach (Usuario usu in ListaUsuarios)
            {
                if (usu.nombreUsuario == nombreUsuario && usu.password == password)
                {
                    resu = usu;
                }
            }
            return resu;
        }



        //PRECARGA DE DATOS EN EL CONSTRUCTOR 
        public Sistema()
        {
            Precarga();
        }


        internal void Precarga()
        {

            //Lugares abiertos
            AltaLugar("Andre Rieu", 50);
            AltaLugar("Teatro de Verano", 80);
            AltaLugar("Rural del prado", 200);
            AltaLugar("Velodromo", 150);
            AltaLugar("Estadio Centenario", 200);

            //Lugares cerrados
            AltaLugar("Teatro Solis", 1200, true, 90, 200);
            AltaLugar("Castillo Pittamiglio", 500, false, 40, 300);
            AltaLugar("Teatro Metro", 3000, false, 50, 800);
            AltaLugar("Antel Arena", 3500, false, 80, 150);
            AltaLugar("Cinema center", 1000, false, 90, 200);

            // Categorías
            AltaCategoria("Cine", "cine", Categoria.TiposCategoria.cine);
            AltaCategoria("Teatro", "teatro", Categoria.TiposCategoria.teatro);
            AltaCategoria("Musica", "Musical", Categoria.TiposCategoria.concierto);
            AltaCategoria("Gastronomia", "Gastronomica", Categoria.TiposCategoria.feria_gastronomica);

            //Actividades
            //DateTime fechaConHora = new DateTime(2022, 4, 23, 0, 0, 0);
            //DateTime fechaConHora2 = new DateTime(2023, 5, 12, 0, 0, 0);
            //DateTime fechaConHora3 = new DateTime(2024, 6, 07, 0, 00, 0);
            //DateTime fechaConHora4 = new DateTime(2022, 8, 11, 0, 30, 0);

            //Actividades en lugares abiertos 
            AltaActividad("Rockfest ", ListaCategorias[2], DateTime.Now.AddDays(15), ListaLugares[4], Actividad.edad_minima.C13, 107);
            AltaActividad("Cuarteto de Nos ", ListaCategorias[2], DateTime.Now.AddDays(10), ListaLugares[3], Actividad.edad_minima.C18, 603);
            AltaActividad("Pilsen Rock ", ListaCategorias[2], DateTime.Now.AddDays(7), ListaLugares[4], Actividad.edad_minima.P, 3045);
            AltaActividad("Gastro Open Air ", ListaCategorias[3], DateTime.Now.AddDays(3), ListaLugares[2], Actividad.edad_minima.C13, 500);
            AltaActividad("Jazz en el teatro ", ListaCategorias[2], DateTime.Now.AddDays(1), ListaLugares[1], Actividad.edad_minima.P, 1000);

            //Actividades en lugares cerrados
            AltaActividad("The Stand Up Show ", ListaCategorias[1], DateTime.Now.AddDays(9), ListaLugares[7], Actividad.edad_minima.C16, 48);
            AltaActividad("Sinfonica Uruguaya ", ListaCategorias[2], DateTime.Now.AddDays(20), ListaLugares[5], Actividad.edad_minima.P, 609);
            AltaActividad("Rapido y Furioso 30 (Brian lives) ", ListaCategorias[0], DateTime.Now.AddDays(2), ListaLugares[9], Actividad.edad_minima.P, 2);
            AltaActividad("Semana de la Arepa ", ListaCategorias[3], DateTime.Now.AddDays(3), ListaLugares[6], Actividad.edad_minima.C16, 1);
            AltaActividad("TOC TOC ", ListaCategorias[1], DateTime.Now.AddDays(1), ListaLugares[7], Actividad.edad_minima.P, 15);
            AltaActividad("Los Buitres ", ListaCategorias[2], DateTime.Now.AddDays(10), ListaLugares[7], Actividad.edad_minima.P, 1509);

            DateTime fechaConHoraUsuario1 = new DateTime(1999, 8, 11, 0, 0, 0);
            DateTime fechaConHoraUsuario2 = new DateTime(1989, 8, 09, 0, 0, 0);
            DateTime fechaConHoraUsuario3 = new DateTime(2001, 4, 12, 0, 0, 0);
            DateTime fechaConHoraUsuario4 = new DateTime(2012, 3, 08, 0, 0, 0);
            DateTime fechaConHoraUsuario5 = new DateTime(1978, 2, 03, 0, 0, 0);

            //Clientes
            AltaUsuario("Bruno", "Borrelli", "Bruno@gmail.com", fechaConHoraUsuario1, "BruB", "Ab123456");
            AltaUsuario("Franco", "Borrelli", "Franco@gmail.com", fechaConHoraUsuario1, "FranB", "Ab123456");
            AltaUsuario("Cristian", "Poggi", "Cristian@gmail.com", fechaConHoraUsuario3, "CrisC", "Ab123456");
            AltaUsuario("Clotilde", "Fernandez", "Clotilde@gmail.com", fechaConHoraUsuario3, "CloF", "Ab123456");
            AltaUsuario("Agustina", "Fernandez", "Agustina@gmail.com", fechaConHoraUsuario3, "AgusF", "Ab123456");

            //Operadores
            Usuario operador1 = new Usuario("Joaquin", "Rodriguez", fechaConHoraUsuario2, "Admin1", "Joaquin@gmail.com", "Ab123456", Usuario.Roles.Operador);
            Usuario operador2 = new Usuario("Rafael", "Cohen", fechaConHoraUsuario1, "Admin2", "Rafael@gmail.com", "Ab123456", Usuario.Roles.Operador);
            ListaUsuarios.Add(operador1);
            ListaUsuarios.Add(operador2);

            //Compras
            AltaCompra(ListaActividades[1], 2, ListaUsuarios[1], DateTime.Today);
            AltaCompra(ListaActividades[3], 2, ListaUsuarios[2], DateTime.Today);
            AltaCompra(ListaActividades[4], 2, ListaUsuarios[2], DateTime.Today);
            AltaCompra(ListaActividades[7], 2, ListaUsuarios[2], DateTime.Today);
            AltaCompra(ListaActividades[2], 2, ListaUsuarios[3], DateTime.Today);
            AltaCompra(ListaActividades[9], 2, ListaUsuarios[3], DateTime.Today);
            AltaCompra(ListaActividades[8], 2, ListaUsuarios[4], DateTime.Today);
            AltaCompra(ListaActividades[7], 2, ListaUsuarios[4], DateTime.Today);
        }
    }
}
