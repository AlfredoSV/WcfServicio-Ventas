using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServicio_Ventas.Models;
using WcfServicio_Ventas.Models.MantenimientoCliente;

namespace WcfServicio_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Servicio_Tickets" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Servicio_Tickets.svc o Servicio_Tickets.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Servicio_Tickets : IServicio_Tickets
    {
      
        public List<ProductosTicket> Todo_ProductosTicket(int id)
        {
            var mta = new MtaProductosTicket();

            return mta.Todo_ProdcutosTicket(id);
        }

        public List<Ticket> Todo_Tickets(int? id)
        {
            return new MtaTicket().Todo_Ticket(id);
        }
    }
}
