using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyApi.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 16, 35, 525, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 16, 35, 525, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 16, 35, 525, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 16, 35, 525, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 16, 35, 525, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 16, 35, 525, DateTimeKind.Local).AddTicks(5832));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 11, 35, 326, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 11, 35, 326, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 11, 35, 326, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 11, 35, 326, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 11, 35, 326, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 12, 11, 35, 326, DateTimeKind.Local).AddTicks(8240));
        }
    }
}
