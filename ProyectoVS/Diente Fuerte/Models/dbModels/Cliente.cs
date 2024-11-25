using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

public partial class Cliente
{
    [Key]
    [Column("CURP_IdCliente")]
    [StringLength(18)]
    public string CurpIdCliente { get; set; } = null!;

    [StringLength(50)]
    public string NombreCliente { get; set; } = null!;

    public int EdadCliente { get; set; }

    public int Celular { get; set; }

    public int Servicio { get; set; }

    [InverseProperty("CurpIdClienteNavigation")]
    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();

    [ForeignKey("Servicio")]
    [InverseProperty("Clientes")]
    public virtual Servicio ServicioNavigation { get; set; } = null!;
}
