using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql.Internal;


namespace U2Actividad3_171G0250.Models.ViewModels
{
    public class DatosCortoViewModel
    {public int idCort { get; set; }
        public string Nombre { get; set; }
        public IEnumerable<Models.Cortometraje> Cortometraje { get; set; }
    }
}
