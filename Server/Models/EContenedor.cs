using System;
using System.Collections.Generic;

namespace Server.Models;

public class EContenedor
{
    public int? Id { get; set; }

    public int IdPersona { get; set; }

    public byte IdMaquina { get; set; }

    public decimal Gramos { get; set; }

    public DateTime FechaHora { get; set; }

    public EContenedor()
    {
        
    }

    public EContenedor(int? id, int idPersona, byte idMaquina, decimal gramos, DateTime fechaHora)
    {
        Id = id;
        IdPersona = idPersona;
        IdMaquina = idMaquina;
        Gramos = gramos;
        FechaHora = fechaHora;
    }
}
