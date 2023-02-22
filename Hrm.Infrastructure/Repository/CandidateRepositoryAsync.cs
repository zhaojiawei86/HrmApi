using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
	public class CandidateRepositoryAsync : BaseRepositoryAsync<Candidate>, ICandidateRepositoryAsync
	{
		public CandidateRepositoryAsync(HRMDbContext _context) : base(_context)
		{
		}
	}
}

