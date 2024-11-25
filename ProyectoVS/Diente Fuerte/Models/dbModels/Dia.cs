using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

public partial class Dia
{
    [Key]
    public int IdDias { get; set; }

    [StringLength(50)]
    public string DiaDisponible { get; set; } = null!;

    [InverseProperty("FechaSolicitadaNavigation")]
    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();

    [InverseProperty("FinNavigation")]
    public virtual ICollection<Reporte> ReporteFinNavigations { get; set; } = new List<Reporte>();

    [InverseProperty("InicioNavigation")]
    public virtual ICollection<Reporte> ReporteInicioNavigations { get; set; } = new List<Reporte>();
}
