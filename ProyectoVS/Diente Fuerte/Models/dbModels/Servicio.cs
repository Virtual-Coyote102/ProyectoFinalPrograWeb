using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

public partial class Servicio
{
    [Key]
    public int IdServicio { get; set; }

    [StringLength(50)]
    public string NombreServicio { get; set; } = null!;

    [StringLength(300)]
    public string DescripcionServicio { get; set; } = null!;

    [StringLength(50)]
    public string TiempoAproximado { get; set; } = null!;

    public int PrecioServicio { get; set; }

    public int EstadoServicio { get; set; }

    [InverseProperty("ServicioNavigation")]
    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    [InverseProperty("ServicioNavigation")]
    public virtual ICollection<Reporte> Reportes { get; set; } = new List<Reporte>();
}
