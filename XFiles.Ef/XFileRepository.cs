using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XFiles.Models;

namespace XFiles.Ef
{
    public class XFileRepository : SqlRepository<XFile>
    {
        public XFileRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
