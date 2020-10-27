using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SPGetCategory1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"create or alter PROCEDURE GetCategories1 
	-- Add the parameters for the stored procedure here
	@categoryId int,
	@level int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

	;WITH CTE(Lvl,Id, Name, ParentId) AS 
	(
		SELECT 0 as Lvl, c1.Id,C1.Name,c1.ParentId
		 FROM Categories c1
		WHERE Id = @categoryId
		UNION ALL
		SELECT Lvl + 1,c2.Id,c2.Name,c2.ParentId
		FROM Categories c2 JOIN CTE as c ON c2.parentId = c.id
  )

  SELECT c.Lvl,c.Id as categoryId ,c.Name as  categoryName,c.ParentId as categoryParentId,co.Name  as courseName ,co.Id as courseId
  FROM CTE as c
  join Courses as co on c.Id = co.CategoryId
  where  c.Lvl <= @level


END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
