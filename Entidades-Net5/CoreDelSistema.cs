using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public static class CoreDelSistema
    {

        static List<Show> catalogoDisponible;

        static List<Usuario> usuariosRegistrados;

        static CoreDelSistema()
        {
            catalogoDisponible = new List<Show>();
            usuariosRegistrados = new List<Usuario>();

            CargarCatalogoInicial();
            CargarUsuarios();
        }


        private static void CargarCatalogoInicial()
        {
            catalogoDisponible.Add(new Peliculas(
                                                 "Tomb Raider",
                                                 "la vida de una joven llamada Lara Croft,quien lo abandona todo y parte en busca de su padre," +
                                                 "un aventurero que desapareció en una isla legendaria cerca de la costa de Japón. " +
                                                 "Allí encontrará mucho peligro",
                                                 122,
                                                 new List<Celebridad>()
                                                                    {
                                                                    new Celebridad("Alicia", "Vikander", EPais.Suecia),
                                                                    new Celebridad("pEPE","PEPOSO",EPais.Albania)
                                                                    },
                                                 new List<EGenero>() {
                                                                        EGenero.Aventuras,
                                                                        EGenero.CienciaFiccion
                                                                     }
                                                 )
                                  );




            catalogoDisponible.Add(new Peliculas("La liga de la justicia",
                                                  "superheroes. Batman reune a un grupo de superherores para derrotar a los enemigos más terribles jamás enfrentados",
                                                    121,
                                                    new List<Celebridad>() {
                                                                             new Celebridad("Ben", "Affleck", EPais.Estados_Unidos),
                                                                             new Celebridad("Gal", "Gadot", EPais.Israel),
                                                                             new Celebridad("Henry", "Cavill", EPais.Suecia),
                                                                            },
                                                    new List<EGenero>() { EGenero.CienciaFiccion, EGenero.SuperHeroes }
                                                    )
                                 );


            catalogoDisponible.Add(new Serie("Cobra Kai",
                                              " la historia 30 años después del campeonato de 1984, " +
                                              "en el que Johnny no se encuentra en el mejor momento de su vida por lo que decide volver a abrir " +
                                              "el famoso Dojo Cobra Kai para darle un giro",
                                              new List<Celebridad>() {
                                                                         new Celebridad("Ralph George", "Macchio", EPais.Estados_Unidos),
                                                                         new Celebridad("William Michael","Zabka", EPais.Estados_Unidos)
                                                                      },
                                              new List<EGenero>() { EGenero.CienciaFiccion, EGenero.Aventuras, EGenero.Familiar },
                                              new List<Temporada>()
                                                                  {
                                                                      new Temporada(1,new List<Capitulo>()
                                                                                                      {
                                                                                                             new Capitulo("As denegerado",
                                                                                                                         "Alcoholico y harto de vivir a la sombra de Daniel," +
                                                                                                                         "Johnny toca fundo y decide reabrir el dojo de karate Cobra Kai",
                                                                                                                         29),
                                                                                                             new Capitulo("Golpear Primero",
                                                                                                                         "Daniel ve el nuevo dojo Cobra Kai, y eso le trae recuerdos dolorosos. " +
                                                                                                                         "Más tarde, se entera de que Kyler, el chico que le gusta a Sam, fue atacado por un karateca.",
                                                                                                                         28),
                                                                                                               new Capitulo("Esqueleto",
                                                                                                                         "Con la idea de vigilar a Sam, Daniel se ofrece como chaperón para el baile de Halloween. " +
                                                                                                                         "Johnny intenta conseguir más alumnos para su flamante proyecto.",
                                                                                                                         23)

                                                                                                      })
                                                                  }
                                              )
                                );

        } // fin del metodo


        private static void CargarUsuarios()
        {
            usuariosRegistrados.Add(new Usuario("Lucas@lucas.com", "megustaelte123", "Lucas", "Rodriguez", EPais.Argentina));
            usuariosRegistrados.Add(new Usuario("pepe@pepe.com", "RUFruf123", "Pepe", "Peposo", EPais.Polonia));

        }


        private static bool ValidarCamposIngresados(string user, string contra)
        {

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(contra))
            {
                throw new UserPassException();
            }

            return true;
        }


        public static Usuario LogearUsuario(string user, string contra)
        {

            if (ValidarCamposIngresados(user, contra))
            {
                foreach (Usuario item in usuariosRegistrados)
                {
                    if (item.Email.Trim().ToLower() == user.Trim().ToLower()
                        && item.Contrasenia.Trim() == contra.Trim())
                    {
                        return item;
                    }
                }
            }
            return null;
        }




        public static bool RegistrarUsuario(string correo, string contra)
        {
            return false;
        }

        public static string MostrarUsuarios()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Usuario item in usuariosRegistrados)
            {
                sb.AppendLine(item.Nombre);
            }

            return sb.ToString();

        }

    }
}
