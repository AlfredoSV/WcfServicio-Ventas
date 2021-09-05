using System;
using System.Runtime.Serialization;

namespace WcfServicio_Ventas.Models
{
    [DataContract]
    public class Ticket
    {
        private int id_ticket;
        private int id_cliente;
        private float monto_total;
        private DateTime fechayhora_mov;
        private int id_caja;
       
       
        [DataMember]
        public int Id_ticket
        {
            get
            {
                return id_ticket;
            }

            set
            {
                id_ticket = value;
            }
        }

        [DataMember]
        public int Id_cliente
        {
            get
            {
                return id_cliente;
            }

            set
            {
                id_cliente = value;
            }
        }

        [DataMember]
        public float Monto_total
        {
            get
            {
                return monto_total;
            }

            set
            {
                monto_total = value;
            }
        }

        [DataMember]
        public int Id_caja
        {
            get
            {
                return id_caja;
            }

            set
            {
                id_caja = value;
            }
        }

        [DataMember]
        public DateTime Fechayhora_mov
        {
            get
            {
                return fechayhora_mov;
            }

            set
            {
                fechayhora_mov = value;
            }
        }
    }
}