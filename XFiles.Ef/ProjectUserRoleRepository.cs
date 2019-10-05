using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XFiles.Models;

namespace XFiles.Ef
{
    public class ProjectUserRoleRepository : SqlRepository<XFile>
    {
        public ProjectUserRoleRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
