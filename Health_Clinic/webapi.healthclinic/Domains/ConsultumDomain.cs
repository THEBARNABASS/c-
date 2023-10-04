using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains;

public class ConsultumDomain
{
    [Key]
    public Guid IdConsulta { get; set; } = Guid.NewGuid();

	[Required(ErrorMessage = "O Campo Paciente eh obrigatorio!!")]
	public Guid IdPaciente { get; set; }

	[Required(ErrorMessage = "O Campo Medico eh obrigatorio!!")]
	public Guid IdMedico { get; set; }

	[Required(ErrorMessage = "O Campo Status eh obrigatorio!!")]
	public Guid IdStatusConsulta { get; set; }

	
	[Column(TypeName = "TIME")]
	[Required(ErrorMessage = "horario abertura obrigatorio!")]
	public TimeOnly DataAgendamento { get; set; }


	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "O Campo Descricao eh obrigatorio!!")]
	public string? Descricao { get; set; }


}
