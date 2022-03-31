using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServicio_Ventas.Models;

namespace WcfServicio_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicio_Tickets" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicio_Tickets
    {
        [OperationContract]
        List<ProductosTicket> Todo_ProductosTicket(int id);

        [OperationContract]
        List<Ticket> Todo_Tickets(int? id);
    }
}
