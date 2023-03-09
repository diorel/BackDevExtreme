using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TWT.Web.DevExtreme.Helpers
{
    public class MetodoRespuesta<dynamic>  
    {
        public long Codigo { get; set; }
      
        public string Mensaje { get; set; }
     
        public dynamic Result { get; set; }

    }
}
