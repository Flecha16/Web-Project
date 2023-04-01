using System;
using Microsoft.AspNetCore.Identity;

namespace Project.Models
{
	public class Account : IdentityUser
	{
        public int Id { get; set; }
        public UserRole UserRole { get; set; }
    }
    public enum UserRole
    {
        Admin,
        Manager,
        Employee
    }
}

