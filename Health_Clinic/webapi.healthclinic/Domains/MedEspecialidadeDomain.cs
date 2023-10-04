using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains;

public class MedEspecialidadeDomain
{
    [Key]
    public Guid IdEspecialidade { get; set; } = Guid.NewGuid();

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Nome eh obrigatorio!!")]
	public string? NomeEspecialidae { get; set; }

}
