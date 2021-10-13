using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public abstract class Show
    {

        protected string nombre;
        protected string descripcion;
        protected List<EGenero> genero;
        protected int cantidadReproducciones;
        protected List<Celebridad> elenco;

        private Show()
        {
            cantidadReproducciones = 0;
            genero = new List<EGenero>();
        }


        protected Show(string nomb, string descripcion, List<Celebridad> elencoShow) : this()
        {
            this.nombre = nomb;
            this.descripcion = descripcion;
            this.elenco = new List<Celebridad>(elencoShow);
        }


        protected Show(string nomb, string descripcion, List<Celebridad> elencoShow, List<EGenero> generos) : this(nomb, descripcion, elencoShow)
        {
            genero = new List<EGenero>(generos);
        }

        public List<EGenero> ListaGeneros
        {
            get { return this.genero; }
        }


        public List<Celebridad> ElencoCompleto
        {
            get { return this.elenco; }
        }


        public int CantidadReproducciones
        {
            get { return this.cantidadReproducciones; }
        }


        public EGenero AgregarGenero
        {
            set
            {
                if (!ListaGeneros.Contains(value) && value != EGenero.SinGenero)
                {
                    ListaGeneros.Add(value);
                }
            }
        }


        public void AgregarReproduccion()
        {
            this.cantidadReproducciones++;
        }


        public abstract string Descripcion
        {
            get;
        }


        public static bool operator +(Show show, Celebridad celebridad)
        {

            if (show == celebridad)
                return false;

            show.elenco.Add(celebridad);
            return true;

        }

        public static bool operator ==(Show show, Celebridad celebridad)
        {

            foreach (Celebridad celeb in show.elenco)
            {
                if (celeb.Apellido == celebridad.Apellido && celeb.Nombre == celeb.Apellido)
                    return true;
            }

            return false;

        }
        public static bool operator !=(Show show, Celebridad celebridad)
        {
            return (show != celebridad);
        }



        public static bool operator +(List<Show> listaShow, Show show)
        {

            if (listaShow != show)
            {
                listaShow.Add(show);
                return true;
            }

            return false;
        }


        public static bool operator !=(List<Show> listaShow, Show show)
        {
            return !(listaShow == show);
        }


        public static bool operator ==(List<Show> listaShow, Show show)
        {
            if (show == null)
                return true;

            foreach (Show item in listaShow)
            {
                if (show.nombre == item.nombre)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
