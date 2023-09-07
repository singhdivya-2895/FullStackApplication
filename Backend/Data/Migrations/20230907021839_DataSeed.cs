using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
