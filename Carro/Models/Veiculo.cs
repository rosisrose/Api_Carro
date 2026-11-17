using System;
using System.Collections.Generic;

namespace Carro.Models;

public partial class Veiculo
{
    public int IdVeiculo { get; set; }

    public string Modelo { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public int Ano { get; set; }

    public string? Cor { get; set; }

    public decimal Preco { get; set; }

    public int IdMarca { get; set; }

    public virtual Marca IdMarcaNavigation { get; set; } = null!;
}
