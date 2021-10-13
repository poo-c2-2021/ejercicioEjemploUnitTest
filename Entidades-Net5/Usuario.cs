using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public class Usuario : Persona
    {
        string email;
        string contrasenia;
        List<Show> contenidoFavorito;


        public Usuario(string email, string contrasenia, string nombre, string apellido, EPais paisOrigen) : base(nombre, apellido, paisOrigen)
        {

            this.email = email;
            this.contrasenia = contrasenia;
            this.contenidoFavorito = new List<Show>();
        }

        public string Email
        {
            get { return this.email; }
        }

        public string Contrasenia
        {
            get { return this.contrasenia; }
        }

        public List<Show> ContenidoFavorito
        {
            get { return contenidoFavorito; }
        }

    }
}
