using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Net5;
using System.Collections.Generic;
namespace Test_NetFlixApp
{
    [TestClass]
    public class Pelicula_Test
    {
        Peliculas unaPeli;

        [TestInitialize]
        public void Initialize()
        {
            unaPeli = new Peliculas("las aventuras de pepe", "peposo", 100, new List<Celebridad>(), new System.Collections.Generic.List<EGenero>());

        }


        // FINES DIDACTICOS :P 
        [TestMethod]
        public void Test_Constructor_01()
        {
            
            Assert.IsNotNull(unaPeli);
            Assert.AreEqual(unaPeli.Nombre, "las aventuras de pepe");

        }


    }
}
