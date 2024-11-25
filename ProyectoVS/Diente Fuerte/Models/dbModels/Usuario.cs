using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

public partial class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    [StringLength(50)]
    public string NombreUsuario { get; set; } = null!;

    [StringLength(50)]
    public string ClaveUsuario { get; set; } = null!;

    public int RolUsuario { get; set; }

    [ForeignKey("RolUsuario")]
    [InverseProperty("Usuarios")]
    public virtual Role RolUsuarioNavigation { get; set; } = null!;
}
