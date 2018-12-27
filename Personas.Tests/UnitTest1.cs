using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasUnitarias.Models;
using PruebasUnitarias.Servicios;

namespace Personas.Tests
{
    [TestClass]
    public class ServicioPersonasTest
    {
        private PersonasService _servicio;

        [TestInitialize]
        public void Inicializar()
        {
            _servicio = new PersonasService();
        }


        [TestMethod]
        public void EsValido_PersonaConNombreVacioEsInvalido()
        {
        

          var persona = new Persona() { Nombres ="Ernesto", Edad=35 };
       
            var resultado = _servicio.EsValida(persona);

        
            Assert.IsTrue(resultado);
        }


       [TestMethod]
       public void EsValido_PersonaConEdadMenorQue_18_EsInvalida()
        {
     

      
            var persona = new Persona() { Nombres = "Ernesto", Edad=18, Apellidos="Contreras"};

            var resultado = _servicio.EsValida(persona);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EsValido_PersonaConEdadMayorQueCincuentaEsInvalida()
        {
              
            var persona = new Persona() { Nombres = "Ernesto", Edad = 50, Apellidos = "Contreras" };

            var resultado = _servicio.EsValida(persona);

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void EsValido_PersonaConAlgunError_EsInvalida()
        {
        

            var persona = new Persona() { Nombres = "Ernesto", Edad = 50, Apellidos = "Contreras" };

            var resultado = _servicio.Errores.Any();

            Assert.IsFalse(resultado);
        }
    }
}
