using System;
using System.Collections.Generic;

namespace Server.Models;

public partial class ECliente
{
    public int? Id { get; set; }

    public int Puntos { get; set; }

    public string? Qr { get; set; }
    public ECliente()
    {
        
    }

    public ECliente(int? id, int puntos, string? qr)
    {
        Id = id;
        Puntos = puntos;
        Qr = qr;
    }
}
