using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0e7a8f40-243b-45f1-b35d-d263894d2229"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("4d216440-f620-4062-97bf-5377206be1fd"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("884ec796-39fa-4af2-86a2-5c00d2f2bb32"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8ed0f362-f7b1-4256-ab58-0b84f04b23b6"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("993a54de-4565-4ecf-8fab-159abf1b01b5"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a604d90b-7576-4765-ba88-9cce610a982e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a7c51937-26f4-47b0-9c31-03b8c396578a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b87a8fa8-3ae8-49c5-8307-8516677aafcd"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b9fdc5dd-3236-49ca-82ad-35e92d676b6d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ddbb54a8-75de-4a21-b6a7-c901b767bb07"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("083a3607-22e3-43af-875e-02768a03b60f"), "culture", "London", new DateTime(2023, 11, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4168), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("2c7f50ed-3022-4fb6-98d9-e33f0d6d38ac"), "music", "London", new DateTime(2024, 4, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4190), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("42cc291f-4c6b-4afe-87fa-71034a5b1de3"), "drinks", "London", new DateTime(2023, 8, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4152), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("59ea357c-e306-4bb7-979e-6402dd2e738e"), "drinks", "London", new DateTime(2024, 2, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4185), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("60e092d5-5beb-421b-b26b-dc586bd0ca37"), "travel", "London", new DateTime(2024, 5, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4192), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("776e17c4-b9b6-4f3a-b953-1b6a127456c8"), "drinks", "London", new DateTime(2024, 3, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4188), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("8652364b-e3bd-4802-9e8c-7b802bdf846b"), "culture", "Paris", new DateTime(2023, 9, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4165), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("9a9adf49-da61-41b8-bc7c-de2ea502e76d"), "drinks", "London", new DateTime(2024, 1, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4180), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("9eff64c8-9aef-4499-be42-dc8ac957410f"), "music", "London", new DateTime(2023, 12, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4170), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("f94ffb8f-6b57-48a6-bac2-3c92c54f4466"), "film", "London", new DateTime(2024, 6, 12, 9, 29, 34, 104, DateTimeKind.Utc).AddTicks(4195), "Activity 8 months in future", "Future Activity 8", "Cinema" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("083a3607-22e3-43af-875e-02768a03b60f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2c7f50ed-3022-4fb6-98d9-e33f0d6d38ac"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("42cc291f-4c6b-4afe-87fa-71034a5b1de3"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("59ea357c-e306-4bb7-979e-6402dd2e738e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("60e092d5-5beb-421b-b26b-dc586bd0ca37"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("776e17c4-b9b6-4f3a-b953-1b6a127456c8"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8652364b-e3bd-4802-9e8c-7b802bdf846b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9a9adf49-da61-41b8-bc7c-de2ea502e76d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9eff64c8-9aef-4499-be42-dc8ac957410f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f94ffb8f-6b57-48a6-bac2-3c92c54f4466"));

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("0e7a8f40-243b-45f1-b35d-d263894d2229"), "music", "London", new DateTime(2023, 11, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(8987), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("4d216440-f620-4062-97bf-5377206be1fd"), "drinks", "London", new DateTime(2023, 7, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(8949), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("884ec796-39fa-4af2-86a2-5c00d2f2bb32"), "culture", "London", new DateTime(2023, 10, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(8975), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("8ed0f362-f7b1-4256-ab58-0b84f04b23b6"), "music", "London", new DateTime(2024, 3, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(9000), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("993a54de-4565-4ecf-8fab-159abf1b01b5"), "culture", "Paris", new DateTime(2023, 8, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(8972), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("a604d90b-7576-4765-ba88-9cce610a982e"), "film", "London", new DateTime(2024, 5, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(9006), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("a7c51937-26f4-47b0-9c31-03b8c396578a"), "travel", "London", new DateTime(2024, 4, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(9002), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("b87a8fa8-3ae8-49c5-8307-8516677aafcd"), "drinks", "London", new DateTime(2023, 12, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(8989), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("b9fdc5dd-3236-49ca-82ad-35e92d676b6d"), "drinks", "London", new DateTime(2024, 2, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(8998), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("ddbb54a8-75de-4a21-b6a7-c901b767bb07"), "drinks", "London", new DateTime(2024, 1, 7, 2, 18, 39, 562, DateTimeKind.Utc).AddTicks(8995), "Activity 4 months in future", "Future Activity 4", "Yet another pub" }
                });
        }
    }
}
