using DataAccess.Model;
using EducationSystem.Dtos;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace EducationSystem.Mapper
{
    public static class ArticleMapper
    {
        public static List<CoursePartArticle> GetArticleDto(this List<ArticleInsertApiModel> articles)
        {
            var result = articles.Select(x =>
                new CoursePartArticle
                {
                    Order = x.Order,
                    Article = new Article()
                    {
                        Text = x.Text,
                        Links = x.Links.Select(l => new Link { LinkType = l.LinkType, Url = l.Url})
                            .ToList()
                    }
                }).ToList();
            return result;
        }

        public static List<ArticleInsertApiModel> GetArticle(this ICollection<CoursePartArticle> coursePartArticles)
        {
            return coursePartArticles.Select(x => new ArticleInsertApiModel()
            {
                Order = x.Order,
                Text = x.Article.Text,
                Links = x.Article.Links.LinksToLinkDtos(),
            }).ToList();
        }
    }
}
