using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    public partial class AdminRol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(SELECT Id FROM AspNetRoles WHERE Id = '7ffdfd0a-cd80-4de1-9a88-d0c8a6ee51a9')
                                   BEGIN
	                                   INSERT AspNetRoles (Id, [Name], [NormalizedName]) 
	                                   VALUES ('7ffdfd0a-cd80-4de1-9a88-d0c8a6ee51a9', 'admin', 'ADMIN')
                                   END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id = '7ffdfd0a-cd80-4de1-9a88-d0c8a6ee51a9'");
        }
    }
}
