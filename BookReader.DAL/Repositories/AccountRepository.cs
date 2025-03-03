﻿using BookReader.DAL.Interfaces;
using BookReader.Domain.Entity;
using BookReader.Domain.Enum;
using BookReader.Domain.Extensions;
using BookReader.Domain.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookReader.DAL.Repositories
{
	public class AccountRepository : IBaseRepository<User>, IAccountRepository
	{
		public readonly ApplicationDbContext _db;

		public AccountRepository(ApplicationDbContext db)
		{
			_db = db;
		}

		public async Task<bool> Create(User entity)
		{
			await _db.Users.AddAsync(entity);
			await _db.SaveChangesAsync();
			return true;
		}

		public Task<bool> Delete(User entity)
		{
			throw new NotImplementedException();
		}

		public Task<User> Get(int id)
		{
			throw new NotImplementedException();
		}

		public IQueryable<User> GetAll()
		{
			return _db.Users;			
		}

        public async Task<User> LoginTry(LoginViewModel loginViewModel)
        {
			return await _db.Users.FirstOrDefaultAsync(x => x.Login == loginViewModel.Login && x.Password == HashPasswordExtension.HashPassword(loginViewModel.Password));
        }

        public async Task<bool> IfLoginExist(string loginName)
        {
			//return await _db.Users.FirstOrDefaultAsync(x => x.Login == loginName);
			return await _db.Users.AnyAsync(x => x.Login == loginName);
		}

        public Task<IEnumerable<User>> Select()
		{
			throw new NotImplementedException();
		}

		public bool Update(User entity)
		{
			throw new NotImplementedException();
		}
	}
}
