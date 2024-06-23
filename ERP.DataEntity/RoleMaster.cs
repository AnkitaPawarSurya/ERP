using System;
using System.Collections.Generic;

namespace ERP.DataEntity;

public partial class RoleMaster
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
