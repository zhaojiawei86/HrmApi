using System;
using System.ComponentModel.DataAnnotations;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.ApplicationCore.Entity;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;
using Hrm.Infrastructure.Repository;

namespace Hrm.Infrastructure.Service
{
    public class SubmissionServiceAsync : ISubmissionServiceAsync
    {
        private readonly ISubmissionRepositoryAsync submissionRepositoryAsync;

        public SubmissionServiceAsync(ISubmissionRepositoryAsync _submissionRepositoryAsync)
        {
            submissionRepositoryAsync = _submissionRepositoryAsync;
        }

        // async for insert is not necessory, speed up
        public Task<int> AddAsync(SubmissionRequestModel model)
        {
            Submission submission = new Submission()
            {
                CandidateId = model.CandidateId,
                JobRequirementId = model.JobRequirementId,
                AppliedDate = model.AppliedDate
    };
            return submissionRepositoryAsync.InsertAsync(submission);
        }

        public Task<int> DeleteAsync(int id)
        {
            return submissionRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<SubmissionResponseModel>> GetAllAsync()
        {
            var result = await submissionRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new SubmissionResponseModel()
                {
                    Id = x.Id,
                    CandidateId = x.CandidateId,
                    JobRequirementId = x.JobRequirementId,
                    AppliedDate = x.AppliedDate
                });
            }
            return null;

        }

        public async Task<SubmissionResponseModel> GetByIdAsync(int id)
        {
            var result = await submissionRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new SubmissionResponseModel()
                {
                    Id = result.Id,
                    CandidateId = result.CandidateId,
                    JobRequirementId = result.JobRequirementId,
                    AppliedDate = result.AppliedDate
                };
            }
            return null;
        }

        public async Task<int> UpdateAsync(SubmissionRequestModel model)
        {
            Submission submission = new Submission()
            {
                Id = model.Id,
                CandidateId = model.CandidateId,
                JobRequirementId = model.JobRequirementId,
                AppliedDate = model.AppliedDate
            };
            return await submissionRepositoryAsync.UpdateAsync(submission);
        }
    }
}
