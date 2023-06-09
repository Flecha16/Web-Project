﻿using System;
namespace Project.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public String Name { get; set; }
        public String Email { get; set; }
		public String Phone { get; set; }
        public UserRoleType UserRole { get; set; }
    }
	public enum UserRoleType
	{
		Admin,
		Manager,
		Employee
	}
}

