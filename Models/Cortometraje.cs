using System;
using System.Collections.Generic;

namespace U2Actividad3_171G0250.Models
{
    public partial class Cortometraje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
