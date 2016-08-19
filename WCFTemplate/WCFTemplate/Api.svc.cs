using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFTemplate.Servicios;

namespace WCFTemplate {

    /// <summary>
    /// Clase que implementa la interfaz.
    /// </summary>
    public class Api : IApi {
        public List<Persona> met_obtener_personas (int id_usuario) {
            /*Instanciamos a la clase de PersonaServicio, es en esa clase
            donde se encuentra toda la logica de la operacion*/
            PersonaServicio servicio = new PersonaServicio ();

            /*A nivel de esta funcion podemos validar seguridad para no proceder a realizar
            las operaciones sino se ha validado o sino se han cumplido ciertas condiciones.
            */
            if (id_usuario < 0 ) {
                return null;
            }
            /*Si ya se pasaron las validaciones basicas, podemos proseguir con el llamado de la funcion que
            contiene toda la logica.
            */
            return servicio.met_obtener_personas ();
        }
    }
}
