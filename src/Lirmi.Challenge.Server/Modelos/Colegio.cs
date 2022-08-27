using System;
using System.Collections.Generic;

namespace Lirmi.Challenge.Server.Modelos
{
    public partial class Colegio
    {
        public int IdColegio { get; set; }
        public string NombreColegio { get; set; } = null!;
        public int? IdCurso { get; set; }

        public virtual Curso? IdCursoNavigation { get; set; }
    }
}
