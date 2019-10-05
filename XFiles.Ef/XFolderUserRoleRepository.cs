using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XFiles.Models;

namespace XFiles.Ef
{
    public class XFolderUserRoleRepository : SqlRepository<XFile>
    {
        public XFolderUserRoleRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
