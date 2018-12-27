using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.Servicios
{
    public class PersonasService
    {
        public List<string> Errores;
        
        public PersonasService()
        {
            this.Errores = new List<string>();
        }


       public bool EsValida(Persona persona)
        {
        
           if ( string.IsNullOrWhiteSpace(persona.Nombres))
            {
                Errores.Add("Nombre no válido");                
            }
 
            if (persona.Edad < 18 )
            {
                Errores.Add("La edad debe mayor a 18");
            }

            if (persona.Edad > 50)
            {
                Errores.Add("La edad no debe mayor a 50");
            }

            return !Errores.Any();

        }


    }
}