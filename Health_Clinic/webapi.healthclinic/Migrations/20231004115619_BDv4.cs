using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.healthclinic.Migrations
{
    /// <inheritdoc />
    public partial class BDv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinicas_Enderecos_IdEnderecoNavigationIdEndereco",
                table: "Clinicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Medicos_IdMedicoNavigationIdMedico",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Pacientes_IdPacienteNavigationIdPaciente",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Statusconsulta_IdStatusConsultaNavigationIdStatusConsulta",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Clinicas_IdClinica",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Enderecos_IdEndereco",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_MedEspecialidades_IdEspecialidade",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_UsuarioDomain_IdUsuario",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_UsuarioDomain_IdUsuario",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_IdUsuario",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_IdClinica",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_IdEndereco",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_IdEspecialidade",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_IdUsuario",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_IdMedicoNavigationIdMedico",
                table: "Consulta");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_IdPacienteNavigationIdPaciente",
                table: "Consulta");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_IdStatusConsultaNavigationIdStatusConsulta",
                table: "Consulta");

            migrationBuilder.DropIndex(
                name: "IX_Clinicas_IdEnderecoNavigationIdEndereco",
                table: "Clinicas");

            migrationBuilder.DropColumn(
                name: "IdMedicoNavigationIdMedico",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "IdPacienteNavigationIdPaciente",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "IdStatusConsultaNavigationIdStatusConsulta",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "IdEnderecoNavigationIdEndereco",
                table: "Clinicas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdMedicoNavigationIdMedico",
                table: "Consulta",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdPacienteNavigationIdPaciente",
                table: "Consulta",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdStatusConsultaNavigationIdStatusConsulta",
                table: "Consulta",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdEnderecoNavigationIdEndereco",
                table: "Clinicas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_IdUsuario",
                table: "Pacientes",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_IdClinica",
                table: "Medicos",
                column: "IdClinica");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_IdEndereco",
                table: "Medicos",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_IdEspecialidade",
                table: "Medicos",
                column: "IdEspecialidade");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_IdUsuario",
                table: "Medicos",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdMedicoNavigationIdMedico",
                table: "Consulta",
                column: "IdMedicoNavigationIdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdPacienteNavigationIdPaciente",
                table: "Consulta",
                column: "IdPacienteNavigationIdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdStatusConsultaNavigationIdStatusConsulta",
                table: "Consulta",
                column: "IdStatusConsultaNavigationIdStatusConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_Clinicas_IdEnderecoNavigationIdEndereco",
                table: "Clinicas",
                column: "IdEnderecoNavigationIdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinicas_Enderecos_IdEnderecoNavigationIdEndereco",
                table: "Clinicas",
                column: "IdEnderecoNavigationIdEndereco",
                principalTable: "Enderecos",
                principalColumn: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Medicos_IdMedicoNavigationIdMedico",
                table: "Consulta",
                column: "IdMedicoNavigationIdMedico",
                principalTable: "Medicos",
                principalColumn: "IdMedico");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Pacientes_IdPacienteNavigationIdPaciente",
                table: "Consulta",
                column: "IdPacienteNavigationIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Statusconsulta_IdStatusConsultaNavigationIdStatusConsulta",
                table: "Consulta",
                column: "IdStatusConsultaNavigationIdStatusConsulta",
                principalTable: "Statusconsulta",
                principalColumn: "IdStatusConsulta");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Clinicas_IdClinica",
                table: "Medicos",
                column: "IdClinica",
                principalTable: "Clinicas",
                principalColumn: "IdClinica",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Enderecos_IdEndereco",
                table: "Medicos",
                column: "IdEndereco",
                principalTable: "Enderecos",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_MedEspecialidades_IdEspecialidade",
                table: "Medicos",
                column: "IdEspecialidade",
                principalTable: "MedEspecialidades",
                principalColumn: "IdEspecialidade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_UsuarioDomain_IdUsuario",
                table: "Medicos",
                column: "IdUsuario",
                principalTable: "UsuarioDomain",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_UsuarioDomain_IdUsuario",
                table: "Pacientes",
                column: "IdUsuario",
                principalTable: "UsuarioDomain",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
