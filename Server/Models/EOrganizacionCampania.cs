using System;
using System.Collections.Generic;

namespace Server.Models;

public class EOrganizacionCampania
{
    public int? IdCampania { get; set; }

    public int IdOrganizacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public EOrganizacionCampania()
    {
        
    }

    public EOrganizacionCampania(int? idCampania, int idOrganizacion, DateTime fechaCreacion)
    {
        IdCampania = idCampania;
        IdOrganizacion = idOrganizacion;
        FechaCreacion = fechaCreacion;
    }
}
