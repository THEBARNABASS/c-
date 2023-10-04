using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains;

[Table(nameof(UsuarioDomain))]
//especifica que o campo email eh unico e nao pode ter outro igual
[Index(nameof(Email), IsUnique = true)]
public class UsuarioDomain
{
	[Key]
    public Guid IdUsuario { get; set; }  = Guid.NewGuid();

	[Required(ErrorMessage = "Campo obrigatorio!")]
	public Guid IdTipoUsuario { get; set; }


	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Email eh obrigatorio!!!")]
	public string? Email { get; set; }

	[Column(TypeName = "CHAR(60)")]
	[Required(ErrorMessage = "A senha eh obrigatorio!!!")]
	[StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve conter entre 6 e 20 caracteres!!!")]
	public string? Senha { get; set; }


	[ForeignKey(nameof(IdTipoUsuario))]
	public  TipoUsuarioDomain? TipoUsuario_fk { get; set; }

}
