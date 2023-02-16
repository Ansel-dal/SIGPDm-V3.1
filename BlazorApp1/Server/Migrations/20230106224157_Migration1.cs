using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Cuit = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Mail = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NombreContacto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Observaciones = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RazonSocial = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Corredor = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Expreso = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    domicilioEntrega = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cotizaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    titulo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    descripcion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    alcance = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    tratamientosuperficial = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    color = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    valorpeso = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    valordolar = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    estado = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    planos = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    codigo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    cantidad = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    observaciones = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    fechaentrega = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cotizaciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Names = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastNames = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insumo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockMin = table.Column<int>(type: "int", nullable: true),
                    StockMax = table.Column<int>(type: "int", nullable: true),
                    StockReal = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Codigo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Foto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Recepcion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MaquinasHerramientas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Nombre = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime", nullable: true),
                    Codigo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Asignacion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PeriodicidadMantenimiento = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DescripcionMantenimiento = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Estado = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MotivoEstado = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Disposicion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MotivoDisposicion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaquinasHerramientas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MateriaPrima",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockMin = table.Column<int>(type: "int", nullable: true),
                    StockMax = table.Column<int>(type: "int", nullable: true),
                    StockReal = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Codigo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaPrima", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ordencompra",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    especificacion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    archivo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    aprobada = table.Column<DateTime>(type: "datetime", nullable: true),
                    generada = table.Column<DateTime>(type: "datetime", nullable: true),
                    recepcionada = table.Column<DateTime>(type: "datetime", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: true),
                    insumo = table.Column<int>(type: "int", nullable: true),
                    proveedor = table.Column<int>(type: "int", nullable: true),
                    precio = table.Column<int>(type: "int", nullable: true),
                    condicionPago = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordencompra", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ordentrabajo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    fechaentrega = table.Column<DateTime>(type: "datetime", nullable: true),
                    descripcion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    lugarentrega = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    especificaciones = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    estado = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    planos = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    codigo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    despiece = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    pedidofabrica = table.Column<DateTime>(type: "datetime", nullable: true),
                    cantidad = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    observaciones = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    fechas = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordentrabajo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    apellido = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dni = table.Column<int>(type: "int", nullable: true),
                    mail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    condicionContractual = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    legajo = table.Column<int>(type: "int", nullable: true),
                    puesto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    categoria = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    premioEstablecido = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Cuit = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Mail = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NombreContacto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Observaciones = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RazonSocial = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    categorias = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Repuesto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockMin = table.Column<int>(type: "int", nullable: true),
                    StockMax = table.Column<int>(type: "int", nullable: true),
                    StockReal = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Codigo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Foto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuesto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles_1", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "cotizaciones");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Insumo");

            migrationBuilder.DropTable(
                name: "MaquinasHerramientas");

            migrationBuilder.DropTable(
                name: "MateriaPrima");

            migrationBuilder.DropTable(
                name: "ordencompra");

            migrationBuilder.DropTable(
                name: "ordentrabajo");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Repuesto");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
