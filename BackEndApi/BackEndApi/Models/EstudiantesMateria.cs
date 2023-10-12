using System;
using System.Collections.Generic;

namespace BackEndApi.Models;

public partial class EstudiantesMateria
{
    public int EstudianteId { get; set; }

    public int MateriaId { get; set; }

    public int? ProfesorId { get; set; }

    public virtual Estudiante Estudiante { get; set; } = null!;

    public virtual Materia Materia { get; set; } = null!;

    public virtual Profesore? Profesor { get; set; }
}
