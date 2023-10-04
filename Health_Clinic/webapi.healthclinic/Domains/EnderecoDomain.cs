using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.healthclinic.Domains;

public class EnderecoDomain
{
	[Key]
    public Guid IdEndereco { get; set; } = Guid.NewGuid();

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Cep eh obrigatorio!!")]
	[StringLength(8)]
	public string? Cep { get; set; }

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Estado eh obrigatorio!!")]
	public string? Estado { get; set; }

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Cidade eh obrigatorio!!")]
	public string? Cidade { get; set; }

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Bairro eh obrigatorio!!")]
	public string? Bairro { get; set; }

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Logradouro eh obrigatorio!!")]
	public string? Logradouro { get; set; }

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Nº eh obrigatorio!!")]
	public string? Nº { get; set; }

}
