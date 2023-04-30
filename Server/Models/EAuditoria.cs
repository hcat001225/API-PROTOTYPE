using System;
using System.Collections.Generic;

namespace Server.Models;

public class EAuditoria
{
    public int? Id { get; set; }

    public string Tabla { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string InformacionAntigua { get; set; } = null!;

    public string InformacionNueva { get; set; } = null!;

    public EAuditoria()
    {
        
    }

    public EAuditoria(int? id, string tabla, string descripcion, string informacionAntigua, string informacionNueva)
    {
        Id = id;
        Tabla = tabla;
        Descripcion = descripcion;
        InformacionAntigua = informacionAntigua;
        InformacionNueva = informacionNueva;
    }
}
