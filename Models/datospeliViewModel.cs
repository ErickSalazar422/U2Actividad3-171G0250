using Pomelo.EntityFrameworkCore.MySql.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U2Actividad3_171G0250.Models
{
    public class datospeliViewModel

    { public string Nombre { get; set; }
        public string NombreOr { get; set; }
        public DateTime? Año { get; set; }
        public int idp { get; set; }
        public string descripcion { get; set; }
        public IEnumerable<Apariciones>[] Apariciones { get; set; }
       public string nombper { get; set; }
       
    }

}
