using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFTemplate {
    [ServiceContract]
    public interface IApi {

        /// <summary>
        /// OperationContract
        /// Es la funcion o metodo que ejecuta una accion en el servicio.
        /// </summary>
        [OperationContract]
        List<Persona> met_obtener_personas (int id_usuario);

        // TODO: Add your service operations here
    }


    /// <summary>
    /// DataContract
    /// Es el atributo asignado a las clases que serviran como entidades de intercambio.
    /// Usadas generalmente para poder compartir la misma estructura de informacion entre el web service y el cliente.
    /// </summary>
    [DataContract]
    public class Persona {
        private int _id;
        private string _nombre;
        private string _email;
        /// <summary>
        /// DataMember
        /// Utilizado para poder habilitar las propiedades de la estructura para que sean
        /// visibles a los clientes.
        /// </summary>
        [DataMember]
        public int Id {
            get {
                return _id;
            }

            set {
                _id = value;
            }
        }
        [DataMember]
        public string Nombre {
            get {
                return _nombre;
            }

            set {
                _nombre = value;
            }
        }
        [DataMember]
        public string Email {
            get {
                return _email;
            }

            set {
                _email = value;
            }
        }
    }
}
