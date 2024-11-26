using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diente_Fuerte.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Calificaciones",
                columns: table => new
                {
                    IdCalificacion = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Calificacion = table.Column<int>(type: "int", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaComentario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Califica__40E4A7516388F61D", x => x.IdCalificacion);
                });

            migrationBuilder.CreateTable(
                name: "Dias",
                columns: table => new
                {
                    IdDias = table.Column<int>(type: "int", nullable: false),
                    DiaDisponible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dias__F168F64119162CE7", x => x.IdDias);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    IdHora = table.Column<int>(type: "int", nullable: false),
                    HorariosDisponibles = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Horarios__5FEB39EB2AA50FB6", x => x.IdHora);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    NombreRol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles__2A49584CE98623EC", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    IdServicio = table.Column<int>(type: "int", nullable: false),
                    NombreServicio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DescripcionServicio = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    TiempoAproximado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrecioServicio = table.Column<int>(type: "int", nullable: false),
                    EstadoServicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Servicio__2DCCF9A2DF295F1C", x => x.IdServicio);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClaveUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RolUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuarios__5B65BF97E98BCBA2", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK__Usuarios__RolUsu__5070F446",
                        column: x => x.RolUsuario,
                        principalTable: "Roles",
                        principalColumn: "IdRol");
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CURP_IdCliente = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EdadCliente = table.Column<int>(type: "int", nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Servicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Clientes__1225D6FA45966444", x => x.CURP_IdCliente);
                    table.ForeignKey(
                        name: "FK__Clientes__Servic__3F466844",
                        column: x => x.Servicio,
                        principalTable: "Servicios",
                        principalColumn: "IdServicio");
                });

            migrationBuilder.CreateTable(
                name: "Reportes",
                columns: table => new
                {
                    IdReporte = table.Column<int>(type: "int", nullable: false),
                    Inicio = table.Column<int>(type: "int", nullable: false),
                    Fin = table.Column<int>(type: "int", nullable: false),
                    Servicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reportes__F9561136386DFB4A", x => x.IdReporte);
                    table.ForeignKey(
                        name: "FK__Reportes__Fin__49C3F6B7",
                        column: x => x.Fin,
                        principalTable: "Dias",
                        principalColumn: "IdDias");
                    table.ForeignKey(
                        name: "FK__Reportes__Inicio__4AB81AF0",
                        column: x => x.Inicio,
                        principalTable: "Dias",
                        principalColumn: "IdDias");
                    table.ForeignKey(
                        name: "FK__Reportes__Servic__4BAC3F29",
                        column: x => x.Servicio,
                        principalTable: "Servicios",
                        principalColumn: "IdServicio");
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    IdCita = table.Column<int>(type: "int", nullable: false),
                    CURP_IdCliente = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    FechaSolicitada = table.Column<int>(type: "int", nullable: false),
                    HoraSolicitada = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Citas__394B02026D0B393A", x => x.IdCita);
                    table.ForeignKey(
                        name: "FK__Citas__CURP_IdCl__4222D4EF",
                        column: x => x.CURP_IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "CURP_IdCliente");
                    table.ForeignKey(
                        name: "FK__Citas__FechaSoli__4316F928",
                        column: x => x.FechaSolicitada,
                        principalTable: "Dias",
                        principalColumn: "IdDias");
                    table.ForeignKey(
                        name: "FK__Citas__HoraSolic__440B1D61",
                        column: x => x.HoraSolicitada,
                        principalTable: "Horarios",
                        principalColumn: "IdHora");
                });

            migrationBuilder.CreateTable(
                name: "Expediente",
                columns: table => new
                {
                    IdArchivo = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    NombrePaciente = table.Column<int>(type: "int", nullable: false),
                    InformacionPaciente = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NuevosDatos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Expedien__26B92111FACF8E2E", x => x.IdArchivo);
                    table.ForeignKey(
                        name: "FK__Expedient__IdCli__46E78A0C",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "CURP_IdCliente");
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
                filter: "[NormalizedName] IS NOT NULL");

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
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_CURP_IdCliente",
                table: "Citas",
                column: "CURP_IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_FechaSolicitada",
                table: "Citas",
                column: "FechaSolicitada");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_HoraSolicitada",
                table: "Citas",
                column: "HoraSolicitada");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Servicio",
                table: "Clientes",
                column: "Servicio");

            migrationBuilder.CreateIndex(
                name: "IX_Expediente_IdCliente",
                table: "Expediente",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reportes_Fin",
                table: "Reportes",
                column: "Fin");

            migrationBuilder.CreateIndex(
                name: "IX_Reportes_Inicio",
                table: "Reportes",
                column: "Inicio");

            migrationBuilder.CreateIndex(
                name: "IX_Reportes_Servicio",
                table: "Reportes",
                column: "Servicio");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolUsuario",
                table: "Usuarios",
                column: "RolUsuario");
        }

        /// <inheritdoc />
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
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Expediente");

            migrationBuilder.DropTable(
                name: "Reportes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Dias");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Servicios");
        }
    }
}
