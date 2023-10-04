using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.healthclinic.Migrations
{
    /// <inheritdoc />
    public partial class BDv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioDomain_Enderecos_EnderecoDomainIdEndereco",
                table: "UsuarioDomain");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioDomain_EnderecoDomainIdEndereco",
                table: "UsuarioDomain");

            migrationBuilder.DropColumn(
                name: "EnderecoDomainIdEndereco",
                table: "UsuarioDomain");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoDomainIdEndereco",
                table: "UsuarioDomain",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioDomain_EnderecoDomainIdEndereco",
                table: "UsuarioDomain",
                column: "EnderecoDomainIdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioDomain_Enderecos_EnderecoDomainIdEndereco",
                table: "UsuarioDomain",
                column: "EnderecoDomainIdEndereco",
                principalTable: "Enderecos",
                principalColumn: "IdEndereco");
        }
    }
}
