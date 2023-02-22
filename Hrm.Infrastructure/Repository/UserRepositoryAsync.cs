using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
	public class UserRepositoryAsync : BaseRepositoryAsync<User>, IUserRepositoryAsync
    {
        public UserRepositoryAsync(HRMDbContext _context) : base(_context)
        {
        }
    }
}

