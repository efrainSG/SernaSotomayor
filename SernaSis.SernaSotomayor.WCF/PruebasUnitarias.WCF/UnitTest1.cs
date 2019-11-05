using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SernaSIs.SernaSotomayor.WCF.Contract.Data;

namespace PruebasUnitarias.WCF {
    [TestClass]
    public class UnitTest1 {
        ServicioHC servicios;
        [TestInitialize]
        public void Init()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            servicios = new ServicioHC();
        }
        [TestCleanup]
        public void Clean()
        {

        }
        [TestMethod]
        public void guardaRolTest()
        {
            var response = servicios.guardaRol(new RolRequest { Nombre = "Administrador" });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());

            response = servicios.guardaRol(new RolRequest { Nombre = "Usuario" });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());

            response = servicios.guardaRol(new RolRequest { Id = 2, Nombre = "Usuario editado" });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());
        }

        [TestMethod]
        public void guardaTipoTest()
        {
            var response = servicios.guardaTipo(new TipoRequest { Nombre = "Sexo" });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());

            response = servicios.guardaTipo(new TipoRequest { Nombre = "Grupo de sangre" });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());

            response = servicios.guardaTipo(new TipoRequest { Id = 2, Nombre = "Grupo Sanguíneo" });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());
        }

        [TestMethod]
        public void guardaCatalogoTest()
        {
            servicios.guardaTipo(new TipoRequest { Nombre = "Sexo" });
            var response = servicios.guardaCatalogo(new CatalogoRequest
            {
                Id = 1,
                Tipo = new TipoRequest
                {
                    Id = 1,
                    Nombre = "Sexo"
                },
                Valor = "Femenino"
            });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());

            response = servicios.guardaCatalogo(new CatalogoRequest
            {
                Id = 1,
                Tipo = new TipoRequest
                {
                    Id = 1,
                    Nombre = "Sexo"
                },
                Valor = "Mujer"
            });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Editando: {0}", response.ToString());
        }

        [TestMethod]
        public void guardaUbicacionTest()
        {
            var response = servicios.guardaUbicacion(new UbicacionRequest
            {
                Id = 14,
                Nombre = "Puebla",
                Abreviatura = "PBL",
                Lada = "222"
            });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());

            response = servicios.guardaUbicacion(new UbicacionRequest
            {
                Id = 1,
                Nombre = "Puebla de Zaragoza",
                Abreviatura = "PBL",
                Lada = "222"
            });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());
        }

        [TestMethod]
        public void guardaPersonaTest()
        {
            var response = servicios.guardaPersona(new PersonaRequest
            {
                Id = 14,
                Nombre = "Efraín Serna Gracia",
                Domicilio = "67 oriente 631-1",
                Edad=40,
                Email="efrain_serna@hotrmail.com",
                Nacimiento = new DateTime(1979,8,11),
                Ocupacion ="Desarrollador de sistemas",
                Rh="+"
            });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Agregando: {0}", response.ToString());

            response = servicios.guardaPersona(new PersonaRequest
            {
                Id = 1,
                Nombre = "M. C. Y T. E. Efraín Serna Gracia",
                Domicilio = "67 oriente 631 - 1. Inf. La Margarita",
                Edad = 40,
                Email = "efrain_serna@hotrmail.com",
                Nacimiento = new DateTime(1979, 8, 11),
                Ocupacion = "Desarrollador de sistemas",
                Rh = "+"
            });
            Assert.IsTrue(response.Error.ErrNum == 0, response.Error.ErrMensaje);
            Console.WriteLine("Editado: {0}", response.ToString());
        }
    }
}
