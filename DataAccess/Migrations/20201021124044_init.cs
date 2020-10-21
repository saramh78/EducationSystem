using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: false),
                    LinkType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseParts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 32, nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseParts_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursePartArticles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoursePartId = table.Column<int>(nullable: false),
                    ArticleId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePartArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursePartArticles_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursePartArticles_CourseParts_CoursePartId",
                        column: x => x.CoursePartId,
                        principalTable: "CourseParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "C# syntax is highly expressive, yet it's also simple and easy to learn. The curly brace syntax of C# will be instantly recognizable to anyone familiar with C, C++, Java or JavaScript. Developers who know any of these languages are typically able to work productively in C# within a short time. C# provides powerful features such as nullable types, delegates, lambda expressions, pattern matching, and safe direct memory access. C# supports generic methods and types, which provide increased type safety and performance. C# provides iterators, which enable implementers of collection classes to define custom behaviors for client code. Language-Integrated Query (LINQ) expressions make the strongly typed query a first-class language construct." },
                    { 2, "C# is a strongly typed language. Every variable and constant has a type, as does every expression that evaluates to a value. Every method signature specifies a type for each input parameter and for the return value. The .NET class library defines a set of built-in numeric types as well as more complex types that represent a wide variety of logical constructs, such as the file system, network connections, collections and arrays of objects, and dates. A typical C# program uses types from the class library as well as user-defined types that model the concepts that are specific to the program's problem domain." },
                    { 3, "A type that is defined as a class is a reference type. hen the object is created, enough memory is allocated on the managed heap for that specific object, and the variable holds only a reference to the location of said object. Types on the managed heap require overhead both when they are allocated and when they are reclaimed by the automatic memory management functionality of the CLR, which is known as garbage collection. However, garbage collection is also highly optimized and in most scenarios, it does not create a performance issue." }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, "Computer", null },
                    { 3, "DataBase", 3 },
                    { 4, "Network", 4 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[] { 2, "Programming", 1 });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "ArticleId", "LinkType", "Url" },
                values: new object[,]
                {
                    { 1, 1, 2, "https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/" },
                    { 2, 1, 2, "https://docs.microsoft.com/en-us/dotnet/csharp/basic-types" },
                    { 3, 1, 2, "https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[] { 5, "Concepts", 2 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[] { 6, "Web", 2 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[] { 7, "Application", 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 4, 6, null, "c++" },
                    { 1, 7, null, "C#" },
                    { 2, 7, null, "Android" },
                    { 3, 7, null, "Flutter" }
                });

            migrationBuilder.InsertData(
                table: "CourseParts",
                columns: new[] { "Id", "CourseId", "Order", "Title" },
                values: new object[] { 1, 1, 1, "Get Started" });

            migrationBuilder.InsertData(
                table: "CourseParts",
                columns: new[] { "Id", "CourseId", "Order", "Title" },
                values: new object[] { 2, 1, 2, "Types" });

            migrationBuilder.InsertData(
                table: "CourseParts",
                columns: new[] { "Id", "CourseId", "Order", "Title" },
                values: new object[] { 3, 1, 0, "Classes" });

            migrationBuilder.InsertData(
                table: "CoursePartArticles",
                columns: new[] { "Id", "ArticleId", "CoursePartId", "Order" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "CoursePartArticles",
                columns: new[] { "Id", "ArticleId", "CoursePartId", "Order" },
                values: new object[] { 2, 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "CoursePartArticles",
                columns: new[] { "Id", "ArticleId", "CoursePartId", "Order" },
                values: new object[] { 3, 3, 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePartArticles_ArticleId",
                table: "CoursePartArticles",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePartArticles_CoursePartId",
                table: "CoursePartArticles",
                column: "CoursePartId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseParts_CourseId",
                table: "CourseParts",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ArticleId",
                table: "Links",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursePartArticles");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "CourseParts");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
