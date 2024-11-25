using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

public partial class Cita
{
    [Key]
    public int IdCita { get; set; }

    [Column("CURP_IdCliente")]
    [StringLength(18)]
    public string CurpIdCliente { get; set; } = null!;

    public int FechaSolicitada { get; set; }

    public int HoraSolicitada { get; set; }

    public int Estado { get; set; }

    [ForeignKey("CurpIdCliente")]
    [InverseProperty("Cita")]
    public virtual Cliente CurpIdClienteNavigation { get; set; } = null!;

    [ForeignKey("FechaSolicitada")]
    [InverseProperty("Cita")]
    public virtual Dia FechaSolicitadaNavigation { get; set; } = null!;

    [ForeignKey("HoraSolicitada")]
    [InverseProperty("Cita")]
    public virtual Horario HoraSolicitadaNavigation { get; set; } = null!;
}
