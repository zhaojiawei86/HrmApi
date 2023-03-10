using System;
using System.ComponentModel.DataAnnotations;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.ApplicationCore.Entity;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.Infrastructure.Service
{
	public class JobRequirementServiceAsync : IJobRequirementServiceAsync
    {
        private readonly IJobRequirementRepositoryAsync jobRequirementRepositoryAsync;

        public JobRequirementServiceAsync(IJobRequirementRepositoryAsync _jobRequirementRepositoryAsync)
		{
            jobRequirementRepositoryAsync = _jobRequirementRepositoryAsync;
        }

        // async for insert is not necessory, speed up
        public Task<int> AddAsync(JobRequirementRequestModel model)
        {
            JobRequirement jobRequirement = new JobRequirement()
            {
                Title = model.Title,
                JobLocation = model.JobLocation,
                NoOfPosition = model.NoOfPosition,
                PostingDate = model.PostingDate,
                ClosingDate = model.ClosingDate,
                IsActive = model.IsActive,
                Description = model.Description,
                JobCategoryId = model.JobCategoryId
            };
            return jobRequirementRepositoryAsync.InsertAsync(jobRequirement);
        }

        public Task<int> DeleteAsync(int id)
        {
            return jobRequirementRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<JobRequirmentResponseModel>> GetAllAsync()
        {
            var result = await jobRequirementRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new JobRequirmentResponseModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    JobLocation = x.JobLocation,
                    NoOfPosition = x.NoOfPosition,
                    PostingDate = x.PostingDate,
                    ClosingDate = x.ClosingDate,
                    IsActive = x.IsActive,
                    Description = x.Description,
                    JobCategoryId = x.JobCategoryId
                });
            }
            return null;
            
        }

        public async Task<JobRequirmentResponseModel> GetByIdAsync(int id)
        {
            var result = await jobRequirementRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new JobRequirmentResponseModel()
                {
                    Id = result.Id,
                    Title = result.Title,
                    JobLocation = result.JobLocation,
                    NoOfPosition = result.NoOfPosition,
                    PostingDate = result.PostingDate,
                    ClosingDate = result.ClosingDate,
                    IsActive = result.IsActive,
                    Description = result.Description,
                    JobCategoryId = result.JobCategoryId
                };
            }
            return null;
        }

        public async Task<int> UpdateAsync(JobRequirementRequestModel model)
        {
            JobRequirement jobRequirement = new JobRequirement()
            {
                Id = model.Id,
                Title = model.Title,
                JobLocation = model.JobLocation,
                NoOfPosition = model.NoOfPosition,
                PostingDate = model.PostingDate,
                ClosingDate = model.ClosingDate,
                IsActive = model.IsActive,
                Description = model.Description,
                JobCategoryId = model.JobCategoryId
            };
            return await jobRequirementRepositoryAsync.UpdateAsync(jobRequirement);
        }
    }
}

