﻿using BookReader.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReader.Domain.ViewModel
{
	public class ProfileViewModel
	{
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public string Email { get; set; }
		public string UserName { get; set; }
		
	}
}
