using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
	public class InterviewTypeRepositoryAsync : BaseRepositoryAsync<InterviewType>, IInterviewTypeRepositoryAsync
    {
		public InterviewTypeRepositoryAsync(HRMDbContext _context) : base(_context)
        {
		}
	}
}

