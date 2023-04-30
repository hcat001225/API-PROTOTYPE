using System;
using System.Collections.Generic;

namespace Server.Models;

public class EOrganizacion
{
    public int? Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public byte? Estado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public EOrganizacion()
    {
        
    }

    public EOrganizacion(int? id, string nombre, string descripcion, byte? estado, DateTime? fechaCreacion, DateTime? fechaActualizacion)
    {
        Id = id;
        Nombre = nombre;
        Descripcion = descripcion;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
}
