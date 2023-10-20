using System;
using System.Collections.Generic;

namespace BackEndApi.Models;

public partial class EstudiantesMateria
{
 

    public int EstudianteId { get; set; }
    public int MateriaId { get; set; }
    public int? ProfesorId { get; set; }

    public virtual Estudiante EstudianteidNavigation { get; set; } = null!;
    public virtual Materia MateriaidNavigation { get; set; } = null!;
    public virtual Profesore? ProfesoridNavigation { get; set; }

}
