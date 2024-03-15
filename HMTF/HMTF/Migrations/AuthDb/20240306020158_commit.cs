using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMTF.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class commit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dadb68d-b036-412d-8743-185c4bd188a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce751e81-4821-4f0a-b36a-724cb2a871db", "AQAAAAIAAYagAAAAEMvPuZHcnO3DQBNXYnGsFB8H6KimgAOaYemS+in28KwerxX9mfc+jpkpz+/l6nQxXw==", "9e485584-60b2-4ede-bd54-0599f3d246f3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dadb68d-b036-412d-8743-185c4bd188a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39d132e2-e2fd-457d-865f-b7ff06b42aa6", "AQAAAAIAAYagAAAAENT6C51m9AUV431QixMSSFdaLnxbl2RMLdPEc/GTNCmvQru4TFiQh1kJZSqhRdMwbA==", "eaa3c0db-0ba3-4d4d-bce5-1b4f329fa7f2" });
        }
    }
}
