using System;
using System.Collections.Generic;
using System.Text;

namespace XFiles.Models
{
    [Flags]
    public enum XFolderRoles
    {
        Read = 1,
        Write = 2,
        Modify = 4,
        Delete = 8,
    }
}
