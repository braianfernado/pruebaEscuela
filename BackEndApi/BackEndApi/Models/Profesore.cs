using System;
using System.Collections.Generic;

namespace BackEndApi.Models;

public partial class Profesore
{
    public int ProfesorId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<EstudiantesMateria> EstudiantesMateria { get; } = new List<EstudiantesMateria>();
}
