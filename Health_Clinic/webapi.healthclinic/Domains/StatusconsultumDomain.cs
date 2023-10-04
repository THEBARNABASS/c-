using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.healthclinic.Domains;

public class StatusconsultumDomain
{
	[Key]
    public Guid IdStatusConsulta { get; set; } = Guid.NewGuid();

	[Column(TypeName = "VARCHAR(100)")]
	[Required(ErrorMessage = "Titullo da consulta  eh obrigatorio!!")]
	public string? TituloConsulta { get; set; }


}
