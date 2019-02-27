using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace _3oChallengeApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<DateTimeOffset>(nullable: false),
                    ValidTill = table.Column<DateTimeOffset>(nullable: false),
                    WinnerCondition = table.Column<string>(nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Challenges_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChallengeUser",
                columns: table => new
                {
                    ChallengeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeUser", x => new { x.ChallengeId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ChallengeUser_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChallengeUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InputChallenges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ChallengeId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputChallenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InputChallenges_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoteChallenges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ChallengeId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteChallenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteChallenges_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InputChallengeAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    InputChallengeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputChallengeAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InputChallengeAnswers_InputChallenges_InputChallengeId",
                        column: x => x.InputChallengeId,
                        principalTable: "InputChallenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InputChallengeAnswers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoteChallengeItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    VoteChallengeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteChallengeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteChallengeItems_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VoteChallengeItems_VoteChallenges_VoteChallengeId",
                        column: x => x.VoteChallengeId,
                        principalTable: "VoteChallenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoteChallengeAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    VoteChallengeItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteChallengeAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteChallengeAnswers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VoteChallengeAnswers_VoteChallengeItems_VoteChallengeItemId",
                        column: x => x.VoteChallengeItemId,
                        principalTable: "VoteChallengeItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_UserId",
                table: "Challenges",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeUser_UserId",
                table: "ChallengeUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InputChallengeAnswers_InputChallengeId",
                table: "InputChallengeAnswers",
                column: "InputChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_InputChallengeAnswers_UserId",
                table: "InputChallengeAnswers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InputChallenges_ChallengeId",
                table: "InputChallenges",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteChallengeAnswers_UserId",
                table: "VoteChallengeAnswers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteChallengeAnswers_VoteChallengeItemId",
                table: "VoteChallengeAnswers",
                column: "VoteChallengeItemId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteChallengeItems_UserId",
                table: "VoteChallengeItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteChallengeItems_VoteChallengeId",
                table: "VoteChallengeItems",
                column: "VoteChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteChallenges_ChallengeId",
                table: "VoteChallenges",
                column: "ChallengeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChallengeUser");

            migrationBuilder.DropTable(
                name: "InputChallengeAnswers");

            migrationBuilder.DropTable(
                name: "VoteChallengeAnswers");

            migrationBuilder.DropTable(
                name: "InputChallenges");

            migrationBuilder.DropTable(
                name: "VoteChallengeItems");

            migrationBuilder.DropTable(
                name: "VoteChallenges");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
