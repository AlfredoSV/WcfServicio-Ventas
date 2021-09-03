using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfServicio_Ventas.Models
{
    [DataContract]
    public class ProductosTicket
    {
        private int id_ticket;
        private int id_cliente;
        private float costo_pz;
        private int id_caja;
        private string nombre_producto;
        private DateTime fechayhora_mov;

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
        public float Costo_pz
        {
            get
            {
                return costo_pz;
            }

            set
            {
                costo_pz = value;
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
        public string Nombre_producto
        {
            get
            {
                return nombre_producto;
            }

            set
            {
                nombre_producto = value;
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