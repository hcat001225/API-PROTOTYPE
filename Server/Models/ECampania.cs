using System;
using System.Collections.Generic;

namespace Server.Models;

public class ECampania
{
    public int? Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaFinCampania { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int IdAdministrador { get; set; }

    public int IdCiudad { get; set; }

    public ECampania()
    {
        
    }

    public ECampania(int? id, string nombre, string titulo, string descripcion, string direccion, string estado, DateTime fechaCreacion, DateTime fechaFinCampania, DateTime? fechaActualizacion, int idAdministrador, int idCiudad)
    {
        Id = id;
        Nombre = nombre;
        Titulo = titulo;
        Descripcion = descripcion;
        Direccion = direccion;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaFinCampania = fechaFinCampania;
        FechaActualizacion = fechaActualizacion;
        IdAdministrador = idAdministrador;
        IdCiudad = idCiudad;
    }
}
