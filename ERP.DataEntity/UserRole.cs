using System;
using System.Collections.Generic;

namespace ERP.DataEntity;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public string? Remark { get; set; }
}
