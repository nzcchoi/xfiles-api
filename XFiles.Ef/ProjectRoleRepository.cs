using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XFiles.Models;

namespace XFiles.Ef
{
    public class ProjectRoleRepository : SqlRepository<XFile>
    {
        public ProjectRoleRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
