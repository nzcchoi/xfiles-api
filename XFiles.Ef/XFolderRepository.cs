using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XFiles.Models;

namespace XFiles.Ef
{
    public class XFolderRepository : SqlRepository<XFile>
    {
        public XFolderRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
