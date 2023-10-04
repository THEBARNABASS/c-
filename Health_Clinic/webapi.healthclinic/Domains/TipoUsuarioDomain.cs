using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.healthclinic.Domains;

public class TipoUsuarioDomain
{
	[Key]
    public Guid IdTipoDeUsuario { get; set; } = Guid.NewGuid();

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Nome do Tipo de Usuario eh obrigatorio!!")]
	public string? NomeTipoUsuario { get; set; }

}
