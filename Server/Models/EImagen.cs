using System;
using System.Collections.Generic;

namespace Server.Models;

public class EImagen
{
    public int? Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public int? IdCampania { get; set; }

    public EImagen()
    {
        
    }

    public EImagen(int? id, string nombre, string estado, int? idCampania)
    {
        Id = id;
        Nombre = nombre;
        Estado = estado;
        IdCampania = idCampania;
    }
}
