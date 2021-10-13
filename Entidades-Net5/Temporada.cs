using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public class Temporada
    {

        string nombre;
        List<Capitulo> listaCapitulos;

        public Temporada(int numeroTemporada, List<Capitulo> capitulos)
        {
            this.nombre = "Temporada " + numeroTemporada;
            this.listaCapitulos = capitulos;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public List<Capitulo> ListaCapitulos
        {
            get { return this.listaCapitulos; }
        }


        public bool ModificarNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                return false;

            return true;
        }

        public static bool operator +(Temporada temporada, Capitulo capitulo)
        {
            if (temporada != capitulo)
            {
                temporada.listaCapitulos.Add(capitulo);
                return true;
            }
            return false;

        }


        public static bool operator ==(Temporada tem, Capitulo capi)
        {
            foreach (Capitulo item in tem.listaCapitulos)
            {
                if (item == capi)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Temporada tem, Capitulo capi)
        {
            return !(tem == capi);
        }




    }
}
