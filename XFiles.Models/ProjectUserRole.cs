using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace XFiles.Models
{
    public class ProjectUserRole
    {
        public Guid ProjectId { get; set; }
        public string UserId { get; set; }
        public Guid ProjectRoleId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }

        [IgnoreDataMember]
        public Project Project { get; set; }
        public IList<ProjectRole> ProjectRoles { get; set; }
    }
}
