using System;
using System.Collections.Generic;

namespace Lirmi.Challenge.Server.Modelos
{
    public partial class Curso
    {
        public Curso()
        {
            Colegios = new HashSet<Colegio>();
        }

        public int IdCurso { get; set; }
        public string NombreCurso { get; set; } = null!;
        public int? IdAsignatura { get; set; }

        public virtual Asignatura? IdAsignaturaNavigation { get; set; }
        public virtual ICollection<Colegio> Colegios { get; set; }
    }
}
