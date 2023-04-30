using System;
using System.Collections.Generic;

namespace Server.Models;

public class ECiudad
{
    public int? Id { get; set; }

    public string? Nombre { get; set; }

    public int IdPais { get; set; }

    public ECiudad()
    {
        
    }

    public ECiudad(int? id, string? nombre, int idPais)
    {
        Id = id;
        Nombre = nombre;
        IdPais = idPais;
    }
}
