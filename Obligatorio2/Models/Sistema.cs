using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio2
{
    class Sistema
    {


        //------------------------Creo las listas de objetos a utilizar en el sistema-------------------

        public List<Lugar> ListaLugares = new List<Lugar>();
        public List<Actividad> ListaActividades = new List<Actividad>();
        public List<Categoria> ListaCategorias = new List<Categoria>();
        public List<Compra> ListaCompras = new List<Compra>();
        public List<Usuario> ListaUsuarios = new List<Usuario>();
        


        //------------------------Métodos para retornar las listas de objetos----------------------------
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
       







        //-------------------------Métodos para agregar objetos a la lista, validando sus datos previamente-----------------------------------

        //para lugares ABIERTOS
        public Lugar AltaLugar(string nombre, double dimensiones)
        {
            Lugar resu = null;
            bool OK = true;

            //VALIDACIONES de parametros
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
            //Si hay un error NO crea el objeto y retorna null
            else
            {
                return resu;
            }
        }


        //para lugares CERRADOS
        public Lugar AltaLugar(string nombre, double dimensiones, bool accesibilidadTotal, int mantenimiento, double precio_butaca)
        {
            Lugar resu = null;
            bool OK = true;

            //VALIDACIONES de parametros
            if (nombre == null) { OK = false; }
            if (dimensiones == 0) { OK = false; }
            if (mantenimiento == 0) { OK = false; }
            if (precio_butaca == 0) { OK = false; }

            //Verifico que no exista otro lugar con el mismo nombre
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

            //Verifico que no existan dos categorias con el mismo nombre
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

        //Alta usuario CLIENTE
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


            if (OK)
            {
                Usuario u = new Usuario(nombre, apellido, fechaNacimiento, nombreUsuario, email, password);
                ListaUsuarios.Add(u);
                return u;
            }
            else
            {
                return resu;
            }

        }
        public Compra AltaCompra(Actividad actividad, int cantEntradas, Usuario usuario, DateTime fechaCompra, bool estado)
        {
            Compra resu = null;
            bool OK = true;



            if (usuario == null) { OK = false; }


            if (OK)
            {
                Compra c = new Compra(actividad, cantEntradas, usuario, fechaCompra, estado);
                ListaCompras.Add(c);
                return c;
            }
            else
            {
                return resu;
            }
        }




        //------------------Métodos del sistema---------------------------------------------------


        //Cambia el usuario de tipo SIN IDENTIFICAR a CLIENTE

       
       
        internal bool ValidarCedula(string cedula)
        {
            bool Mayuscula = false;
            bool Minuscula = false;
            bool dijito = false;

            for(int i = 0; i < cedula.Length; i++)
            {
               
            }
            return false;
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


        



        //Método para cambiar el precio de las butacas
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
        public List<Actividad> ListarActividadesSegunCategoriaYFecha(int IDcategoria, DateTime fecha1, DateTime fecha2) 
        {
            List<Actividad> resu = new List<Actividad>();

            foreach(Actividad a in ListaActividades)
            {
               
                if (a.Categoria.ID == IDcategoria && a.Fecha_y_hora>fecha1 && a.Fecha_y_hora<fecha2)
                {
                    resu.Add(a);
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

        internal Actividad BuscarActividad(int id)
        {
            Actividad resu = null;
            foreach(Actividad a in ListaActividades)
            {
                if (a.Id_actividad == id)
                {
                    resu = a; ;
                }
            }
            return resu;
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


        //Obtener usuario segun su email y password
        internal Usuario LoginUsuario(string email,string password)
        {
            Usuario resu = null;
            //Buscamos si el usuario esta en la lista de usuarios normales
            foreach(Usuario usu in ListaUsuarios)
            {
                if(usu.email==email && usu.password == password)
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
            //Sobrecarga de metodo ALTA LUGAR
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



            // se piden 4 Categorias
            AltaCategoria("Categoria", "cine", Categoria.TiposCategoria.cine);
            AltaCategoria("Categoria 2", "teatro", Categoria.TiposCategoria.teatro);
            AltaCategoria("Categoria 3", "Musical", Categoria.TiposCategoria.concierto);
            AltaCategoria("Categoria 4", "Gastronomica", Categoria.TiposCategoria.feria_gastronomica);

            //Actividades
            DateTime fechaConHora = new DateTime(2022, 4, 23, 0, 0, 0);
            DateTime fechaConHora2 = new DateTime(2023, 5, 12, 0, 0, 0);
            DateTime fechaConHora3 = new DateTime(2024, 6, 07, 0, 00, 0);
            DateTime fechaConHora4 = new DateTime(2022, 8, 11, 0, 30, 0);



            //Deben ser 10 actividades 5 en lugares abiertos 
            AltaActividad("Rockfest ", ListaCategorias[2], fechaConHora, ListaLugares[4], Actividad.edad_minima.C13,1000);
            AltaActividad("Cuarteto de Nos ", ListaCategorias[2], fechaConHora2, ListaLugares[3], Actividad.edad_minima.C18, 6000);
            AltaActividad("Pilsen Rock ", ListaCategorias[2], fechaConHora3, ListaLugares[4], Actividad.edad_minima.P, 3000);
            AltaActividad("Gastro Open Air ", ListaCategorias[3], fechaConHora2, ListaLugares[2], Actividad.edad_minima.C13, 500);
            AltaActividad("Jazz en el teatro ", ListaCategorias[2], fechaConHora4, ListaLugares[1], Actividad.edad_minima.P, 1000);

            // 5 en lugares cerrados
            AltaActividad("The Stand Up Show ", ListaCategorias[1], fechaConHora3, ListaLugares[7], Actividad.edad_minima.C16, 4000);
            AltaActividad("Sinfonica Uruguaya ", ListaCategorias[2], fechaConHora, ListaLugares[5], Actividad.edad_minima.P, 600);
            AltaActividad("Rapido y Furioso 30 (Brian lives) ", ListaCategorias[0], fechaConHora4, ListaLugares[9], Actividad.edad_minima.P, 750);
            AltaActividad("Semana de la Arepa ", ListaCategorias[3], fechaConHora, ListaLugares[6], Actividad.edad_minima.C16, 1200);
            AltaActividad("TOC TOC ", ListaCategorias[1], fechaConHora3, ListaLugares[7], Actividad.edad_minima.P, 1500);

            DateTime fechaConHoraUsuario1 = new DateTime(1999, 8, 11, 0, 0, 0);
            DateTime fechaConHoraUsuario2 = new DateTime(1989, 8, 09, 0, 0, 0);

            AltaUsuario("a", "a", "a", fechaConHoraUsuario1, "a", "a");
            Usuario operador1 = new Usuario("Pedro", "Suarez", fechaConHoraUsuario2, "Operador1", "pedroOP@gmail.com", "9823",Usuario.Roles.Operador);
            ListaUsuarios.Add(operador1);
        }

    }
}
