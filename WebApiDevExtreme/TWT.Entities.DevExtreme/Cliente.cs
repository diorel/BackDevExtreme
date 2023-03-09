using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWT.Entities.DevExtreme
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Compañia { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }

    }
}
