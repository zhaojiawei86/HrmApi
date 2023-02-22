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
    public class UserServiceAsync : IUserServiceAsync
    {
        private readonly IUserRepositoryAsync userRepositoryAsync;

        public UserServiceAsync(IUserRepositoryAsync _userRepositoryAsync)
        {
            userRepositoryAsync = _userRepositoryAsync;
        }

        // async for insert is not necessory, speed up
        public Task<int> AddAsync(UserRequestModel model)
        {
            User user = new User()
            {
                UserName = model.UserName,
                EmailId = model.EmailId,
                Password = model.Password
            };
            return userRepositoryAsync.InsertAsync(user);
        }

        public Task<int> DeleteAsync(int id)
        {
            return userRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserResponseModel>> GetAllAsync()
        {
            var result = await userRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new UserResponseModel()
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    EmailId = x.EmailId,
                    Password = x.Password
                });
            }
            return null;

        }

        public async Task<UserResponseModel> GetByIdAsync(int id)
        {
            var result = await userRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new UserResponseModel()
                {
                    Id = result.Id,
                    UserName = result.UserName,
                    EmailId = result.EmailId,
                    Password = result.Password
                };
            }
            return null;
        }

        public async Task<int> UpdateAsync(UserRequestModel model)
        {
            User user = new User()
            {
                Id = model.Id,
                UserName = model.UserName,
                EmailId = model.EmailId,
                Password = model.Password
            };
            return await userRepositoryAsync.UpdateAsync(user);
        }
    }
}
