using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;

namespace WcfServicio_Ventas.Models
{
    [DataContract]
    public class ResultadoPeti
    {

        private string mensaje;
        private string estatus;

        [DataMember]
        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }

        [DataMember]
        public string Estatus
        {
            get
            {
                return estatus;
            }

            set
            {
                estatus = value;
            }
        }
    }
}