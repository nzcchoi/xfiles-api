using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace XFiles.Models
{
    public class XFolderUserRole
    {
        public Guid XFolderId { get; set; }
        public Guid ProjectRoleId { get; set; }
        public XFolderRoles XFolderRole { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        [IgnoreDataMember]
        [ForeignKey("XFolderId")]
        public XFolder XFolder { get; set; }
        [ForeignKey("ProjectRoleId")]
        public ProjectRole ProjectRole { get; set; }

    }
}
