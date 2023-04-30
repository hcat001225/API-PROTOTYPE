using System;
using System.Collections.Generic;

namespace Server.Models;

public class EPersona
{
    public int? Id { get; set; }

    public string? Nombre { get; set; }

    public string? Ci { get; set; }

    public int? NumeroCelular { get; set; }

    public DateTime? Edad { get; set; }

    public string? Sexo { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? IdCiudad { get; set; }

    public EPersona()
    {
        
    }

    public EPersona(int? id, string? nombre, string? ci, int? numeroCelular, DateTime? edad, string? sexo, string estado, DateTime fechaCreacion, DateTime? fechaActualizacion, int? idCiudad)
    {
        Id = id;
        Nombre = nombre;
        Ci = ci;
        NumeroCelular = numeroCelular;
        Edad = edad;
        Sexo = sexo;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
        IdCiudad = idCiudad;
    }
}
