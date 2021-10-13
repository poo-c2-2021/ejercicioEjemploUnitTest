using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public class Serie : Show
    {
        List<Temporada> temporadas;

        public Serie(string nomb, string descripcion, List<Celebridad> elencoShow, List<EGenero> generos, List<Temporada> temp) : base(nomb, descripcion, elencoShow, generos)
        {
            this.temporadas = new List<Temporada>();

        }

        public List<Temporada> Temporadas
        {
            get { return this.temporadas; }
        }

        public Temporada this[int numeroTemporada]
        {
            get
            {
                if (this.temporadas.Count >= numeroTemporada && numeroTemporada != 0)
                {
                    return this.temporadas[numeroTemporada - 1];
                }
                else
                    return null;
            }
        }

        public override string Descripcion
        {
            get { return "Esta serie cuenta " + this.descripcion; }
        }

        public static bool operator +(Serie serie, Temporada temp)
        {

            if (serie == temp)
                return false;

            serie.temporadas.Add(temp);
            return true;
        }

        public static bool operator ==(Serie serie, Temporada temp)
        {
            if (temp == null)
                return true;


            foreach (Temporada item in serie.temporadas)
            {
                if (item == temp)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Serie serie, Temporada temp)
        {
            return !(temp != null);
        }

    }
}
