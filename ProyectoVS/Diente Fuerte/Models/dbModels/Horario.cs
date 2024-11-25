using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

public partial class Horario
{
    [Key]
    public int IdHora { get; set; }

    [StringLength(50)]
    public string HorariosDisponibles { get; set; } = null!;

    [InverseProperty("HoraSolicitadaNavigation")]
    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
}
