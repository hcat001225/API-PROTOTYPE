using System;
using System.Collections.Generic;

namespace Server.Models;

public partial class EAdministrador
{
    public int? Id { get; set; }

    public int Tarea { get; set; }

    public string Email { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public int IdTipoAdministrador { get; set; }

    public EAdministrador()
    {
        
    }

    public EAdministrador(int? id, int tarea, string email, string contrasena, int idTipoAdministrador)
    {
        Id = id;
        Tarea = tarea;
        Email = email;
        Contrasena = contrasena;
        IdTipoAdministrador = idTipoAdministrador;
    }
}
