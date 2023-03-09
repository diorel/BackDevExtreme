using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TWT.Entities.DevExtreme;

namespace TWT.Web.DevExtreme.Data
{
        public class ClienteData
        {
            public static List<Cliente> EjecutaSpUsiariosActivos(UsuariosActivos estado)
            {
                var Response = new List<Cliente>();
                List<Cliente> ObjectoClientes = new List<Cliente>();

                try
                {
                    using (SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Tienda;Integrated Security=True;Connect Timeout=60;Encrypt=False;"))
                    {
                        cn.Open();

                        SqlCommand cmd = new SqlCommand("usp_ActivoCliente", cn);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Estado", estado.Activo);

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {

                            while (dr.Read())
                            {
                                Cliente ObjectoCliente = new Cliente();

                                ObjectoCliente.ClienteId = dr.GetInt32(0);
                                ObjectoCliente.Compañia = dr.GetString(1);
                                ObjectoCliente.Nombre = dr.GetString(2);
                                ObjectoCliente.ApellidoPaterno = dr.GetString(3);
                                ObjectoCliente.ApellidoMaterno = dr.GetString(4);
                                ObjectoCliente.Direccion = dr.GetString(4);

                                ObjectoClientes.Add(ObjectoCliente);
                            }
                            // Cierra el DataReader
                            dr.Close();
                        }

                    }

                    Response = ObjectoClientes;
                }
                catch (Exception ex)
                {
                     // codigo de erroes respuesta
                    //Response.Code = 0;
                    //Response.Message = "Ocurrió un error";

                    try
                    {
                       // sp log de erroes BD
                    }
                    catch (Exception exc)
                    {
                       // log de erroes texto
                    }
                }

                return Response;
            }

        }

}
