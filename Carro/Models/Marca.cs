using System;
using System.Collections.Generic;

namespace Carro.Models;

public partial class Marca
{
    public int IdMarca { get; set; }

    public string Nome { get; set; } = null!;

    public string PaisOrigem { get; set; } = null!;

    public virtual ICollection<Veiculo> Veiculo { get; set; } = new List<Veiculo>();
}
