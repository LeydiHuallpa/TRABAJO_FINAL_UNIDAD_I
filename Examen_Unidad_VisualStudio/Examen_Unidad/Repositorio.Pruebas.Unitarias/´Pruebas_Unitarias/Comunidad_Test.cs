using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio;

namespace Repositorio.Pruebas.Unitarias
{
    [TestClass]
    public class Comunidad_Test
    {
        ClsComunidad createcomunidad = new ClsComunidad();
        [TestMethod]
        public void RegistorComunidadCompleto_Test()
        {
            //Arrange
            
            var _idcomunidad = 10;
            var _nombrecomunidad = "";

            //Act

            var result = createcomunidad.RegistrarComunidad(_idcomunidad,_nombrecomunidad);

            //Assert
            Assert.IsNotNull(result);
        }

        public void CambioComunidadCorrecto_Test()
        {
            //Arrange
            var _nuevonombrecomunidad = "Marco Antonio";
            var _nombrecomunidad = createcomunidad.nombrecomunidad;

            //Act
            var result = createcomunidad.CambiarComunidad(_nuevonombrecomunidad);

            //Assert
            Assert.AreEqual(_nombrecomunidad,_nuevonombrecomunidad);
        }
    }
}
