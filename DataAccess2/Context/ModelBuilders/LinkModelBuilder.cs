using DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context.ModelBuilders
{
    public static class LinkModelBuilder
    {
        public static void LinkSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link>().HasData(
                new Link
                {
                    Id=1,
                    ArticleId=1,
                    Url= "https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/",
                    LinkType =LinkType.Reference
                },
                new Link
                {
                    Id = 2,
                    ArticleId = 1,
                    Url= "https://docs.microsoft.com/en-us/dotnet/csharp/basic-types",
                    LinkType = LinkType.Reference
                },
                new Link
                {
                    Id = 3,
                    ArticleId = 1,
                    Url = "https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes",
                    LinkType = LinkType.Reference
                }
                );
        }
    }
}
