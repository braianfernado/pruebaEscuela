using System;
using System.Collections.Generic;

namespace BackEndApi.Models;

public partial class Estudiante
{
    public int EstudianteId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<EstudiantesMateria> EstudiantesMateria { get; } = new List<EstudiantesMateria>();
}
