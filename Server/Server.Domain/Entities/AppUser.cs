﻿using Microsoft.AspNetCore.Identity;
using Server.Domain.Enums;

namespace Server.Domain.Entities
{
    public sealed class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => string.Join(" ", FirstName, LastName);
        public UserRoleTypeEnum UserRole { get; set; } = UserRoleTypeEnum.Employee;
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpires { get; set; }
    }
}
