using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NestQuest.Migrations
{
    /// <inheritdoc />
    public partial class v2_updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Properties_InterestedPropId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Owners_ownerId1",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_ProtectedTypes_propTypeId",
                table: "Properties");

            migrationBuilder.DropTable(
                name: "ProtectedTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_ClientId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Properties_propTypeId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Owners_ownerId1",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "TransId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "propTypeId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ownerId1",
                table: "Owners");

            migrationBuilder.RenameColumn(
                name: "TransType",
                table: "Transactions",
                newName: "Type");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransDate",
                table: "Transactions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "InterestedPropId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                columns: new[] { "ClientId", "PropertyId" });

            migrationBuilder.CreateTable(
                name: "PropertyImages",
                columns: table => new
                {
                    ImgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropId = table.Column<int>(type: "int", nullable: false),
                    propertypropId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyImages", x => x.ImgId);
                    table.ForeignKey(
                        name: "FK_PropertyImages_Properties_propertypropId",
                        column: x => x.propertypropId,
                        principalTable: "Properties",
                        principalColumn: "propId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImages_propertypropId",
                table: "PropertyImages",
                column: "propertypropId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Properties_InterestedPropId",
                table: "Clients",
                column: "InterestedPropId",
                principalTable: "Properties",
                principalColumn: "propId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Properties_InterestedPropId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "PropertyImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Transactions",
                newName: "TransType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "propTypeId",
                table: "Properties",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ownerId1",
                table: "Owners",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InterestedPropId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "TransId");

            migrationBuilder.CreateTable(
                name: "ProtectedTypes",
                columns: table => new
                {
                    propTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectedTypes", x => x.propTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FullName", "Password", "Role" },
                values: new object[] { 1, "doha123@gmail.com", "Doha Medhat", "doha123", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ClientId",
                table: "Transactions",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_propTypeId",
                table: "Properties",
                column: "propTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_ownerId1",
                table: "Owners",
                column: "ownerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Properties_InterestedPropId",
                table: "Clients",
                column: "InterestedPropId",
                principalTable: "Properties",
                principalColumn: "propId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Owners_ownerId1",
                table: "Owners",
                column: "ownerId1",
                principalTable: "Owners",
                principalColumn: "ownerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_ProtectedTypes_propTypeId",
                table: "Properties",
                column: "propTypeId",
                principalTable: "ProtectedTypes",
                principalColumn: "propTypeId");
        }
    }
}
