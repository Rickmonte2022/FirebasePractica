using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public partial class Alumno
{
    [Key]
    [Display(Name="ID")]
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public int? Dui { get; set; }

    public int? Estado { get; set; }
}
