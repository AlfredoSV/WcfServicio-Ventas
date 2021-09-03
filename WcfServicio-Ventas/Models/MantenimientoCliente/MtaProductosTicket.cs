using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WcfServicio_Ventas.Models.SqlServer_Clases;

namespace WcfServicio_Ventas.Models.MantenimientoCliente
{
    public class MtaProductosTicket
    {
        private string[] dmlCad = {"SELECT t.id_ticket,t.id_cliente,p.costo_pz,t.id_caja,p.nombre_producto,t.fechayhora FROM "+
                                   "Ticket t INNER JOIN Detalle_ticket dt on t.id_ticket = dt.id_ticket inner join Producto p on "+
                                    "dt.id_producto = p.id_producto where t.id_ticket = @id;"};

        private List<ProductosTicket> productosTicket_Lista = new List<ProductosTicket>();

        public string[] DmlCad
        {
            get
            {
                return dmlCad;
            }

            set
            {
                dmlCad = value;
            }
        }

        public List<ProductosTicket> ProductosTicket_Lista
        {
            get
            {
                return productosTicket_Lista;
            }

            set
            {
                productosTicket_Lista = value;
            }
        }

        public List<ProductosTicket> Todo_ProdcutosTicket(int id)
        {

            SqlConnection con = (new SqlConex()).Conexion;
            SqlCommand comando = null;
            SqlDataReader sdr = null;

            using (con)
            {
                con.Open();
            
                   comando = new SqlCommand(DmlCad[0], con);
                    comando.Parameters.AddWithValue("@id", id);
                


                sdr = comando.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                         ProductosTicket_Lista.Add(new ProductosTicket{
                            Id_ticket = sdr.IsDBNull(0) ? 0 : sdr.GetInt32(0),
                            Id_cliente = sdr.IsDBNull(1) ? 0 : sdr.GetInt32(1),
                            Costo_pz = sdr.IsDBNull(2) ? (float)0.0 : sdr.GetFloat(2),
                            Id_caja = sdr.IsDBNull(3) ? 0 : sdr.GetInt32(3),
                            Nombre_producto = sdr.IsDBNull(4) ? "Valor nulo" : sdr.GetString(4),
                            Fechayhora_mov = sdr.IsDBNull(5) ? DateTime.Now : sdr.GetDateTime(5)
                            
                        });
                    }
                }




            }
            return ProductosTicket_Lista;
        }
    }
}