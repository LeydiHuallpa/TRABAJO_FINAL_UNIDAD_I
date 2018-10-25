using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio;

namespace Repositorio.Pruebas.Unitarias
{
    [TestClass]
    public class Usuario_Test
    {
        [TestMethod]
        public void RegistroCompleto()
        {
            ClsUsuario createuser = new ClsUsuario();
            //Arrange
            var _stringip = "";

            var _idusuario = 1;
            var _nombreusuario = "Jhordy Joel";
            var _direccionip = createuser.ObtenerIP(_stringip);
            var _pais = "Ucrania";
           
          

            //Act
            var result_rc = createuser.RegistrarUsuario(_idusuario,
                                                     _nombreusuario,
                                                     _direccionip,
                                                     _pais);

            //Assert
            Assert.IsNotNull(result_rc);
        }


        [TestMethod]
        public void RegistroIncompleto()
        {
            //Arrange
            var _idusuario = 0;
            var _nombreusuario = "";
            var _direccionip = "";
            var _pais = "";
            ClsUsuario createuser = new ClsUsuario();

            //Act
            var result_ri = createuser.RegistrarUsuario(_idusuario,
                                                     _nombreusuario,
                                                     _direccionip,
                                                     _pais);

            //Assert

            Assert.IsNull(result_ri);

        }
    }
}
