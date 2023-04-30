using System;
using System.Collections.Generic;

namespace Server.Models;

public class EPais
{
    public int? Id { get; set; }

    public string Nombre { get; set; } = null!;

    public EPais()
    {
        
    }
    public EPais(int? id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}
