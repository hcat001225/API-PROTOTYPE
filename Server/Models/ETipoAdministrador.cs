using System;
using System.Collections.Generic;

namespace Server.Models;

public class ETipoAdministrador
{
    public int? Id { get; set; }

    public int Tipo { get; set; }

    public decimal Salario { get; set; }

    public ETipoAdministrador()
    {
        
    }

    public ETipoAdministrador(int? id, int tipo, decimal salario)
    {
        Id = id;
        Tipo = tipo;
        Salario = salario;
    }
}
