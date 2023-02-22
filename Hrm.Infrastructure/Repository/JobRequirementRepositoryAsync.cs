﻿using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;

namespace Hrm.Infrastructure.Repository
{
	public class JobRequirementRepositoryAsync : BaseRepositoryAsync<JobRequirement>, IJobRequirementRepositoryAsync
    {
        public JobRequirementRepositoryAsync(HRMDbContext _context) : base(_context)
        {
        }
    }
}
