﻿using BookReader.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReader.Domain.Entity
{
	public class User
	{
		public int Id { get; set; }
		public string? Login { get; set; }
		public string? Password { get; set; }
		public UserRole UserRole { get; set; }
		public UserProfile UserProfile { get; set; }
	}
}
