using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WcfServicio_Ventas.Models.SqlServer_Clases;

namespace WcfServicio_Ventas.Models.MantenimientoCliente
{
    public class MtaTicket
    {
        private string[] dmlCad = {"Select * from Ticket", " where id_ticket = @id"};

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

        public List<Ticket> Ticket_Lista
        {
            get
            {
                return ticket_Lista;
            }

            set
            {
                ticket_Lista = value;
            }
        }

        private List<Ticket> ticket_Lista = new List<Ticket>();

        public List<Ticket> Todo_Ticket(int? id)
        {

            SqlConnection con = (new SqlConex()).Conexion;
            SqlCommand comando = null;
            SqlDataReader sdr = null;

            using (con)
            {
                con.Open();
                
                if (id != null)
                {
                    comando = new SqlCommand((DmlCad[0]+DmlCad[1]), con);
                    comando.Parameters.AddWithValue("@id", id);
                }else
                {
                    comando = new SqlCommand(DmlCad[0], con);
                }
               
                



                sdr = comando.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Ticket_Lista.Add(new Ticket
                        {
                            Id_ticket = sdr.IsDBNull(0) ? 0 : sdr.GetInt32(0),
                            Id_cliente = sdr.IsDBNull(1) ? 0 : sdr.GetInt32(1),
                            Monto_total = sdr.IsDBNull(2) ? (float)0.0 : sdr.GetFloat(2),
                            Id_caja = sdr.IsDBNull(4) ? 0 : sdr.GetInt32(4), 
                            Fechayhora_mov = sdr.IsDBNull(3) ? DateTime.Now : sdr.GetDateTime(3)

                        });
                    }
                }




            }
            return Ticket_Lista;
        }

    }
}