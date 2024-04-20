using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public partial class Materia
{
    public int Id { get; set; }

    [Display(Name = "Materia")]
    public string? Materia1 { get; set; }
    
    [Display(Name = "Unidad V")]
    public int? UnidadesValorativas { get; set; }

    public string? Estado { get; set; }
}
