using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public abstract class Persona
    {

        string nombre;
        string apellido;
        EPais nacionalidad;
        private Persona()
        {
            nacionalidad = EPais.SinDato;
        }

        protected Persona(string nombre, string apellido) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        protected Persona(string nombre, string apellido, EPais paisOrigen) : this(nombre, apellido)
        {
            this.nacionalidad = paisOrigen;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public EPais PaisOrigen
        {
            get
            {
                return nacionalidad;
            }

            set
            {
                if (value != EPais.SinDato)
                {
                    nacionalidad = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sbPersona = new StringBuilder();

            sbPersona.AppendLine(nombre);
            sbPersona.AppendLine(apellido);
            sbPersona.AppendLine(nacionalidad.ToString());

            return sbPersona.ToString();
        }


    }
}
