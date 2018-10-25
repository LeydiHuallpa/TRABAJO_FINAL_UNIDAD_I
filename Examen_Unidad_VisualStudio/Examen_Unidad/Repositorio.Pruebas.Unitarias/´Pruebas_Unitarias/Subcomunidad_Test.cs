using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio;

namespace Repositorio.Pruebas.Unitarias._Pruebas_Unitarias
{
    [TestClass]
    public class Subcomunidad_Test
    {
       
            public void RegistorSubomunidadCompleto_Test()
            {
            //Arrange
            ClsSubComunidad createsubc = new ClsSubComunidad();
                var _idcomunidad = 10;
                var _nombresubcomunidad = "";

                //Act

                var result = createsubc.CrearSubcomunidad(_nombresubcomunidad, _idcomunidad);

                //Assert
                Assert.IsNotNull(result);
            }
       
    }
}
