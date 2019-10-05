using System;
using System.Collections.Generic;
using System.Text;

namespace XFiles.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public IList<ProjectUserRole> UserRoles { get; set; }
    }
}
