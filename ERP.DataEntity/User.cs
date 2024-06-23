using System;
using System.Collections.Generic;

namespace ERP.DataEntity;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string PasswordSalt { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobNo { get; set; } = null!;

    public DateOnly Dob { get; set; }

    public bool? IsSubscribe { get; set; }

    public string? Gender { get; set; }

    public int RoleId { get; set; }

    public virtual RoleMaster Role { get; set; } = null!;
}
