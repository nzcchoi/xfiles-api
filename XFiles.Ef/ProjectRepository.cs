using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XFiles.Models;

namespace XFiles.Ef
{
    public class ProjectRepository : SqlRepository<Project>
    {
        public ProjectRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
