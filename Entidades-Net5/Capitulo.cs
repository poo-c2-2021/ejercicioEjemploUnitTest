using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public class Capitulo
    {
        string nombre;
        string descripcion;
        int duracionMin;

        public Capitulo(string nombre, string descripcion, int duracionMin)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.duracionMin = duracionMin;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public string Duracion
        {
            get { return FuncionesAyuda.FormatearMinAHoras(this.duracionMin); }
        }

        public bool ModificarDuracion(int duracion)
        {
            if (duracion < 10)
                return false;

            this.duracionMin = duracion;
            return true;
        }

        public bool ModificarInfo(string texto, bool esNombre)
        {
            if (string.IsNullOrEmpty(texto))
                return false;

            if (esNombre)
                this.nombre = texto;
            else
                this.descripcion = texto;

            return true;
        }


        public static bool operator ==(Capitulo cap1, Capitulo cap2)
        {
            if (cap1.Duracion == cap2.Duracion && cap1.nombre == cap2.nombre)
            {
                return true;
            }

            return true;
        }

        public static bool operator !=(Capitulo cap1, Capitulo cap2)
        {
            return !(cap1 == cap2);
        }



    }
}
