using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Diplom.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ResponsForItems",
                columns: table => new
                {
                    ResponsForItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsForItems", x => x.ResponsForItemId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StorageWorkers",
                columns: table => new
                {
                    StorageWorkersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageWorkers", x => x.StorageWorkersId);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    StorageId = table.Column<int>(type: "int", maxLength: 85, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Addres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StorageWorkersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.StorageId);
                    table.ForeignKey(
                        name: "FK_Storages_StorageWorkers_StorageWorkersId",
                        column: x => x.StorageWorkersId,
                        principalTable: "StorageWorkers",
                        principalColumn: "StorageWorkersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    JobTittle = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    StorageWorkersId = table.Column<int>(type: "int", nullable: true),
                    ResponsForItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_ResponsForItems_ResponsForItemId",
                        column: x => x.ResponsForItemId,
                        principalTable: "ResponsForItems",
                        principalColumn: "ResponsForItemId");
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_StorageWorkers_StorageWorkersId",
                        column: x => x.StorageWorkersId,
                        principalTable: "StorageWorkers",
                        principalColumn: "StorageWorkersId");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", maxLength: 85, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StorageId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ResponsForItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_ResponsForItems_ResponsForItemId",
                        column: x => x.ResponsForItemId,
                        principalTable: "ResponsForItems",
                        principalColumn: "ResponsForItemId");
                    table.ForeignKey(
                        name: "FK_Items_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "StorageId");
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "В этой категории находяться мебель(диван, стул, кровать, шкафы и т.д.)", "Мебель" },
                    { 2, "В этой категории находяться все предметы временного пользования(перчатки, пакеты, масла, полотенца и т.д.)", "Расходники" },
                    { 3, "В этой категории находяться электроинструменты(дрель, шуруповерт, болгарка и т.д.)", "Электроинструмент" }
                });

            migrationBuilder.InsertData(
                table: "ResponsForItems",
                column: "ResponsForItemId",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Manager" },
                    { 3, "Worker" }
                });

            migrationBuilder.InsertData(
                table: "StorageWorkers",
                column: "StorageWorkersId",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Brand", "CategoryId", "Count", "Description", "Model", "Name", "Price", "ResponsForItemId", "SerialNumber", "StorageId" },
                values: new object[] { 5, "Trelt", 3, 1, "Шуруповерт с набором битам для выполнения различных работа", "Sg500", "Шуруповерт", 400m, 2, "15870643", null });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "StorageId", "Addres", "Name", "StorageWorkersId" },
                values: new object[,]
                {
                    { 1, "ул.Кальваарийская д.57", "Склад Кальварийской", 1 },
                    { 2, "ул.Трихомирова д.12", "Склад Трихомирова", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "HashPassword", "JobTittle", "Login", "ResponsForItemId", "RoleId", "Salt", "SecondName", "StorageWorkersId" },
                values: new object[,]
                {
                    { 1, "Виталий", "v0rp8ILZN1uaGv00H8CivzR1NX8cIn6kTDmFp1SBBjg=", "Складовщик", "VitJob123", null, 3, new byte[] { 165, 38, 42, 31, 166, 126, 188, 123, 8, 47, 188, 82, 51, 226, 115, 58 }, "Позднев", 1 },
                    { 2, "Александр", "B8LjEDfxo0Y3tiHE27+28x2xr5TNvdMocSWTfKMwr2o=", "Заведующий складом", "AleksJob", 1, 2, new byte[] { 90, 20, 223, 38, 155, 195, 129, 249, 15, 35, 235, 220, 7, 29, 247, 164 }, "Довольный", 2 },
                    { 3, "Федор", "gQxAsg3mhEPijpyJ7crT8uXS4AXxipFU9uLscJSfnhM=", "администратор", "admin", null, 1, new byte[] { 101, 70, 159, 33, 173, 208, 104, 70, 71, 176, 223, 137, 93, 2, 110, 27 }, "Кручев", null },
                    { 4, "Григорий", "A99DkcdjwB1DifMzti3akGuHxzgl+sfXSBe+gskRA/8=", "Электрик", "ElectrickGrig", 2, 3, new byte[] { 51, 204, 106, 19, 253, 208, 217, 107, 156, 27, 107, 220, 222, 122, 85, 133 }, "Морозов", null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Brand", "CategoryId", "Count", "Description", "Model", "Name", "Price", "ResponsForItemId", "SerialNumber", "StorageId" },
                values: new object[,]
                {
                    { 1, "Startul", 2, 150, "Перчатки латексные с сеткой для работы на производстве", "Латексные с сеткой", "Перчатки", 21.9m, null, "77098462", 2 },
                    { 2, "Trelt", 3, 2, "Шуруповерт с набором битам для выполнения различных работа", "Sg500", "Шуруповерт", 400m, null, "15870643", 2 },
                    { 3, "Vital", 1, 8, "Стул компьтерный с различными регулировками, металический", "ArkSteel", "Стул компьтерный", 239m, 1, "89Fer543", 2 },
                    { 4, "Startul", 2, 5, "Перчатки латексные с сеткой для работы на производстве", "Латексные с сеткой", "Перчатки", 21.9m, 2, "77098462", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ResponsForItemId",
                table: "Items",
                column: "ResponsForItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_StorageId",
                table: "Items",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_StorageWorkersId",
                table: "Storages",
                column: "StorageWorkersId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ResponsForItemId",
                table: "Users",
                column: "ResponsForItemId",
                unique: true,
                filter: "[ResponsForItemId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StorageWorkersId",
                table: "Users",
                column: "StorageWorkersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "ResponsForItems");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "StorageWorkers");
        }
    }
}
