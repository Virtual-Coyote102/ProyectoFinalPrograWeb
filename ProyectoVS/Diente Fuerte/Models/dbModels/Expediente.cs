using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

[Table("Expediente")]
public partial class Expediente
{
    [Key]
    public int IdArchivo { get; set; }

    [StringLength(18)]
    public string IdCliente { get; set; } = null!;

    public int NombrePaciente { get; set; }

    [StringLength(500)]
    public string InformacionPaciente { get; set; } = null!;

    [StringLength(100)]
    public string? NuevosDatos { get; set; }

    [ForeignKey("IdCliente")]
    [InverseProperty("Expedientes")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
