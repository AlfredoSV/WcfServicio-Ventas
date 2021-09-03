using System;
using WcfServicio_Ventas.Models;
using WcfServicio_Ventas.Models.MantenimientoCliente;
using System.Collections.Generic;

namespace WcfServicio_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Servicio_Clientes" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Servicio_Clientes.svc o Servicio_Clientes.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Servicio_Clientes : IServicio_Clientes
    {
        public ResultadoPeti Alta_Cliente(Cliente c)
        {
            MtaCliente mta = new MtaCliente();
            return mta.Editar_Alta_Cliente(c,1);

        }

        public ResultadoPeti Editar_Cliente(Cliente c)
        {
            MtaCliente mta = new MtaCliente();
            return mta.Editar_Alta_Cliente(c,0);
        }

        public List<Cliente> Todo_Clientes(int? id)
        {
            MtaCliente mta = new MtaCliente();
            return mta.Clientes(id);

        }
    }
}
