using System;
using WcfServicio_Ventas.Models.SqlServer_Clases;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WcfServicio_Ventas.Models.MantenimientoCliente
{
    public class MtaCliente
    {

        private string[] dmlCad = { "Select * from Cliente",
        "Select top 1 * from Cliente where id_cliente = @id",
        "Insert into Cliente Values(@nombre,@segundNombre,@apellidoP,@apellidoM,@fechaN,@fechaA)",
        "Update Cliente Set nombre=@nombre,segundo_nombre=@segundNombre,apellidoP=@apellidoP,apellidoM=@apellidoM,fecha_nacimiento=@fechaN,fechayhora_alta=@fechaA WHERE id_cliente = @id"};
        private List<Cliente> clientesLis = new List<Cliente>();

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

        public List<Cliente> ClientesLis
        {
            get
            {
                return clientesLis;
            }

            set
            {
                clientesLis = value;
            }
        }


        public List<Cliente> Clientes(int? id)
        {
              
            SqlConnection con = (new SqlConex()).Conexion;
            SqlCommand comando = null;
            SqlDataReader sdr = null;

            using (con)
            {
                con.Open();
                if(id == null)
                {
                    comando = new SqlCommand(DmlCad[0], con);
                }else
                {
                    comando = new SqlCommand(DmlCad[1], con);
                    comando.Parameters.AddWithValue("@id", id);
                }
                
                
                sdr = comando.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        ClientesLis.Add( new Cliente {
                            Id_cliente = sdr.IsDBNull(0) ? 0 : sdr.GetInt32(0)
                            , Nombre = sdr.IsDBNull(1) ? "Valor nulo" : sdr.GetString(1),
                            SegundoNombre = sdr.IsDBNull(2) ? "Valor nulo" : sdr.GetString(2)
                            , ApellidoP = sdr.IsDBNull(3) ? "Valor nulo" : sdr.GetString(3),
                            ApellidoM = sdr.IsDBNull(4) ? "Valor nulo" : sdr.GetString(4),
                            Fechayhora_alta = sdr.IsDBNull(5) ? DateTime.Now: sdr.GetDateTime(5),
                            Fecha_nacimiento = sdr.IsDBNull(6) ? DateTime.Now : sdr.GetDateTime(6)
                        } );
                    }
                }
                



            }
            return ClientesLis;
        }



        public ResultadoPeti Editar_Alta_Cliente(Cliente c, int op)
        {
            SqlConnection con = (new SqlConex()).Conexion;
            SqlCommand comando = null;
            bool alta = false;
            ResultadoPeti obj = new ResultadoPeti();

            try
            {
                using (con)
                {
                    con.Open();

                    if (op == 1)
                    {

                        comando = new SqlCommand(DmlCad[2], con);
                    }
                    else
                    {
                        comando = new SqlCommand(DmlCad[3], con);
                        comando.Parameters.AddWithValue("@id", c.Id_cliente);
                    }



                    comando.Parameters.AddWithValue("@nombre", c.Nombre);
                    comando.Parameters.AddWithValue("@segundNombre", c.SegundoNombre);
                    comando.Parameters.AddWithValue("@apellidoP", c.ApellidoP);
                    comando.Parameters.AddWithValue("@apellidoM", c.ApellidoM);
                    comando.Parameters.AddWithValue("@fechaN", c.Fecha_nacimiento);
                    comando.Parameters.AddWithValue("@fechaA", c.Fechayhora_alta);

                    alta = comando.ExecuteNonQuery() > 0;


                }

                if (alta)
                {

                    obj.Mensaje = "La operación se realizó correctamente";
                    obj.Estatus = op == 1 ? "Se realizo el alta correctamente." : "Se actualizo correctamente." ;
                }
                else
                {
                    obj.Mensaje = "La operación no se realizó correctamente";
                    obj.Estatus = op == 1 ? "No se realizo el alta." : "No se actualizo.";

                }


                
            }
            catch (Exception e)
            {

                obj.Mensaje = e.Message;
                obj.Estatus = "Error" ;
            }

            return obj;
            
        }


    }

}