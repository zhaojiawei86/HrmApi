using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
	public class EmployeeRoleRepositoryAsync : BaseRepositoryAsync<EmployeeRole>, IEmployeeRoleRepositoryAsync
    {
		public EmployeeRoleRepositoryAsync(HRMDbContext _context) : base(_context) 
		{
		}
	}
}

