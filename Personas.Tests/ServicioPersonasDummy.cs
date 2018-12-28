
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Tests
{
    class ServicioPersonasDummy : IPersonasService
    {
        public List<string> Errores { get ; set; }

        public bool EsValida(Persona persona)
        {
            Errores = new List<string>();
            Errores.Add("Error");
            return false;
        }
    }
}
