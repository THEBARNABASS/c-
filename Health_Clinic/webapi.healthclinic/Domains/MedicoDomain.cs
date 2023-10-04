using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.healthclinic.Domains;

public class MedicoDomain
{
    [Key]
    public Guid IdMedico { get; set; } = Guid.NewGuid();


	[Required(ErrorMessage = "Campo obrigatorio!")]
	public Guid IdUsuario { get; set; } 


	[Required(ErrorMessage = "Campo obrigatorio!")]
	public Guid IdEndereco { get; set; } 


	[Required(ErrorMessage = "Campo obrigatorio!")]
	public Guid IdClinica { get; set; }


	[Required(ErrorMessage = "Campo obrigatorio!")]
	public Guid IdEspecialidade { get; set; } 


	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Nome do Usuario eh obrigatorio!!")]
	public string? Nome { get; set; }


	[Column(TypeName = "CHAR(60)")]
	[Required(ErrorMessage = "O CRM eh obrigatorio!!!")]
	[StringLength(11, MinimumLength = 11, ErrorMessage = "CRM deve conter 11 caracteres!!!")]
	public string? Crm { get; set; }


}
