using System;
using System.Collections.Generic;

namespace EjercicioPresidentes.Models;

public partial class Estadorepublica
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Presidente> Presidente { get; set; } = new List<Presidente>();
}
