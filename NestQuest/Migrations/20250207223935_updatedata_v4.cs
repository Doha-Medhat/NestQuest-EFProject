using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NestQuest.Migrations
{
    /// <inheritdoc />
    public partial class updatedata_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Owners_ownerId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyImages_Properties_propertypropId",
                table: "PropertyImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Clients_ClientId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_PropertyImages_propertypropId",
                table: "PropertyImages");

            migrationBuilder.DropColumn(
                name: "propertypropId",
                table: "PropertyImages");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Properties");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImages_PropId",
                table: "PropertyImages",
                column: "PropId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Users_ownerId",
                table: "Properties",
                column: "ownerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImages_Properties_PropId",
                table: "PropertyImages",
                column: "PropId",
                principalTable: "Properties",
                principalColumn: "propId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_ClientId",
                table: "Transactions",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Users_ownerId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyImages_Properties_PropId",
                table: "PropertyImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_ClientId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_PropertyImages_PropId",
                table: "PropertyImages");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Properties");

            migrationBuilder.AddColumn<int>(
                name: "propertypropId",
                table: "PropertyImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    clientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterestedPropId = table.Column<int>(type: "int", nullable: false),
                    Emai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumper = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.clientId);
                    table.ForeignKey(
                        name: "FK_Clients_Properties_InterestedPropId",
                        column: x => x.InterestedPropId,
                        principalTable: "Properties",
                        principalColumn: "propId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    ownerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhonNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.ownerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImages_propertypropId",
                table: "PropertyImages",
                column: "propertypropId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_InterestedPropId",
                table: "Clients",
                column: "InterestedPropId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Owners_ownerId",
                table: "Properties",
                column: "ownerId",
                principalTable: "Owners",
                principalColumn: "ownerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImages_Properties_propertypropId",
                table: "PropertyImages",
                column: "propertypropId",
                principalTable: "Properties",
                principalColumn: "propId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Clients_ClientId",
                table: "Transactions",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "clientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
