using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MethodResponse;

using TWT.Entities.DevExtreme;


using System.Data;
using Microsoft.Data.SqlClient;
using TWT.Web.DevExtreme.Helpers;

namespace TWT.Web.DevExtreme.Controllers
{
    [ApiController]
    public class ClienteController : Controller
    {


        /// <summary>
        /// Método para crear 
        /// </summary>
        /// <param name="par"></param>
        /// <returns></returns>
        /// 

        [Route("TWT/V1/CargarUsuarios")]
        [HttpPost]
        public List<Cliente> CargarUsuarios(UsuariosActivos estado)
        {
            var Response = new List<Cliente>();
            List<Cliente> ObjectoClientes = new List<Cliente>();
            try
            {

                Response = Data.ClienteData.EjecutaSpUsiariosActivos(estado);

            }
            catch (Exception ex)
            {

                  //Codigosgos de respuesta
                //Response.Code = 0;
                //Response.Message = "Ocurrió un error";
                try
                {
                       // insert en BD log errores
                    //EjecucionSP.LogErrores("AccessADController", "validaUsuarioIntranet", pars, ex.Message);
                }
                catch (Exception exc)
                {
                      //log de errores
                    //_logger.Log(LogLevel.Error, exc, exc.Message);
                }
            }

            return Response;
        }

    }
}
