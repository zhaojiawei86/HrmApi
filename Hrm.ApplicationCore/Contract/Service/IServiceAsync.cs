using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
	public interface IServiceAsync<TRequestModel, TResponseModel>
        where TRequestModel : class
        where TResponseModel : class
	{
        Task<int> AddAsync(TRequestModel model);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(TRequestModel model);
        Task<TResponseModel> GetByIdAsync(int id);
        Task<IEnumerable<TResponseModel>> GetAllAsync();
    }
}

