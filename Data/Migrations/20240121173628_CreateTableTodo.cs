using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorTarefasAutenticacao.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableTodo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarefaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarefaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataTarefa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusTarefa = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
