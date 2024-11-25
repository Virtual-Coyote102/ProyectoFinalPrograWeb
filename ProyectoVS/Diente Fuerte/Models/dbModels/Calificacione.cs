using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

public partial class Calificacione
{
    [Key]
    public int IdCalificacion { get; set; }

    [StringLength(200)]
    public string? Comentario { get; set; }

    public int Calificacion { get; set; }

    [StringLength(100)]
    public string NombreCliente { get; set; } = null!;

    [StringLength(50)]
    public string FechaComentario { get; set; } = null!;
}
