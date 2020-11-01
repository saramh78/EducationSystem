using DataAccess.Model;
using EducationSystem.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace EducationSystem.Mapper
{
    public static class LinkMapper
    {
        public static LinkDto LinkToLinkDto(this Link link)
        {
            return new LinkDto()
            {
                LinkType = link.LinkType,
                Url = link.Url
            };
        }

        public static List<LinkDto> LinksToLinkDtos(this ICollection<Link> links)
        {
            return links.Select(x => LinkToLinkDto(x)).ToList();
        }
    }
}