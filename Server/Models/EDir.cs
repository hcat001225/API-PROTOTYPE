using System;
using System.Collections.Generic;

namespace Server.Models;

public class EDir
{
    public int? Id { get; set; }

    public string Nombre { get; set; } = null!;

    public EDir()
    {
        
    }

    public EDir(int? id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}
