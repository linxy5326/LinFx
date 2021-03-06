﻿using System;

namespace LinFx.Extensions.Identity.Models
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role : IdentityRole<string>
    {
        public Role() { }

        public Role(string roleName) : base(roleName) { }
    }

    /// <summary>
    /// 角色
    /// </summary>
    public class IdentityRole<TKey> : Microsoft.AspNetCore.Identity.IdentityRole<TKey> where TKey : IEquatable<TKey>
    {
        public IdentityRole() { }

        public IdentityRole(string roleName) : base(roleName) { }
    }
}
