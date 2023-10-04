using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.healthclinic.Domains;

public class PacienteDomain
{
	[Key]
    public Guid IdPaciente { get; set; } = Guid.NewGuid();

	[Required(ErrorMessage = "Campo obrigatorio!")]
	public Guid IdUsuario { get; set; } = Guid.NewGuid();


	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Nome eh obrigatorio!!")]
	public string? Nome { get; set; }

	[Column(TypeName = "TIME")]
	[Required(ErrorMessage = "O Campo data de nascimento eh obrigatorio!")]
	public TimeOnly DataNascimento { get; set; }

    public string? Telefone { get; set; }

	[Column(TypeName = "CHAR(14)")]
	[Required(ErrorMessage = "O Campo CNPJ eh obrigatorio!!!!")]
	[StringLength(14)]
	public string? Rg { get; set; }

	[Column(TypeName = "CHAR(11)")]
	[Required(ErrorMessage = "O Campo CPF eh obrigatorio!!!!")]
	[StringLength(11)]
	public string? Cpf { get; set; }

}
