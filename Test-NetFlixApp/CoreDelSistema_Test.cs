using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Net5;
using System;

namespace Test_NetFlixApp
{
    [TestClass]
    public class CoreDelSistema_Test
    {
        
        [DataRow("Lucas@lucas.com", "megustaelte123","Lucas")]
        [DataRow("pepe@pepe.com", "RUFruf123","Pepe")]
        [TestMethod]
        public void Test_LogearUsuario_CasosValidos(string user,string pass,string nombEsperado)
        {

            #region Arrange
            // ARRANGE 
            // setear los valores de los parametros que van a usar. 
            #endregion
            //string user = "Lucas@lucas.com";
            //string pass = "megustaelte123";

            Usuario resultado;

            #region Act
            // ACT
            // Es la llamada al metodo a testear con los parametros que 
            // utilizamos en el Arrange
            #endregion

            resultado = CoreDelSistema.LogearUsuario(user, pass);

            #region Assert
            // ASSERT
            // EVALUAR SI LO QUE ESPERABAMOS DEL METODO A TESTEAR
            // COINCIDE CON LO QUE EL METODO DEVUELVE 
            #endregion

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Nombre.ToString() != string.Empty);
            //Assert.IsFalse(string.IsNullOrEmpty(resultado.Nombre)); // ES IGUAL AL DE ARRIBA
            Assert.AreEqual(resultado.Nombre.ToString(), nombEsperado);

        }


        [TestMethod]
        public void Test_LogearUsuario_CasosErroneos()
        {
            string user = "asd";
            string pass = "123";
            Usuario resultado;

            resultado = CoreDelSistema.LogearUsuario(user, pass);

            Assert.IsNull(resultado);

        }

        [ExpectedException(typeof(AccessViolationException))]
        [TestMethod]
        public void Test_LogearUsuario_Casos_Null()
        {
            string user = null;
            string pass = "123"; 
            Usuario resultado;

            resultado = CoreDelSistema.LogearUsuario(user, pass);

        }
    }
}
