using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public partial class Departamento
{
    public int Id { get; set; }
    
    [Display(Name = "Departamento")]
    public string? Departamento1 { get; set; }
}
