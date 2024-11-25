using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

public partial class Reporte
{
    [Key]
    public int IdReporte { get; set; }

    public int Inicio { get; set; }

    public int Fin { get; set; }

    public int Servicio { get; set; }

    [ForeignKey("Fin")]
    [InverseProperty("ReporteFinNavigations")]
    public virtual Dia FinNavigation { get; set; } = null!;

    [ForeignKey("Inicio")]
    [InverseProperty("ReporteInicioNavigations")]
    public virtual Dia InicioNavigation { get; set; } = null!;

    [ForeignKey("Servicio")]
    [InverseProperty("Reportes")]
    public virtual Servicio ServicioNavigation { get; set; } = null!;
}
