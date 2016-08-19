using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFTemplate.Servicios {
    public class PersonaServicio {
        /// <summary>
        /// met_obtener_personas
        /// Esta funcion se crea separado del servicio para poder realizar operaciones con la bd,
        /// la intencion de separarlo del servicio es para controlar mejor los niveles de operacion
        /// con respecto a la informacion que se solicita o se recibe.
        /// </summary>
        /// <returns>Lista de personas</returns>
        public List<Persona> met_obtener_personas () {
            //Manejamos un bloque try/catch para poder controlar las excepciones que surjan en la funcion
            try {
                /*
                Lista de personas a retornar
                */
                List<Persona> lista_personas = new List<Persona> ();
                /*
                Instancias de los objetos persona
                */
                Persona persona_uno = new Persona () {Id =1, Nombre = "persona uno", Email="uno@gmail.com" };
                Persona persona_dos = new Persona () { Id = 2, Nombre = "persona dos", Email = "dos@gmail.1com" };
                Persona persona_tres = new Persona () { Id = 3, Nombre = "persona tres", Email = "tres@gmail.com" };

                /*
                Se agregan a la lista las personas.
                */
                lista_personas.Add ( persona_uno );
                lista_personas.Add ( persona_dos );
                lista_personas.Add ( persona_tres );
                return lista_personas;
            } catch(Exception ex) {
                /*En caso de que ocurra un error, regresamos null*/
                return null;
            }
        }
    }
}