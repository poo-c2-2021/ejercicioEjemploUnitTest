using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public class Celebridad : Persona
    {
        EGenero generoPrincipal;
        List<Show> listaShowDondeTrabajo;

        public Celebridad(string nombre, string apellido, EPais paisOrigen) : base(nombre, apellido, paisOrigen)
        {
            listaShowDondeTrabajo = new List<Show>();
        }

        public Celebridad(string nombre, string apellido, EPais paisOrigen, EGenero generoPrincipal) : this(nombre, apellido, paisOrigen)
        {
            this.generoPrincipal = generoPrincipal;
        }


    }
}
