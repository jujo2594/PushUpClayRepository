using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class migrations1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterDatabase()
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "cargo",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         nombreCargo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "direccioncliente",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         tipoVia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numeroPrincipal = table.Column<int>(type: "int", nullable: false),
            //         letraPrincipal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         bis = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         letraSecundaria = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         cardinalPrimario = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numeroSecundario = table.Column<int>(type: "int", nullable: false),
            //         cardinalSecundario = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdMunicipiofk = table.Column<int>(type: "int", nullable: false),
            //         IdClienteFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "direccionempleado",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         tipoVia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numeroPrincipal = table.Column<int>(type: "int", nullable: false),
            //         letraPrincipal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         bis = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         letraSecundaria = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         cardinalPrimario = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numeroSecundario = table.Column<int>(type: "int", nullable: false),
            //         cardinalSecundario = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdMunicipiofk = table.Column<int>(type: "int", nullable: false),
            //         IdEmpleadoFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "estado",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "pais",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "turnos",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         nombreTurno = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         horTurnoI = table.Column<TimeOnly>(type: "time", nullable: false),
            //         horTurnoF = table.Column<TimeOnly>(type: "time", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "departamento",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         idPaisFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "departamento_ibfk_1",
            //             column: x => x.idPaisFk,
            //             principalTable: "pais",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "municipio",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         idDepartamentoFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "municipio_ibfk_1",
            //             column: x => x.idDepartamentoFk,
            //             principalTable: "departamento",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "cliente",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         idCliente = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         nroContacto = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         dateReg = table.Column<DateOnly>(type: "date", nullable: false),
            //         IdMunicipioFk = table.Column<int>(type: "int", nullable: false),
            //         IdDireccionFK = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "cliente_ibfk_1",
            //             column: x => x.IdMunicipioFk,
            //             principalTable: "municipio",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "cliente_ibfk_2",
            //             column: x => x.IdDireccionFK,
            //             principalTable: "direccioncliente",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "empleado",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         idEmpleado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         dateReg = table.Column<DateOnly>(type: "date", nullable: false),
            //         nroContacto = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdCargoFk = table.Column<int>(type: "int", nullable: false),
            //         IdMunicipioFk = table.Column<int>(type: "int", nullable: false),
            //         IdDireccionFK = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "empleado_ibfk_1",
            //             column: x => x.IdCargoFk,
            //             principalTable: "cargo",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "empleado_ibfk_2",
            //             column: x => x.IdMunicipioFk,
            //             principalTable: "municipio",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "empleado_ibfk_3",
            //             column: x => x.IdDireccionFK,
            //             principalTable: "direccionempleado",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "contrato",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         fechContrato = table.Column<DateOnly>(type: "date", nullable: false),
            //         fechaFin = table.Column<DateOnly>(type: "date", nullable: false),
            //         IdClienteFk = table.Column<int>(type: "int", nullable: false),
            //         IdEmpleadoFk = table.Column<int>(type: "int", nullable: false),
            //         IdEstadoFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "contrato_ibfk_1",
            //             column: x => x.IdEstadoFk,
            //             principalTable: "estado",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "contrato_ibfk_2",
            //             column: x => x.IdEmpleadoFk,
            //             principalTable: "empleado",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "contrato_ibfk_3",
            //             column: x => x.IdClienteFk,
            //             principalTable: "cliente",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "programacion",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         IdContratoFk = table.Column<int>(type: "int", nullable: false),
            //         IdTurnoFk = table.Column<int>(type: "int", nullable: false),
            //         IdEmpleadoFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "programacion_ibfk_1",
            //             column: x => x.IdEmpleadoFk,
            //             principalTable: "empleado",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "programacion_ibfk_2",
            //             column: x => x.IdContratoFk,
            //             principalTable: "contrato",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "programacion_ibfk_3",
            //             column: x => x.IdTurnoFk,
            //             principalTable: "turnos",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateIndex(
            //     name: "IdDireccionFK",
            //     table: "cliente",
            //     column: "IdDireccionFK");

            // migrationBuilder.CreateIndex(
            //     name: "IdMunicipioFk",
            //     table: "cliente",
            //     column: "IdMunicipioFk");

            // migrationBuilder.CreateIndex(
            //     name: "idCliente",
            //     table: "cliente",
            //     column: "idCliente",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IdClienteFk",
            //     table: "contrato",
            //     column: "IdClienteFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdEmpleadoFk",
            //     table: "contrato",
            //     column: "IdEmpleadoFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdEstadoFk",
            //     table: "contrato",
            //     column: "IdEstadoFk");

            // migrationBuilder.CreateIndex(
            //     name: "idPaisFk",
            //     table: "departamento",
            //     column: "idPaisFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdCargoFk",
            //     table: "empleado",
            //     column: "IdCargoFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdDireccionFK1",
            //     table: "empleado",
            //     column: "IdDireccionFK");

            // migrationBuilder.CreateIndex(
            //     name: "IdMunicipioFk1",
            //     table: "empleado",
            //     column: "IdMunicipioFk");

            // migrationBuilder.CreateIndex(
            //     name: "idEmpleado",
            //     table: "empleado",
            //     column: "idEmpleado",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "idDepartamentoFk",
            //     table: "municipio",
            //     column: "idDepartamentoFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdContratoFk",
            //     table: "programacion",
            //     column: "IdContratoFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdEmpleadoFk1",
            //     table: "programacion",
            //     column: "IdEmpleadoFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdTurnoFk",
            //     table: "programacion",
            //     column: "IdTurnoFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "programacion");

            // migrationBuilder.DropTable(
            //     name: "contrato");

            // migrationBuilder.DropTable(
            //     name: "turnos");

            // migrationBuilder.DropTable(
            //     name: "estado");

            // migrationBuilder.DropTable(
            //     name: "empleado");

            // migrationBuilder.DropTable(
            //     name: "cliente");

            // migrationBuilder.DropTable(
            //     name: "cargo");

            // migrationBuilder.DropTable(
            //     name: "direccionempleado");

            // migrationBuilder.DropTable(
            //     name: "municipio");

            // migrationBuilder.DropTable(
            //     name: "direccioncliente");

            // migrationBuilder.DropTable(
            //     name: "departamento");

            // migrationBuilder.DropTable(
            //     name: "pais");
        }
    }
}
