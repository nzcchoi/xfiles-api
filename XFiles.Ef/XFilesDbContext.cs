using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XFiles.Models;

namespace XFiles.Ef
{
    public class XFilesDbContext : DbContext
    {
        public XFilesDbContext(DbContextOptions<XFilesDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<XFile>().ToTable("XFile");
            modelBuilder.Entity<XFolder>().ToTable("XFolder");
        }
    }
}
