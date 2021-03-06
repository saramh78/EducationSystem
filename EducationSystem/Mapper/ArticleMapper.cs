﻿using DataAccess.Model;
using EducationSystem.Dtos;
using System.Collections.Generic;
using System.Linq;

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
                        Links= x.ReferenceLinks.LinkDtosToLinks(x.MediaLinks)
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
                ReferenceLinks=x.Article.Links.ToList().LinksToReferenceLinks(),
                MediaLinks= x.Article.Links.ToList().LinksToMediaLinks()
            }).ToList();
        }
    }
}
