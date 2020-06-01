using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PI2EmAspNet.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classificacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeClassificacao = table.Column<string>(maxLength: 5, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classificacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "desenvolvedora",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDesenvolvedora = table.Column<string>(maxLength: 30, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desenvolvedora", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "diretor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDiretor = table.Column<string>(maxLength: 30, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diretor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeGenero = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "modojogo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeModo = table.Column<string>(maxLength: 20, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modojogo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "plataforma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomePlataforma = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plataforma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeTipo = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jogo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClassificacaoId = table.Column<int>(nullable: true),
                    DesenvolvedoraId = table.Column<int>(nullable: true),
                    DiretorId = table.Column<int>(nullable: true),
                    ModoJogoId = table.Column<int>(nullable: true),
                    PlataformaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jogo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_jogo_classificacao_ClassificacaoId",
                        column: x => x.ClassificacaoId,
                        principalTable: "classificacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_jogo_desenvolvedora_DesenvolvedoraId",
                        column: x => x.DesenvolvedoraId,
                        principalTable: "desenvolvedora",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_jogo_diretor_DiretorId",
                        column: x => x.DiretorId,
                        principalTable: "diretor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_jogo_modojogo_ModoJogoId",
                        column: x => x.ModoJogoId,
                        principalTable: "modojogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_jogo_plataforma_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "plataforma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Apelido = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    TipoUsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoUsuarios_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TipoUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JogoGenero",
                columns: table => new
                {
                    JogoId = table.Column<int>(nullable: false),
                    GeneroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogoGenero", x => new { x.JogoId, x.GeneroId });
                    table.ForeignKey(
                        name: "FK_JogoGenero_genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogoGenero_jogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "jogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JogoPlataforma",
                columns: table => new
                {
                    JogoId = table.Column<int>(nullable: false),
                    PlataformaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogoPlataforma", x => new { x.JogoId, x.PlataformaId });
                    table.ForeignKey(
                        name: "FK_JogoPlataforma_jogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "jogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogoPlataforma_plataforma_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "plataforma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sugestoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sugestoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sugestoes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_jogo_ClassificacaoId",
                table: "jogo",
                column: "ClassificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_jogo_DesenvolvedoraId",
                table: "jogo",
                column: "DesenvolvedoraId");

            migrationBuilder.CreateIndex(
                name: "IX_jogo_DiretorId",
                table: "jogo",
                column: "DiretorId");

            migrationBuilder.CreateIndex(
                name: "IX_jogo_ModoJogoId",
                table: "jogo",
                column: "ModoJogoId");

            migrationBuilder.CreateIndex(
                name: "IX_jogo_PlataformaId",
                table: "jogo",
                column: "PlataformaId");

            migrationBuilder.CreateIndex(
                name: "IX_JogoGenero_GeneroId",
                table: "JogoGenero",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_JogoPlataforma_PlataformaId",
                table: "JogoPlataforma",
                column: "PlataformaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UsuarioId",
                table: "Reviews",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Sugestoes_UsuarioId",
                table: "Sugestoes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Apelido",
                table: "Usuarios",
                column: "Apelido",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JogoGenero");

            migrationBuilder.DropTable(
                name: "JogoPlataforma");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Sugestoes");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "jogo");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "classificacao");

            migrationBuilder.DropTable(
                name: "desenvolvedora");

            migrationBuilder.DropTable(
                name: "diretor");

            migrationBuilder.DropTable(
                name: "modojogo");

            migrationBuilder.DropTable(
                name: "plataforma");

            migrationBuilder.DropTable(
                name: "TipoUsuarios");
        }
    }
}
