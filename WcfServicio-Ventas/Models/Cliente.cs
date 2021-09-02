using System.Runtime.Serialization;
using System;

namespace WcfServicio_Ventas.Models
{
    [DataContract]
    public class Cliente
    {
        
        private int id_cliente;
        private string nombre;
        private string segundoNombre;
        private string apellidoP;
        private string apellidoM;
        private DateTime fecha_nacimiento;
        private DateTime fechayhora_alta;

        [DataMember]
        public int Id_cliente {
            get { return id_cliente; }
            set { id_cliente = value; }

        }

        [DataMember]
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        [DataMember]
        public string ApellidoP
        {
            get
            {
                return apellidoP;
            }

            set
            {
                apellidoP = value;
            }
        }

        [DataMember]
        public string ApellidoM
        {
            get
            {
                return apellidoM;
            }

            set
            {
                apellidoM = value;
            }
        }

        [DataMember]
        public DateTime Fecha_nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }

            set
            {
                fecha_nacimiento = value;
            }
        }

        [DataMember]
        public DateTime Fechayhora_alta
        {
            get
            {
                return fechayhora_alta;
            }

            set
            {
                fechayhora_alta = value;
            }
        }

        [DataMember]
        public string SegundoNombre
        {
            get
            {
                return segundoNombre;
            }

            set
            {
                segundoNombre = value;
            }
        }
    }
}