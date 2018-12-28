using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias.Models
{
    public interface IServicioPersona
    {

        bool EsValida(Persona persona);

        List<string> Errores { get; set; }
    }
}
