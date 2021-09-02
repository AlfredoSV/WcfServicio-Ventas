using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServicio_Ventas.Models;

namespace WcfServicio_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicio_Clientes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicio_Clientes
    {
        [OperationContract]
        List<Cliente> Todo_Clientes(int? id);

        [OperationContract]
        ResultadoPeti Alta_Cliente(Cliente c);

        [OperationContract]
        ResultadoPeti Editar_Cliente(Cliente c);



    }
}
