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
                name: "Challenge",
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
                    CreatorId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChallengeUser",
                columns: table => new
                {
                    ChallengeId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeUser", x => new { x.ChallengeId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ChallengeUser_Challenge_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InputChallenge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ChallengeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputChallenge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InputChallenge_Challenge_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoteChallenge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ChallengeId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteChallenge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteChallenge_Challenge_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InputChallengeAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    InputChallengeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputChallengeAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InputChallengeAnswer_InputChallenge_InputChallengeId",
                        column: x => x.InputChallengeId,
                        principalTable: "InputChallenge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoteChallengeItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    VoteChallengeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteChallengeItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteChallengeItem_VoteChallenge_VoteChallengeId",
                        column: x => x.VoteChallengeId,
                        principalTable: "VoteChallenge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoteChallengeAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    VoteChallengeItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteChallengeAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteChallengeAnswer_VoteChallengeItem_VoteChallengeItemId",
                        column: x => x.VoteChallengeItemId,
                        principalTable: "VoteChallengeItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InputChallenge_ChallengeId",
                table: "InputChallenge",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_InputChallengeAnswer_InputChallengeId",
                table: "InputChallengeAnswer",
                column: "InputChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteChallenge_ChallengeId",
                table: "VoteChallenge",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteChallengeAnswer_VoteChallengeItemId",
                table: "VoteChallengeAnswer",
                column: "VoteChallengeItemId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteChallengeItem_VoteChallengeId",
                table: "VoteChallengeItem",
                column: "VoteChallengeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChallengeUser");

            migrationBuilder.DropTable(
                name: "InputChallengeAnswer");

            migrationBuilder.DropTable(
                name: "VoteChallengeAnswer");

            migrationBuilder.DropTable(
                name: "InputChallenge");

            migrationBuilder.DropTable(
                name: "VoteChallengeItem");

            migrationBuilder.DropTable(
                name: "VoteChallenge");

            migrationBuilder.DropTable(
                name: "Challenge");
        }
    }
}
