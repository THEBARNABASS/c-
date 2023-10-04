using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Contexts
{
    public partial class HealthClinicContext : DbContext
    {



        public virtual DbSet<ClinicaDomain> Clinicas { get; set; }

        public virtual DbSet<ConsultumDomain> Consulta { get; set; }

        public virtual DbSet<EnderecoDomain> Enderecos { get; set; }

        public virtual DbSet<MedEspecialidadeDomain> MedEspecialidades { get; set; }

        public virtual DbSet<MedicoDomain> Medicos { get; set; }

        public virtual DbSet<PacienteDomain> Pacientes { get; set; }

        public virtual DbSet<StatusconsultumDomain> Statusconsulta { get; set; }

        public virtual DbSet<TipoUsuarioDomain> TipoUsuarios { get; set; }

        public virtual DbSet<UsuarioDomain> Usuario { get; set; }

	    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	    {

		    optionsBuilder.UseSqlServer("Server=NOTE06-S14; DataBase=Health_Clinic_bd_CodeFisrst; User Id= sa; Pwd= Senai@134; TrustServerCertificate=true", x => x.UseDateOnlyTimeOnly());

		    base.OnConfiguring(optionsBuilder);

	    }
    }
}
	