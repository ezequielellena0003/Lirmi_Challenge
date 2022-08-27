using System;
using System.Collections.Generic;

namespace Lirmi.Challenge.Server.Modelos
{
    public partial class Asignatura
    {
        public Asignatura()
        {
            Cursos = new HashSet<Curso>();
        }

        public int IdAsignatura { get; set; }
        public string NombreAsignatura { get; set; } = null!;

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
