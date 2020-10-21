using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories.Class
{
    public class LinkRepository : BaseRepository<Link, int>, ILinkRepository
    {
        public LinkRepository(EducationSystemContext EducationSystemContext) : base(EducationSystemContext)
        {

        }
    }
}