using System;
using System.Collections.Generic;

namespace BackEndApi.Models;

public partial class Materia
{
    public int MateriaId { get; set; }

    public string NombreMateria { get; set; } = null!;

    public virtual ICollection<EstudiantesMateria> EstudiantesMateria { get; } = new List<EstudiantesMateria>();
}
