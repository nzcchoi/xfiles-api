using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace XFiles.Ef
{
    public class XFilesUnitOfWork : IDisposable
    {
        public XFilesUnitOfWork(DbContext dbContext)
        {
            ProjectRep = new ProjectRepository(dbContext);
            ProjectRoleRep = new ProjectRoleRepository(dbContext);
            ProjectUserRoleRep = new ProjectUserRoleRepository(dbContext);
            XFileRep = new XFileRepository(dbContext);
            XFolderRepo = new XFolderRepository(dbContext);
            XFolderUserRoleRep = new XFolderUserRoleRepository(dbContext);
        }

        public ProjectRepository ProjectRep { get; }
        public ProjectRoleRepository ProjectRoleRep { get; }
        public ProjectUserRoleRepository ProjectUserRoleRep { get; }
        public XFileRepository XFileRep { get; }
        public XFolderRepository XFolderRepo { get; }
        public XFolderUserRoleRepository XFolderUserRoleRep { get; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
