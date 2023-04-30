using System;
using System.Collections.Generic;

namespace Server.Models;

public class EVoto
{
    public int? Id { get; set; }

    public int IdPersona { get; set; }

    public int IdCampania { get; set; }

    public int IdOrganizacion { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Donacion { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FechaActualizacion { get; set; }


    public EVoto()
    {
        
    }

    public EVoto(int? id, int idPersona, int idCampania, int idOrganizacion, DateTime fecha, decimal donacion, string estado, DateTime? fechaActualizacion)
    {
        Id = id;
        IdPersona = idPersona;
        IdCampania = idCampania;
        IdOrganizacion = idOrganizacion;
        Fecha = fecha;
        Donacion = donacion;
        Estado = estado;
        FechaActualizacion = fechaActualizacion;
    }
}
