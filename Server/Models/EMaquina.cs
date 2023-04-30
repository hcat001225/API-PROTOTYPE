using System;
using System.Collections.Generic;

namespace Server.Models;

public class EMaquina
{
    public byte? Id { get; set; }

    public string Estado { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }
    public EMaquina()
    {
        
    }

    public EMaquina(byte? id, string estado, string descripcion, string? latitud, string? longitud)
    {
        Id = id;
        Estado = estado;
        Descripcion = descripcion;
        Latitud = latitud;
        Longitud = longitud;
    }
}
