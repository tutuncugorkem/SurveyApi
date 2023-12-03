using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyApi.Repository.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 23, 47, 32, 129, DateTimeKind.Local).AddTicks(8712), true, "Magaza Degerlendirme", null });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2023, 12, 3, 23, 47, 32, 129, DateTimeKind.Local).AddTicks(8713), true, "Teknik Servis Degerlendirme", null });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedDate", "IsActive", "SortOrder", "SurveyId", "Title", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 23, 47, 32, 129, DateTimeKind.Local).AddTicks(8598), true, 1, 1, "Memnun kaldınız mı?", null });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedDate", "IsActive", "SortOrder", "SurveyId", "Title", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2023, 12, 3, 23, 47, 32, 129, DateTimeKind.Local).AddTicks(8599), true, 1, 2, "Bizi tavsiye eder misiniz?", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CreatedDate", "IsActive", "QuestionId", "Text", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 23, 47, 32, 129, DateTimeKind.Local).AddTicks(8453), true, 1, "Evet", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CreatedDate", "IsActive", "QuestionId", "Text", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2023, 12, 3, 23, 47, 32, 129, DateTimeKind.Local).AddTicks(8464), true, 2, "Ederim", null });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyId",
                table: "Questions",
                column: "SurveyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
