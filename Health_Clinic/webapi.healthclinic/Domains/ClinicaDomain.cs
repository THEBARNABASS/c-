using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains;

public class ClinicaDomain
{
    [Key]
    public Guid IdClinica { get; set; } = Guid.NewGuid();

	[Required(ErrorMessage = "O Campo Endereco eh obrigatorio!!")]
	public Guid IdEndereco { get; set; }

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Nome eh obrigatorio!!")]
	public string? Nome { get; set; }

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Cnpj eh obrigatorio!!")]
	public string? Cnpj { get; set; }


	[Column(TypeName = "TIME")]
	[Required(ErrorMessage = "horario abertura obrigatorio!")]

	public TimeOnly HoraAbertura { get; set; }

	[Column(TypeName = "TIME")]
	[Required(ErrorMessage = "horario Fechamento obrigatorio!")]

	public TimeOnly HoraFechamento { get; set; }

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo RazaoSocial eh obrigatorio!!")]
	public string? RazaoSocial { get; set; }


}
