using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio;

namespace Repositorio.Pruebas.Unitarias._Pruebas_Unitarias
{
    [TestClass]
    public class PalabraClave_Test
    {
        [TestMethod]
        public void ObtenerPalabraClave()
        {
            ClsPalabrasClave words = new ClsPalabrasClave();
            var _word = "Administracion de Negocios";
            var result = words.DarPalabraClave(_word);

            Assert.IsNotNull(result);
        }
    }
}
