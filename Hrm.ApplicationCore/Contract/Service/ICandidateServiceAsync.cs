using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
	public interface ICandidateServiceAsync : IServiceAsync<CandidateRequestModel, CandidateResponseModel>
    {
	}
}

