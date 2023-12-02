using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyApi.Repository.Migrations
{
    public partial class initialucuncu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "QuestionId" },
                values: new object[] { new DateTime(2023, 11, 28, 13, 42, 10, 593, DateTimeKind.Local).AddTicks(2354), 1 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "QuestionId" },
                values: new object[] { new DateTime(2023, 11, 28, 13, 42, 10, 593, DateTimeKind.Local).AddTicks(2366), 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 42, 10, 593, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 42, 10, 593, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 42, 10, 593, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 42, 10, 593, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answers");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 39, 49, 862, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 39, 49, 862, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 39, 49, 862, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 39, 49, 862, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 39, 49, 862, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 13, 39, 49, 862, DateTimeKind.Local).AddTicks(5064));
        }
    }
}
